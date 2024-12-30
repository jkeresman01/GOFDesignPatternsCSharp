using Proxy.Solution.ThirdParty;

namespace Proxy.Solution;

public class YouTubeVideoProxy : IVideo
{
    private string _videoId;
    private YouTubeVideo _youTubeVideo;

    public YouTubeVideoProxy(string videoId)
    {
        _videoId = videoId;
    }
    
    public void Render()
    {
        if (_youTubeVideo == null)
        {
            _youTubeVideo = new YouTubeVideo(_videoId);
        }
        
        _youTubeVideo.Render();
    }

    public string getVideoId() => _videoId;
}