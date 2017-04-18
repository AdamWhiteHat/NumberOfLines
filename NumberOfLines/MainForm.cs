using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberOfLines
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			string directoryPath = GetFolderDialog();
			if (string.IsNullOrWhiteSpace(directoryPath))
			{
				return;
			}

			tbFolderPath.Text = directoryPath + "\\*";

			DirectoryInfo dirInfo = new DirectoryInfo(directoryPath);
			if (!dirInfo.Exists)
			{
				return;
			}

			string searchpattern = tbSearchPattern.Text;
			if (string.IsNullOrWhiteSpace(searchpattern))
			{
				searchpattern = "*.cs";
			}

			IEnumerable<string> foundFiles = Directory.EnumerateFiles(dirInfo.FullName, searchpattern, SearchOption.AllDirectories);

			int numberOfLines = foundFiles.Select(fn => GetNumberOfLines(fn)).Sum();

			labelNumberOfLines.Text = numberOfLines.ToString();
		}

		private string browseRootFolder = string.Empty;
		private string GetFolderDialog()
		{
			FolderBrowserDialog folderDialog = new FolderBrowserDialog();
			if (!string.IsNullOrWhiteSpace(browseRootFolder))
			{
				folderDialog.SelectedPath = browseRootFolder;
			}
			else
			{
				folderDialog.RootFolder = Environment.SpecialFolder.MyDocuments;
			}

			if (folderDialog.ShowDialog() == DialogResult.OK)
			{
				string selectedPath = folderDialog.SelectedPath;
				browseRootFolder = Path.GetFullPath(selectedPath);
				return selectedPath;
			}
			return string.Empty;
		}

		private int GetNumberOfLines(string filePath)
		{
			return File.ReadLines(filePath).Count();
		}
	}
}
