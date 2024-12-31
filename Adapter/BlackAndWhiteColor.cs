namespace Adapter;

public class BlackAndWhiteColor : IColor
{
    public void Apply(Video video) 
        => Console.WriteLine($"Applying Black and White color on video: {video}");
}