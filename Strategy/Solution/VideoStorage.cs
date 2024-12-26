namespace Strategy.Solution;

public class VideoStorage
{
    public ICompressor Compressor { get; set; }
    public IOverlay Overlay { get; set; }

    public VideoStorage(ICompressor compressor, IOverlay overlay)
    {
        Compressor = compressor;
        Overlay = overlay;
    }

    public void Store(string filename)
    {
        Compressor.Compress();
        Overlay.Apply();
        
        Console.WriteLine($"Storing video {filename}");
    }
}