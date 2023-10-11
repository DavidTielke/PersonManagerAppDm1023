using ConfigurationManagement;
using DavidTielke.PersonManagerApp.Data.DataStoring.Csv;
using DavidTielke.PersonManagerApp.Logic.PersonManagement;
using Ninject;

namespace Mappings;

public class KernelFactory
{
    public IKernel Create()
    {
        var kernel = new StandardKernel();

        kernel.Bind<IPersonManager>().To<PersonManager>();
        kernel.Bind<IPersonRepository>().To<PersonRepository>();
        kernel.Bind<IPersonParser>().To<PersonCsvParser>();
        kernel.Bind<IFileLoader>().To<FileLoader>();
        kernel.Bind<IConfigurator>().To<Configurator>().InSingletonScope();

        return kernel;
    }
}