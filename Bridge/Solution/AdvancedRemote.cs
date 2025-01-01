namespace Bridge.Solution;

public class AdvancedRemote(IDevice device) : RemoteControl(device)
{
    public void SetChannel(int channel) => _device.SetChannel(channel); 
}