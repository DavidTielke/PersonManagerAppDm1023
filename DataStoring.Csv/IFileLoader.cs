namespace DavidTielke.PersonManagerApp.Data.DataStoring.Csv;

public interface IFileLoader
{
    string[] LoadLines(string path);
}