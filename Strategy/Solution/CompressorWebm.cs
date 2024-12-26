namespace Strategy.Solution;

public class CompressorWebm : ICompressor
{
    public void Compress()
    {
        Console.WriteLine("Compressing video using: WEBM");
    }
}