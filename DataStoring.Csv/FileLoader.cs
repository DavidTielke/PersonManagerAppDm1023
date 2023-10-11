namespace DavidTielke.PersonManagerApp.Data.DataStoring.Csv;

public class FileLoader
{
    public string[] LoadLines(string path)
    {
        return File.ReadAllLines(path);
    }
}