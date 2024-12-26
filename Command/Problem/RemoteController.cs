namespace Command;

public class RemoteController
{
    public Light Light { get; private set; }

    public RemoteController(Light light)
    {
        Light = light;
    }
    public void PressButton(bool turnOn)
    {
        if (turnOn)
        {
            Light.TurnOn();
        }
        else
        {
            Light.TurnOff();
        }
    }
}