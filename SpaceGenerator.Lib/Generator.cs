using System.Drawing;

namespace SpaceGenerator.Lib
{
    public class Generator : IGenerator
    {
        private static Random _rnd = new Random();

        public Bitmap Generate(GeneratorConfig generatorConfig)
        {
            Size size = new Size(generatorConfig.BitmapImageSize.Width, generatorConfig.BitmapImageSize.Height);
            Bitmap bitmap = new Bitmap(size.Width, size.Height);
            for (int h = 0; h < size.Height; h++)
            {
                for (int w = 0; w < size.Width; w++)
                {
                    bitmap.SetPixel(w, h, GetSpaceColor(generatorConfig));
                }
            }

            for (int littleStarCount = 0; littleStarCount < generatorConfig.CountLittleStars; littleStarCount++)
            {
                CreateLittleStar(bitmap, generatorConfig);
            }

            for (int middleStarCount = 0; middleStarCount < generatorConfig.CountMiddleStars; middleStarCount++)
            {
                CreateMiddleStar(bitmap, generatorConfig);
            }

            for (int bigStarCount = 0; bigStarCount < generatorConfig.CountBigStars; bigStarCount++)
            {
                CreateBigStar(bitmap, generatorConfig);
            }

            return bitmap;
        }

        private static Color GetSpaceColor(GeneratorConfig generatorConfig)
        {
            int brith = generatorConfig.Brightness;
            return Color.FromArgb(255, brith, brith, brith);
        }

        private static void CreateLittleStar(Bitmap bitmap, GeneratorConfig generatorConfig)
        {
            int w = bitmap.Width;
            int h = bitmap.Height;

            int coordX = _rnd.Next(0, w);
            int coordY = _rnd.Next(0, h);

            Color starColor = Color.FromArgb(
                (int)(_rnd.Next(0, 255) * generatorConfig.KfRedLittleStar),
                (int)(_rnd.Next(0, 255) * generatorConfig.KfGreenLittleStar),
                (int)(_rnd.Next(0, 255) * generatorConfig.KfBlueLittleStar)
            );
            bitmap.SetPixel(coordX, coordY, starColor);
        }

        private static void CreateMiddleStar(Bitmap bitmap, GeneratorConfig generatorConfig)
        {
            int w = bitmap.Width;
            int h = bitmap.Height;

            int coordX = _rnd.Next(4, w - 4);
            int coordY = _rnd.Next(4, h - 4);

            double redKf = generatorConfig.KfRedMiddleStar;
            double greenKf = generatorConfig.KfGreenMiddleStar;
            double blueKf = generatorConfig.KfBlueMiddleStar;
            int brithSubLigth = _rnd.Next(100, 180);
            Color mainStarColor = Color.FromArgb(
                (int)(_rnd.Next(0, 255) * redKf),
                (int)(_rnd.Next(0, 255) * greenKf),
                (int)(_rnd.Next(0, 255) * blueKf));
            Color subLigthStarColor1 = Color.FromArgb(brithSubLigth,
                 (int)(_rnd.Next(0, 255) * redKf),
                 (int)(_rnd.Next(0, 255) * greenKf),
                 (int)(_rnd.Next(0, 255) * blueKf));
            Color subLigthStarColor2 = Color.FromArgb(brithSubLigth,
                 (int)(_rnd.Next(0, 255) * redKf),
                 (int)(_rnd.Next(0, 255) * greenKf),
                 (int)(_rnd.Next(0, 255) * blueKf));
            Color subLigthStarColor3 = Color.FromArgb(brithSubLigth,
                 (int)(_rnd.Next(0, 255) * redKf),
                 (int)(_rnd.Next(0, 255) * greenKf),
                 (int)(_rnd.Next(0, 255) * blueKf));
            Color subLigthStarColor4 = Color.FromArgb(brithSubLigth,
                 (int)(_rnd.Next(0, 255) * redKf),
                 (int)(_rnd.Next(0, 255) * greenKf),
                 (int)(_rnd.Next(0, 255) * blueKf));

            bitmap.SetPixel(coordX, coordY, mainStarColor);

            bitmap.SetPixel(coordX + 1, coordY, subLigthStarColor1);
            bitmap.SetPixel(coordX - 1, coordY, subLigthStarColor2);
            bitmap.SetPixel(coordX, coordY + 1, subLigthStarColor3);
            bitmap.SetPixel(coordX, coordY - 1, subLigthStarColor4);
        }

