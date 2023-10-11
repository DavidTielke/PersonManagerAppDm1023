using ConfigurationManagement;
using DavidTielke.PersonManagerApp.Logic.PersonManagement;

namespace DavidTielke.PersonManagerApp.UI.ConsoleClient;

internal class Application
{
    private readonly IConfigurator _config;
    private readonly IPersonManager _manager;

    public Application(IPersonManager manager, IConfigurator config)
    {
        _manager = manager;
        _config = config;
    }

    public void Run()
    {
        _config.Set("FilePath", "data.csv");

        var adults = _manager.GetAllAdults().Take(2).ToList();
        Console.WriteLine($"### Erwachsene ({adults.Count}) ###");
        adults.ForEach(a => Console.WriteLine(a.Name));

        var children = _manager.GetAllChildren().ToList();
        Console.WriteLine($"### Kinder ({children.Count}) ###");
        children.ForEach(c => Console.WriteLine(c.Name));
    }
}