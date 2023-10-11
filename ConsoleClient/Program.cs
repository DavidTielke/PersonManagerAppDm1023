using DavidTielke.PersonManagerApp.Data.DataStoring.Csv;
using DavidTielke.PersonManagerApp.Logic.PersonManagement;
using Ninject;

namespace DavidTielke.PersonManagerApp.UI.ConsoleClient;

internal class Program
{
    private static void Main(string[] args)
    {
        var kernel = new StandardKernel();

        kernel.Bind<IPersonManager>().To<PersonManager>();
        kernel.Bind<IPersonRepository>().To<PersonRepository>();
        kernel.Bind<IPersonParser>().To<PersonCsvParser>();
        kernel.Bind<IFileLoader>().To<FileLoader>();

        var manager = kernel.Get<IPersonManager>();

        var adults = manager.GetAllAdults().Take(2).ToList();
        Console.WriteLine($"### Erwachsene ({adults.Count}) ###");
        adults.ForEach(a => Console.WriteLine(a.Name));

        var children = manager.GetAllChildren().ToList();
        Console.WriteLine($"### Kinder ({children.Count}) ###");
        children.ForEach(c => Console.WriteLine(c.Name));
    }
}