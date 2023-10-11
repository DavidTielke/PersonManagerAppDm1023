using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace DavidTielke.PersonManagerApp.Data.DataStoring.Csv;

public class PersonRepository
{
    private readonly FileLoader _loader;
    private readonly PersonCsvParser _parser;

    public PersonRepository()
    {
        _parser = new PersonCsvParser();
        _loader = new FileLoader();
    }

    public IQueryable<Person> Query()
    {
        var data = _loader.LoadLines("data.csv");
        var persons = _parser.Parser(data);
        return persons.AsQueryable();
    }
}