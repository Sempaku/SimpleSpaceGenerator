using SpaceGenerator.Lib;
using System.Drawing.Imaging;

namespace SpaceGenerator.Gui
{
    public partial class Form1 : Form
    {
        private Dictionary<StarTag, Action<double>> trackBarEventHandlers;

        private Size _spaceImageSize = new Size(500, 500);
        private int _brightness;

        private int _countLittleStars;
        private double _kfRedLittleStar;
        private double _kfGreenLittleStar;
        private double _kfBlueLittleStar;

        private int _countMiddleStars;
        private double _kfRedMiddleStar;
        private double _kfGreenMiddleStar;
        private double _kfBlueMiddleStar;

        private int _countBigStars;
        private double _kfRedBigStar;
        private double _kfGreenBigStar;
        private double _kfBlueBigStar;

        private int _kfDivForMaximumInNumUpDownCountStars = 200;

        private IGenerator _generator;
        public Bitmap spaceImage { get; set; }

        public Form1()
        {
            InitializeComponent();
            InitTrackBarEventHandlers();
            InitializeUIValues();
            _generator = new Generator();
        }

        private void InitializeUIValues()
        {
            // remove arrows in numericUpDown
            numericUpDown_imageSizeWidth.Controls.RemoveAt(0);
            numericUpDown_imageSizeHeight.Controls.RemoveAt(0);

            lb_trackBarBrightnessValue.Text = "Value: " + trackBar_brightness.Value.ToString();
            _brightness = trackBar_brightness.Value;

            _countLittleStars = (int)numericUpDown_countLittleStars.Value;
            _countMiddleStars = (int)numericUpDown_countMiddleStars.Value;
            _countBigStars = (int)numericUpDown_countBigStars.Value;

            SetMaximumInNumUpDownCountStars(_kfDivForMaximumInNumUpDownCountStars);

            _kfRedLittleStar = 1.0;
            _kfGreenLittleStar = 1.0;
            _kfBlueLittleStar = 1.0;
            _kfRedMiddleStar = 1.0;
            _kfGreenMiddleStar = 1.0;
            _kfBlueMiddleStar = 1.0;
            _kfRedBigStar = 1.0;
            _kfGreenBigStar = 1.0;
            _kfBlueBigStar = 1.0;
        }

        private void InitTrackBarEventHandlers()
        {
            trackBarEventHandlers = new Dictionary<StarTag, Action<double>>
            {
                { StarTag.KF_RED_LITTLE_STAR, UpdateKfRedLittleStar },
                { StarTag.KF_GREEN_LITTLE_STAR, UpdateKfGreenLittleStar },
                { StarTag.KF_BLUE_LITTLE_STAR, UpdateKfBlueLittleStar },
                { StarTag.KF_RED_MIDDLE_STAR, UpdateKfRedMiddleStar },
                { StarTag.KF_GREEN_MIDDLE_STAR, UpdateKfGreenMiddleStar },
                { StarTag.KF_BLUE_MIDDLE_STAR, UpdateKfBlueMiddleStar },
                { StarTag.KF_RED_BIG_STAR, UpdateKfRedBigStar },
                { StarTag.KF_GREEN_BIG_STAR, UpdateKfGreenBigStar },
                { StarTag.KF_BLUE_BIG_STAR, UpdateKfBlueBigStar },
            };
        }

        private void trackBar_kfStarValue_ValueChanged(object sender, EventArgs e)
        {
            TrackBar trackBar = (TrackBar)sender;
            string? tagStr = trackBar.Tag.ToString();
            if (string.IsNullOrWhiteSpace(tagStr))
                throw new ArgumentNullException("TrackBar tag is null!");

            StarTag tag = (StarTag)Enum.Parse(typeof(StarTag), tagStr);
            double selectedValue = trackBar.Value / 10.0;

            if (trackBarEventHandlers.TryGetValue(tag, out var handler))
            {
                handler(selectedValue);
            }
        }

        #region StarValue Update handlesr

        private void UpdateKfRedLittleStar(double value)
        {
            lb_kfRedLittleStarValue.Text = value.ToString();
            _kfRedLittleStar = value;
        }

        private void UpdateKfGreenLittleStar(double value)
        {
            lb_kfGreenLittleStarValue.Text = value.ToString();
            _kfGreenLittleStar = value;
        }

        private void UpdateKfBlueLittleStar(double value)
        {
            lb_kfBlueLittleStarValue.Text = value.ToString();
            _kfBlueLittleStar = value;
        }

        private void UpdateKfRedMiddleStar(double value)
        {
            lb_kfRedMiddleStarValue.Text = value.ToString();
            _kfRedMiddleStar = value;
        }

        private void UpdateKfGreenMiddleStar(double value)
        {
            lb_kfGreenMiddleStarValue.Text = value.ToString();
            _kfGreenMiddleStar = value;
        }

        private void UpdateKfBlueMiddleStar(double value)
        {
            lb_kfBlueMiddleStarValue.Text = value.ToString();
            _kfBlueMiddleStar = value;
        }

        private void UpdateKfRedBigStar(double value)
        {
            lb_kfRedBigStarValue.Text = value.ToString();
            _kfRedBigStar = value;
        }

        private void UpdateKfGreenBigStar(double value)
        {
            lb_kfGreenBigStarValue.Text = value.ToString();
            _kfGreenBigStar = value;
        }

        private void UpdateKfBlueBigStar(double value)
        {
            lb_kfBlueBigStarValue.Text = value.ToString();
            _kfBlueBigStar = value;
        }

