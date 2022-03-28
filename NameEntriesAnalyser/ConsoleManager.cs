namespace NameEntriesAnalyser
{
    internal class ConsoleManager
    {
        public static void PrintResults(List<string> mostPopularNames, Dictionary<string, int> namesStatistics)
        {
            Console.WriteLine("Most popular names:");

            foreach (string name in mostPopularNames)
            {
                Console.WriteLine($"{name} - found {namesStatistics[name]} entries;");
            }
        }
    }
}
