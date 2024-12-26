// GOF Strategy pattern

using Strategy.Solution;

var movCompressor = new CompressorMov();
var overlayBlackAndWhite = new OverlayBlackAndWhite();

var videoStorage = new VideoStorage(movCompressor, overlayBlackAndWhite);
videoStorage.Store("/videos/some-movie");

Console.WriteLine();

videoStorage.Compressor = new CompressorMp4();
videoStorage.Overlay = new OverlayBlur();
videoStorage.Store("/videos/some-video");