        #endregion StarValue Update handlesr

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            spaceImage = _generator.Generate(new GeneratorConfig
            {
                BitmapImageSize = _spaceImageSize,
                Brightness = _brightness,
                CountLittleStars = _countLittleStars,
                KfRedLittleStar = _kfRedLittleStar,
                KfGreenLittleStar = _kfGreenLittleStar,
                KfBlueLittleStar = _kfBlueLittleStar,
                CountMiddleStars = _countMiddleStars,
                KfRedMiddleStar = _kfRedMiddleStar,
                KfGreenMiddleStar = _kfGreenMiddleStar,
                KfBlueMiddleStar = _kfBlueMiddleStar,
                CountBigStars = _countBigStars,
                KfRedBigStar = _kfRedBigStar,
                KfGreenBigStar = _kfGreenBigStar,
                KfBlueBigStar = _kfBlueBigStar,
            });

            SetPreviewPicture();
        }

        private void SetPreviewPicture()
        {
            var resizePicture = new Bitmap(pb_SpacePicture.Width, pb_SpacePicture.Height);
            resizePicture = spaceImage;
            pb_SpacePicture.Image = resizePicture;
        }

        private void numericUpDown_countStars_ValueChanged(object sender, EventArgs e)
        {
            decimal selectedValue = ((NumericUpDown)sender).Value;
            if (((NumericUpDown)sender).Tag == "COUNT_LITTLE_STARS")
            {
                _countLittleStars = (int)selectedValue;
            }
            else if (((NumericUpDown)sender).Tag == "COUNT_MIDDLE_STARS")
            {
                _countMiddleStars = (int)selectedValue;
            }
            else if (((NumericUpDown)sender).Tag == "COUNT_BIG_STARS")
            {
                _countBigStars = (int)selectedValue;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG | *.png | JPEG | *.jpeg | BMP | *.bmp";
            if (Environment.OSVersion.Version >= new Version(6, 1))
                saveFileDialog1.Filter += "| WEBP | *.webp";

            if (spaceImage == null)
            {
                MessageBox.Show("Space image is null!");
                return;
            }

            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(saveFileDialog1.FileName))
            {
                if (Path.GetExtension(saveFileDialog1.FileName) == ".png")
                    spaceImage.Save(saveFileDialog1.FileName, ImageFormat.Png);
                else if (Path.GetExtension(saveFileDialog1.FileName) == ".jpeg")
                    spaceImage.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                else if (Path.GetExtension(saveFileDialog1.FileName) == ".bmp")
                    spaceImage.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
                else if (Path.GetExtension(saveFileDialog1.FileName) == ".webp")
                    spaceImage.Save(saveFileDialog1.FileName, ImageFormat.Webp);
                else
                    spaceImage.Save(saveFileDialog1.FileName);
                MessageBox.Show($"Image saved : {saveFileDialog1.FileName}");
            }
        }

        private void randomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            numericUpDown_countLittleStars.Value = rnd.Next(0, (_spaceImageSize.Height * _spaceImageSize.Width) / 201);
            numericUpDown_countMiddleStars.Value = rnd.Next(0, (_spaceImageSize.Height * _spaceImageSize.Width) / 201);
            numericUpDown_countBigStars.Value = rnd.Next(0, (_spaceImageSize.Height * _spaceImageSize.Width) / 201);

            trackBar_kfRedLittleStarValue.Value = (int)(rnd.Next(0, 10));
            trackBar_kfRedMiddleStarValue.Value = (int)(rnd.Next(0, 10));
            trackBar_kfRedBigStarValue.Value = (int)(rnd.Next(0, 10));

            trackBar_kfGreenLittleStarValue.Value = (int)(rnd.Next(0, 10));
            trackBar_kfGreenMiddleStarValue.Value = (int)(rnd.Next(0, 10));
            trackBar_kfGreenBigStarValue.Value = (int)(rnd.Next(0, 10));

            trackBar_kfBlueLittleStarValue.Value = (int)(rnd.Next(0, 10));
            trackBar_kfBlueMiddleStarValue.Value = (int)(rnd.Next(0, 10));
            trackBar_kfBlueBigStarValue.Value = (int)(rnd.Next(0, 10));
        }

        private void trackBar_brightness_ValueChanged(object sender, EventArgs e)
        {
            _brightness = ((TrackBar)sender).Value;
            lb_trackBarBrightnessValue.Text = "Value: " + trackBar_brightness.Value.ToString();
        }

        private void numericUpDown_imageSize_ValueChanged(object sender, EventArgs e)
        {
            decimal selectedValue = ((NumericUpDown)sender).Value;
            if (((NumericUpDown)sender).Tag == "IMAGE_SIZE_WIDTH")
            {
                _spaceImageSize.Width = (int)selectedValue;
                SetMaximumInNumUpDownCountStars(_kfDivForMaximumInNumUpDownCountStars);
            }
            else if (((NumericUpDown)sender).Tag == "IMAGE_SIZE_HEIGHT")
            {
                _spaceImageSize.Height = (int)selectedValue;
                SetMaximumInNumUpDownCountStars(_kfDivForMaximumInNumUpDownCountStars);
            }
        }

        private void SetMaximumInNumUpDownCountStars(int kf)
        {
            numericUpDown_countLittleStars.Maximum = (_spaceImageSize.Height * _spaceImageSize.Width) / kf;
            numericUpDown_countMiddleStars.Maximum = (_spaceImageSize.Height * _spaceImageSize.Width) / kf;
            numericUpDown_countBigStars.Maximum = (_spaceImageSize.Height * _spaceImageSize.Width) / kf;
        }
    }
}