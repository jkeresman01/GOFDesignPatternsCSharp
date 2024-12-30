using Proxy.Solution.ThirdParty;

namespace Proxy.Solution;

public class VideoList
{
    private Dictionary<string, IVideo> _videos;
    
    public VideoList()
    {
        _videos = new Dictionary<string, IVideo>();
    }
        
    public void AddVideo(IVideo video) => _videos.Add(video.getVideoId(), video);
    
    public void WatchVideo(string videoId) => _videos.GetValueOrDefault(videoId)?.Render();
}