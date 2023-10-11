using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace DavidTielke.PersonManagerApp.Data.DataStoring.Csv;

public interface IPersonRepository
{
    IQueryable<Person> Query();
}