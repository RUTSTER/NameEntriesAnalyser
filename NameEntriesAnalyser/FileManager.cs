namespace NameEntriesAnalyser
{
    internal class FileManager
    {
        private const string DefaultFileName = "Users.txt";

        public static string GetPathToFileInProjectDirectory()
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory)!.Parent!.Parent!.FullName;
            return $@"{projectDirectory}\{DefaultFileName}";
        }
    }
}
