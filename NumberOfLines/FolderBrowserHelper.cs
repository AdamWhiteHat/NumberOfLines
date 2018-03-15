using System;
using System.IO;
using System.Windows.Forms;

namespace NumberOfLines
{
	public static class FolderBrowserHelper
	{
		private static string LastSelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

		private static void UpdateLastSelectedPath(string path)
		{
			LastSelectedPath = Path.GetFullPath(path);
		}

		public static string BrowseForFolder()
		{
			using (FolderBrowserDialog folderDialog = new FolderBrowserDialog() { SelectedPath = LastSelectedPath })
			{
				string result = "";

				if (folderDialog.ShowDialog() == DialogResult.OK)
				{
					result = folderDialog.SelectedPath;
					UpdateLastSelectedPath(result);
				}

				return result;
			}
		}

	}
}
