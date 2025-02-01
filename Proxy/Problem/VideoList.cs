namespace Proxy.Problem;

public class VideoList
{
    private IDictionary<string, IVideo> _videos = new Dictionary<string, IVideo>();
    
    public void AddVideo(IVideo video) => _videos.Add(video.getVideoId(), video);
    public void WatchVideo(string videoId) => _videos.GetValueOrDefault(videoId)?.Render();
}