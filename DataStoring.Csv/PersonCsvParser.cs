using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace DavidTielke.PersonManagerApp.Data.DataStoring.Csv;

public class PersonCsvParser : IPersonParser
{
    public IEnumerable<Person> Parser(string[] data)
    {
        var persons = data.Select(l => l.Split(","))
            .Select(p => new Person
            {
                Id = int.Parse(p[0]),
                Name = p[1],
                Age = int.Parse(p[2])
            }).AsEnumerable();
        return persons;
    }
}