        private static void CreateBigStar(Bitmap bitmap, GeneratorConfig generatorConfig)
        {
            int w = bitmap.Width;
            int h = bitmap.Height;

            int coordX = _rnd.Next(6, w - 6);
            int coordY = _rnd.Next(6, h - 6);

            double redKf = generatorConfig.KfRedBigStar;
            double greenKf = generatorConfig.KfGreenBigStar;
            double blueKf = generatorConfig.KfBlueBigStar;
            int brithSubLigth = _rnd.Next(200, 230);

            // center light
            Color mainStarColor = Color.FromArgb(
                (int)(_rnd.Next(0, 255) * redKf),
                (int)(_rnd.Next(0, 255) * greenKf),
                (int)(_rnd.Next(0, 255) * blueKf));
            bitmap.SetPixel(coordX, coordY, mainStarColor);

            // cross light
            Color crossColor1 = Color.FromArgb(brithSubLigth,
                 (int)(_rnd.Next(0, 255) * redKf),
                 (int)(_rnd.Next(0, 255) * greenKf),
                 (int)(_rnd.Next(0, 255) * blueKf));
            Color crossColor2 = Color.FromArgb(brithSubLigth,
                 (int)(_rnd.Next(0, 255) * redKf),
                 (int)(_rnd.Next(0, 255) * greenKf),
                 (int)(_rnd.Next(0, 255) * blueKf));
            Color crossColor3 = Color.FromArgb(brithSubLigth,
                 (int)(_rnd.Next(0, 255) * redKf),
                 (int)(_rnd.Next(0, 255) * greenKf),
                 (int)(_rnd.Next(0, 255) * blueKf));
            Color crossColor4 = Color.FromArgb(brithSubLigth,
                 (int)(_rnd.Next(0, 255) * redKf),
                 (int)(_rnd.Next(0, 255) * greenKf),
                 (int)(_rnd.Next(0, 255) * blueKf));

            bitmap.SetPixel(coordX + 1, coordY, crossColor1);
            bitmap.SetPixel(coordX - 1, coordY, crossColor2);
            bitmap.SetPixel(coordX, coordY + 1, crossColor3);
            bitmap.SetPixel(coordX, coordY - 1, crossColor4);

            // diagonal light
            Color diagonalColor1 = Color.FromArgb((int)(brithSubLigth / 1.2),
                 (int)(_rnd.Next(0, 255) * redKf),
                 (int)(_rnd.Next(0, 255) * greenKf),
                 (int)(_rnd.Next(0, 255) * blueKf));
            Color diagonalColor2 = Color.FromArgb((int)(brithSubLigth / 1.2),
                 (int)(_rnd.Next(0, 255) * redKf),
                 (int)(_rnd.Next(0, 255) * greenKf),
                 (int)(_rnd.Next(0, 255) * blueKf));
            Color diagonalColor3 = Color.FromArgb((int)(brithSubLigth / 1.2),
                 (int)(_rnd.Next(0, 255) * redKf),
                 (int)(_rnd.Next(0, 255) * greenKf),
                 (int)(_rnd.Next(0, 255) * blueKf));
            Color diagonalColor4 = Color.FromArgb((int)(brithSubLigth / 1.2),
                 (int)(_rnd.Next(0, 255) * redKf),
                 (int)(_rnd.Next(0, 255) * greenKf),
                 (int)(_rnd.Next(0, 255) * blueKf));

            bitmap.SetPixel(coordX + 1, coordY + 1, diagonalColor1);
            bitmap.SetPixel(coordX - 1, coordY - 1, diagonalColor2);
            bitmap.SetPixel(coordX - 1, coordY + 1, diagonalColor3);
            bitmap.SetPixel(coordX + 1, coordY - 1, diagonalColor4);

            // outer light
            Color outerColor1 = Color.FromArgb((int)(brithSubLigth / 2),
                 (int)(_rnd.Next(0, 255) * redKf),
                 (int)(_rnd.Next(0, 255) * greenKf),
                 (int)(_rnd.Next(0, 255) * blueKf));
            Color outerColor2 = Color.FromArgb((int)(brithSubLigth / 2),
                 (int)(_rnd.Next(0, 255) * redKf),
                 (int)(_rnd.Next(0, 255) * greenKf),
                 (int)(_rnd.Next(0, 255) * blueKf));
            Color outerColor3 = Color.FromArgb((int)(brithSubLigth / 2),
                 (int)(_rnd.Next(0, 255) * redKf),
                 (int)(_rnd.Next(0, 255) * greenKf),
                 (int)(_rnd.Next(0, 255) * blueKf));
            Color outerColor4 = Color.FromArgb((int)(brithSubLigth / 2),
                 (int)(_rnd.Next(0, 255) * redKf),
                 (int)(_rnd.Next(0, 255) * greenKf),
                 (int)(_rnd.Next(0, 255) * blueKf));

            bitmap.SetPixel(coordX + 2, coordY, outerColor1);
            bitmap.SetPixel(coordX - 2, coordY, outerColor2);
            bitmap.SetPixel(coordX, coordY + 2, outerColor3);
            bitmap.SetPixel(coordX, coordY - 2, outerColor4);
        }
    }
}