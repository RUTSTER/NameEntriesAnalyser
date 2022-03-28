namespace NameEntriesAnalyser
{
    internal class EntryPoint
    {
        static void Main(string[] args)
        {
            List<string> namesList = FileParcer.GetNamesFromFile(FileManager.GetPathToFileInProjectDirectory());

            Dictionary<string, int> namesStatistics = EntriesAnalyser.GetNamesStatistics(namesList);
            List<string> mostPopularNames = EntriesAnalyser.GetMostPopularNames(namesStatistics);

            ConsoleManager.PrintResults(mostPopularNames, namesStatistics);
        }        
    }
}
