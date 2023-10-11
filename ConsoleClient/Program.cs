using Mappings;
using Ninject;

namespace DavidTielke.PersonManagerApp.UI.ConsoleClient;

internal class Program
{
    private static void Main(string[] args)
    {
        var kernel = new KernelFactory().Create();
        var app = kernel.Get<Application>();
        app.Run();
    }
}