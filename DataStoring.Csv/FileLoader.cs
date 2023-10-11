namespace DavidTielke.PersonManagerApp.Data.DataStoring.Csv;

public class FileLoader : IFileLoader
{
    public string[] LoadLines(string path)
    {
        return File.ReadAllLines(path);
    }
}