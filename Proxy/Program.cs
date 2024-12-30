using Proxy.Solution;

var videos = new VideoList();
String[] videoIds = {"1234", "abcde", "javasc123"};

foreach (var videoId in videoIds)
{
    videos.AddVideo(new YouTubeVideoProxy(videoId));
}

videos.WatchVideo("1234");
