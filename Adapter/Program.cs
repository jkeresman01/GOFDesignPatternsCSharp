//GOF Adapter pattern

using Adapter;

var video = new Video("Random video");
var videoEditor = new VideoEditor(video);

videoEditor.ApplyColor(new RainbowColor());