using Singelton.Solution;

var appSettings = AppSettings.GetInstance();
appSettings.Set("app_name", "Design patterns mastery");
appSettings.Set("app_author", "Josip Keresman");

var appName = appSettings.Get("app_name");
Console.WriteLine(appName);