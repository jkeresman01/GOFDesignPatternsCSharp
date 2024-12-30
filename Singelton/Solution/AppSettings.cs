namespace Singelton.Solution;

public class AppSettings
{
    private static AppSettings _instance; 
   
    private Dictionary<string, string> _settings;

    private AppSettings()
    {
        _settings = new Dictionary<string, string>();
    }

    public static AppSettings GetInstance()
    {
        if (_instance == null)
        {
            _instance = new AppSettings();
        }
        
        return _instance;
    }
   
    public object Get(string key)
    {
        if (!_settings.TryGetValue(key, out var appSetting))
        {
            throw new KeyNotFoundException();
        }
        
        return appSetting;
    }

    public void Set(string key, string value)
    {
        _settings[key] = value;
    }
}