namespace Strategy.Solution;

public class CompressorMp4 : ICompressor
{
    public void Compress()
    {
        Console.WriteLine("Compressing video using: MP4");
    }
}