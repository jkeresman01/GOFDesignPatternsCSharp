namespace Decorator;

public class CompressedData : CloudData
{
   public CompressedData(string url) : base(url)
   {
   }

   public override void Save(string data)
   {
      var comppresed = Compress(data);
      base.Save(comppresed);
   }
   public string Compress(string data) => data.Substring(0, 9);
}