using Adapter.ThirdParty;

namespace Adapter;

//Adapter class for third party rainbow
public class RainbowColor : IColor
{
    private Rainbow _rainbow;

    public RainbowColor()
    {
        _rainbow = new Rainbow();
        _rainbow.Setup();
    }
    
    public void Apply(Video video) => _rainbow.Update(video);
}