using SkiaSharp;

namespace ImageResize.Core
{
    public enum ImageDimensionType
    {
        Width = 0,
        Height = 1
    }

    public class ImageEntity
    {
        #region Fields
        private static uint _id = 0;
        private string _sourceFileName;
        private string _targetFolderPath;
        private string _targetFileName;
        private float _width;
        private float _height;
        private float _aspectRatio;
        private float _resizedWidth;
        private float _resizedHeight;
        private ImageDimensionType _dimensionType;
        #endregion

        #region Properties
        public string SourceFileName { get => _sourceFileName; private set => _sourceFileName = value; }
        public string TargetFolderPath { get => _targetFolderPath; private set => _targetFolderPath = value; }
        public float Width { get => _width; private set => _width = value; }
        public float Height { get => _height; private set => _height = value; }
        public float AspectRatio { get => _aspectRatio; private set => _aspectRatio = value; }
        public float ResizedWidth { get => _resizedWidth; private set => _resizedWidth = value; }
        public float ResizedHeight { get => _resizedHeight; private set => _resizedHeight = value; }
        public string TargetFileName { get => _targetFileName; set => _targetFileName = value; }
        #endregion

        #region Constructor
        public ImageEntity(string sourceFileName, string targetFolderPath, float dimension, ImageDimensionType imageDimensionType)
        {
            SourceFileName = sourceFileName;
            TargetFolderPath = targetFolderPath;
            _dimensionType = imageDimensionType;
            _id++;
            TargetFileName = GenerateTargetFileName();
            if (imageDimensionType == ImageDimensionType.Width)
                Width = dimension;
            else
                Height = dimension;
        }
        #endregion

        #region Private Methods
        private string GenerateTargetFileName()
        {
            return Path.Combine(TargetFolderPath, $"{string.Format("{0:00}", DateTime.Now.Day)}{string.Format("{0:00}", DateTime.Now.Month)}{DateTime.Now.Year}{string.Format("{0:00}", DateTime.Now.Hour)}{string.Format("{0:00}", DateTime.Now.Minute)}_{string.Format("{0:0000}", _id)}.jpg");
        }

        private Stream GetOutputStream()
        {
            return File.Open(TargetFileName, FileMode.OpenOrCreate);
        }
        #endregion

        #region Public Methods
        public void Resize()
        {
            try
            {
                using (Stream imageFileStream = File.OpenRead(SourceFileName))
                {
                    using var skData = SKData.Create(imageFileStream);
                    using var codec = SKCodec.Create(skData);
                    float scalingFactor = _dimensionType == ImageDimensionType.Width ? Width / codec.Info.Width : Height / codec.Info.Height;
                    AspectRatio = codec.Info.Width / codec.Info.Height;
                    var supportedScale = codec.GetScaledDimensions(scalingFactor);

                    var nearest = new SKImageInfo(supportedScale.Width, supportedScale.Height);
                    ResizedWidth = nearest.Width;
                    ResizedHeight = nearest.Height;
                    using var destinationImage = SKBitmap.Decode(codec, nearest);
                    using var resizedImage = _dimensionType == ImageDimensionType.Width ? destinationImage.Resize(new SKImageInfo((int)Width, (int)(codec.Info.Height * scalingFactor)), SKFilterQuality.High) : destinationImage.Resize(new SKImageInfo((int)(codec.Info.Width * scalingFactor), (int)Height), SKFilterQuality.High);

                    var format = SKEncodedImageFormat.Jpeg;
                    using var outputImage = SKImage.FromBitmap(resizedImage);
                    using var data = outputImage.Encode(format, 100);
                    using var outputStream = GetOutputStream();
                    data.SaveTo(outputStream);

                    outputStream.Close();
                    imageFileStream.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}