using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace DavidTielke.PersonManagerApp.Data.DataStoring.Csv;

public class PersonRepository : IPersonRepository
{
    private readonly IFileLoader _loader;
    private readonly IPersonParser _parser;

    public PersonRepository(IFileLoader loader, IPersonParser parser)
    {
        _loader = loader;
        _parser = parser;
    }

    public IQueryable<Person> Query()
    {
        var data = _loader.LoadLines("data.csv");
        var persons = _parser.Parser(data);
        return persons.AsQueryable();
    }
}