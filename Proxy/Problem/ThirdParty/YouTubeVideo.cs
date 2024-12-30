namespace Proxy.Problem;

public class YouTubeVideo : IVideo
{
    private string _videoId;

    public YouTubeVideo(string videoId)
    {
        _videoId = videoId;
        Download();
    }
    
    private void Download() => Console.WriteLine($"Downloading video {_videoId} from YouTube API!");
    
    public void Render() => Console.WriteLine($"Rendering video {_videoId}");
    
    public string getVideoId() => _videoId;
}