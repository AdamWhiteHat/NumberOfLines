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

			IEnumerable<string> foundFiles = Directory.EnumerateFiles(dirInfo.FullName, "*.cs", SearchOption.AllDirectories);

			int numberOfLines = foundFiles.Select(fn => GetNumberOfLines(fn)).Sum();

			labelNumberOfLines.Text = numberOfLines.ToString();
		}

		private string GetFolderDialog()
		{
			FolderBrowserDialog folderDialog = new FolderBrowserDialog();
			if (folderDialog.ShowDialog() == DialogResult.OK)
			{
				return folderDialog.SelectedPath;
			}
			return string.Empty;
		}

		private int GetNumberOfLines(string filePath)
		{
			return File.ReadLines(filePath).Count();
		}
	}
}
