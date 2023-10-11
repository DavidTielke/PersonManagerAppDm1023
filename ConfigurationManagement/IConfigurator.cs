namespace ConfigurationManagement;

public interface IConfigurator
{
    void Set(string key, object value);
    T Get<T>(string key);
}