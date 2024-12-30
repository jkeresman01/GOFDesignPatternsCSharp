namespace Decorator.Solution;

public class EncryptionDecorator : DataDecorator
{
    public EncryptionDecorator(IData data) : base(data)
    {
    }
    
    public override void Save(string data)
    {
        var encrypted = Encrypt(data);
        _data.Save(encrypted);
    }

    public string Encrypt(string data) => "$dsdasd*****234hjj14$$";
}