namespace Proxy.Solution.ThirdParty;

public class YouTubeVideo
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