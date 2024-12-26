namespace Strategy;

public class VideoStorage
{
    public Compressors Compressor { get; set; } 
    public OverlayType OverlayType { get; set; }

    public VideoStorage(Compressors compressor, OverlayType overlayType = OverlayType.None)
    {
        Compressor = compressor;
        OverlayType = overlayType;
    }

    public override string ToString() => $"{Compressor} - {OverlayType}";

    
    //Violates SOLID -> open closed principle
    public void Store(string filename)
    {
        if (Compressor == Compressors.MOV)
        {
            Console.WriteLine("Compressing using: MOV");
        }
        
        if (Compressor == Compressors.MP4)
        {
            Console.WriteLine("Compressing using: MP4");
        }
        
        if (Compressor == Compressors.WEBM)
        {
            Console.WriteLine("Compressing using: WEBM");
        }

        if (OverlayType == OverlayType.None)
        {
            Console.WriteLine("No overlay!");
        }

        if (OverlayType == OverlayType.Blur)
        {
            Console.WriteLine("Blur overlay!");
        }

        if (OverlayType == OverlayType.BlackAndWhite)
        {
            Console.WriteLine("Black and White overlay!");
        }

        Console.WriteLine($"Storing file: {filename}");
    }
}