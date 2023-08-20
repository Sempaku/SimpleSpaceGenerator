using System.Drawing;

namespace SpaceGenerator.Lib
{
    public class GeneratorConfig
    {
        public Size BitmapImageSize { get; set; }
        public int Brightness { get; set; }

        public int CountLittleStars { get; set; }
        public double KfRedLittleStar { get; set; }
        public double KfGreenLittleStar { get; set; }
        public double KfBlueLittleStar { get; set; }

        public int CountMiddleStars { get; set; }
        public double KfRedMiddleStar { get; set; }
        public double KfGreenMiddleStar { get; set; }
        public double KfBlueMiddleStar { get; set; }

        public int CountBigStars { get; set; }
        public double KfRedBigStar { get; set; }
        public double KfGreenBigStar { get; set; }
        public double KfBlueBigStar { get; set; }
    }
}