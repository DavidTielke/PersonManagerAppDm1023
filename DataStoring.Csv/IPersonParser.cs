using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace DavidTielke.PersonManagerApp.Data.DataStoring.Csv;

public interface IPersonParser
{
    IEnumerable<Person> Parser(string[] data);
}