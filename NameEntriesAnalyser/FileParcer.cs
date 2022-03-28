using System.Text.RegularExpressions;

namespace NameEntriesAnalyser
{
    internal class FileParcer
    {
        public static List<string> GetNamesFromFile(string pathToFile)
        {
            string pattern = @"^\w+ (\w+)$";

            return File.ReadAllLines(pathToFile)
                .Select(line => new Regex(pattern).Match(line).Groups[1].Value)
                .ToList();
        }
    }
}
