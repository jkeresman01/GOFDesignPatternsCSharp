namespace Decorator;

public class EncryptedData : CloudData
{
    public EncryptedData(string url) : base(url)
    {
    }

    public override void Save(string data)
    {
        var encrypted = Encrypt(data);
        base.Save(encrypted);
    }

    public string Encrypt(string data) => "$dsdasd*****234hjj14$$";
}