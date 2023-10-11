using DavidTielke.PersonManagerApp.Data.DataStoring.Csv;
using DavidTielke.PersonManagerApp.Logic.PersonManagement;

namespace DavidTielke.PersonManagerApp.UI.ConsoleClient;

internal class Program
{
    private static void Main(string[] args)
    {
        var loader = new FileLoader();
        var parser = new PersonCsvParser();
        var repository = new PersonRepository(loader, parser);
        var manager = new PersonManager(repository);

        var adults = manager.GetAllAdults().Take(2).ToList();
        Console.WriteLine($"### Erwachsene ({adults.Count}) ###");
        adults.ForEach(a => Console.WriteLine(a.Name));

        var children = manager.GetAllChildren().ToList();
        Console.WriteLine($"### Kinder ({children.Count}) ###");
        children.ForEach(c => Console.WriteLine(c.Name));
    }
}