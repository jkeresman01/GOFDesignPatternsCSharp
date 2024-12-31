namespace Adapter;

public class MidnightColor : IColor
{
    public void Apply(Video video) => Console.WriteLine($"Applying Midnight color on video: {video}");
}