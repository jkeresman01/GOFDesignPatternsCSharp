namespace Singelton.Problem;

public class AppSettings
{
    private Dictionary<string, object> _settings;

    public AppSettings()
    {
        _settings = new Dictionary<string, object>();
    }
    
    public object Get(string key)
    {
        if (!_settings.TryGetValue(key, out var appSetting))
        {
            throw new KeyNotFoundException();
        }
        
        return appSetting;
    }

    public void Set(string key, object value)
    {
        _settings[key] = value;
    }
}