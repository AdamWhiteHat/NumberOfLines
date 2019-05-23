using System;
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

			lines = lines.Select(line =>
				line
				.Replace("{", "").Replace("}", "")
				.Replace("/*", "").Replace("*/", "")
				.Trim()
				); // Remove spaces, tabs, single brackets, semicolons
			lines = lines.Where(s => !s.StartsWith("//")); // Removes comments			
			lines = lines.Where(s => !s.StartsWith("#region", StringComparison.InvariantCultureIgnoreCase));
			lines = lines.Where(s => !s.StartsWith("#endregion", StringComparison.InvariantCultureIgnoreCase));
			lines = lines.Where(s => !s.StartsWith("[assembly:", StringComparison.InvariantCultureIgnoreCase)); // Removes [assembly:
			lines = lines.Where(s => !string.IsNullOrWhiteSpace(s)); // Removes empty lines, or lines that were blanked by above logic

			return lines.Count();
		}
	}
}
