using ConfigurationManagement;
using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace DavidTielke.PersonManagerApp.Data.DataStoring.Csv;

public class PersonRepository : IPersonRepository
{
    private readonly IConfigurator _config;
    private readonly IFileLoader _loader;
    private readonly IPersonParser _parser;

    public PersonRepository(IFileLoader loader, IPersonParser parser, IConfigurator config)
    {
        _loader = loader;
        _parser = parser;
        _config = config;
    }

    public IQueryable<Person> Query()
    {
        var filePath = _config.Get<string>("FilePath");
        var data = _loader.LoadLines(filePath);
        var persons = _parser.Parser(data);
        return persons.AsQueryable();
    }
}