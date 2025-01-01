namespace Bridge;

public class AdvancedLGRemote : AdvancedRemote
{
    public override void TurnOn() => Console.WriteLine($"Turning on {GetType().Name}");
    
    public override void TurnOff() => Console.WriteLine($"Turning off {GetType().Name}");
    
    public override void VolumeUp() => Console.WriteLine($"Volume up {GetType().Name}");

    public override void VolumeDown() => Console.WriteLine($"Volume down {GetType().Name}");

    public override void SetChannel(int channel) => Console.WriteLine($"Setting channel {channel} for {GetType().Name}");
}