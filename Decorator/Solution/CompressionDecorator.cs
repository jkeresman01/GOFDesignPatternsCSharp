namespace Decorator.Solution;

public class CompressionDecorator : DataDecorator
{
    public CompressionDecorator(IData data) : base(data)
    {
    }
    
   public override void Save(string data)
   {
      Console.WriteLine("Compressing data");
      var comppresed = Compress(data);
      _data.Save(comppresed);
   }
   
   public string Compress(string data) => data.Substring(0, 9);
}