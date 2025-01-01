namespace Bridge.Solution;

public class SonyDevice : IDevice
{
    public void TurnOn() => Console.WriteLine($"Turning on {GetType().Name}");

    public void TurnOff() => Console.WriteLine($"Turning off {GetType().Name}");

    public void SetChannel(int channel) => Console.WriteLine($"Setting channel {channel} for {GetType().Name}");
}