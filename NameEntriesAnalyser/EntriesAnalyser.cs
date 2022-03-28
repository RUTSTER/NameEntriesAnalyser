namespace NameEntriesAnalyser
{
    internal class EntriesAnalyser
    {
        public static Dictionary<string, int> GetNamesStatistics(List<string> namesEntries)
        {
            Dictionary<string, int> namesStatistics = new Dictionary<string, int>();

            foreach (string name in namesEntries)
            {
                if (namesStatistics.ContainsKey(name))
                {
                    namesStatistics[name] += 1;
                    continue;
                }

                namesStatistics.Add(name, 1);
            }

            return namesStatistics;
        }

        public static List<string> GetMostPopularNames(Dictionary<string, int> namesStatistics)
        {
            int maxEntries = namesStatistics.Values.ToList().Max();

            return namesStatistics.Where(x => x.Value == maxEntries)
                .Select(keyValuePair => keyValuePair.Key)
                .ToList();
        }
    }
}
