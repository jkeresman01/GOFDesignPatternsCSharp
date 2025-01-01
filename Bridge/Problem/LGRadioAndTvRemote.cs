namespace Bridge;

public class LGRadioAndTvRemote : RadioAndTvRemote
{
    public override void TurnOn() => Console.WriteLine($"Turning on {GetType().Name}");

    public override void TurnOff() => Console.WriteLine($"Turning off {GetType().Name}");
    
    public override void VolumeUp() => Console.WriteLine($"Volume up {GetType().Name}");
    
    public override void VolumeDown() => Console.WriteLine($"Volume down {GetType().Name}");

    public override void ControlTv() => Console.WriteLine($"Control tv {GetType().Name}");

    public override void ControlRadio() => Console.WriteLine($"Control tv {GetType().Name}");
}