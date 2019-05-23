using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace NumberOfLines
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		#region Methods

		private void ProcessFileLines(string folderPath, string searchPattern)
		{
			IEnumerable<string> foundFiles = EnumerateFiles(folderPath, searchPattern);

			int numberOfLines = foundFiles.Select(fn => NumberOfLines.GetNumberOfLines_Accurate(fn)).Sum();

			SetNumberOfLines(numberOfLines);
		}

		private IEnumerable<string> EnumerateFiles(string rootDirectory, string searchPattern)
		{
			IEnumerable<string> result = new string[] { };

			if (Directory.Exists(rootDirectory))
			{
				result = Directory.EnumerateFiles(rootDirectory, searchPattern, SearchOption.AllDirectories);
			}

			return result;
		}

		#endregion

		#region WebForm Events

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			string folderPath = FolderBrowserHelper.BrowseForFolder();

			if (!string.IsNullOrWhiteSpace(folderPath))
			{
				SetNumberOfLines(-1);
				SetFolderPath(folderPath);

				ProcessFileLines(folderPath, GetSearchPattern());
			}
		}

		private void tbFolderPath_TextChanged(object sender, EventArgs e)
		{
			ProcessFileLines(tbFolderPath.Text, GetSearchPattern());
		}

		private void textBox_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
			{
				ProcessFileLines(tbFolderPath.Text, GetSearchPattern());
			}
		}

		#endregion

		#region Form controls getters/setters

		public void SetFolderPath(string folderPath)
		{
			if (!string.IsNullOrWhiteSpace(folderPath))
			{
				tbFolderPath.Text = Path.GetFullPath(folderPath);
			}
		}

		public string GetSearchPattern()
		{
			return string.IsNullOrWhiteSpace(tbSearchPattern.Text) ? "*.cs" : tbSearchPattern.Text;
		}

		public void SetNumberOfLines(int numberOfLines)
		{
			tbNumberOfLines.Text = numberOfLines < 0 ? "" : string.Format("{0:n0}", numberOfLines);
		}

		#endregion

	}
}
