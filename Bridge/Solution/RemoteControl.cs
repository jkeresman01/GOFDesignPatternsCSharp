namespace Bridge.Solution;

public class RemoteControl(IDevice device)
{
    protected IDevice _device = device;

    public void TurnOn() => _device.TurnOn();
    public void TurnOff() => _device.TurnOff();
}