using DavidTielke.PersonManagerApp.Logic.PersonManagement;

namespace DavidTielke.PersonManagerApp.UI.ConsoleClient;

internal class Application
{
    private readonly IPersonManager _manager;

    public Application(IPersonManager manager)
    {
        _manager = manager;
    }

    public void Run()
    {
        var adults = _manager.GetAllAdults().Take(2).ToList();
        Console.WriteLine($"### Erwachsene ({adults.Count}) ###");
        adults.ForEach(a => Console.WriteLine(a.Name));

        var children = _manager.GetAllChildren().ToList();
        Console.WriteLine($"### Kinder ({children.Count}) ###");
        children.ForEach(c => Console.WriteLine(c.Name));
    }
}