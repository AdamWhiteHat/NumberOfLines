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

		private void ProcessFileLines(string folderPath, string searchPattern)
		{
			IEnumerable<string> foundFiles = EnumerateFiles(folderPath, searchPattern);

			int numberOfLines = foundFiles.Select(fn => NumberOfLines.GetNumberOfLines_Accurate(fn)).Sum();

			SetNumberOfLines(numberOfLines);
		}

		private IEnumerable<string> EnumerateFiles(string rootDirectory, string searchPattern)
		{
			IEnumerable<string> result = new string[] { };

			DirectoryInfo dirInfo = new DirectoryInfo(rootDirectory);
			if (dirInfo.Exists)
			{
				result = Directory.EnumerateFiles(dirInfo.FullName, searchPattern, SearchOption.AllDirectories);
			}

			return result;
		}

		#endregion

		#region Form controls getters/setters

		public void SetFolderPath(string folderPath)
		{
			if (!string.IsNullOrWhiteSpace(folderPath))
			{
				tbFolderPath.Text = folderPath + "\\*";
			}
		}

		public string GetSearchPattern()
		{
			return string.IsNullOrWhiteSpace(tbSearchPattern.Text) ? "*.cs" : tbSearchPattern.Text;
		}

		public void SetNumberOfLines(int numberOfLines)
		{
			labelNumberOfLines.Text = numberOfLines < 0 ? "" : string.Format("{0:n0}", numberOfLines);
		}

		#endregion
	}
}
