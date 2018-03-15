using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace NumberOfLines
{
	public static class NumberOfLines
	{
		public static int GetNumberOfLines_Fast(string filePath)
		{
			return File.ReadLines(filePath).Count();
		}

		public static int GetNumberOfLines_Accurate(string filePath)
		{
			IEnumerable<string> lines = File.ReadAllLines(filePath);

			lines = lines.Select(line => line.Replace(" ", "").Replace("\t", "").Replace("{", "").Replace("}", "").Replace(";", "")); // Remove spaces, tabs, single brackets, semicolons
			lines = lines.Where(s => !s.StartsWith("//")); // Removes comments
			lines = lines.Where(s => !s.StartsWith("[assembly:")); // Removes [assembly:
			lines = lines.Where(s => s.Length > 0); // Removes empty lines, or lines that were blanked by above logic

			return lines.Count();
		}
	}
}
