namespace SpaceGenerator.Gui
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mainToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            rANDOMToolStripMenuItem = new ToolStripMenuItem();
            pb_SpacePicture = new PictureBox();
            btn_Generate = new Button();
            groupBox_StaceBackground = new GroupBox();
            lb_trackBarBrightnessValue = new Label();
            trackBar_brightness = new TrackBar();
            label1 = new Label();
            groupBox_littleStars = new GroupBox();
            lb_kfBlueLittleStarValue = new Label();
            lb_kfGreenLittleStarValue = new Label();
            trackBar_kfBlueLittleStarValue = new TrackBar();
            trackBar_kfGreenLittleStarValue = new TrackBar();
            lb_kfRedLittleStarValue = new Label();
            trackBar_kfRedLittleStarValue = new TrackBar();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            numericUpDown_countLittleStars = new NumericUpDown();
            label2 = new Label();
            groupBox_middleStars = new GroupBox();
            lb_kfBlueMiddleStarValue = new Label();
            lb_kfGreenMiddleStarValue = new Label();
            trackBar_kfBlueMiddleStarValue = new TrackBar();
            trackBar_kfGreenMiddleStarValue = new TrackBar();
            lb_kfRedMiddleStarValue = new Label();
            trackBar_kfRedMiddleStarValue = new TrackBar();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label3 = new Label();
            numericUpDown_countMiddleStars = new NumericUpDown();
            saveFileDialog1 = new SaveFileDialog();
            groupBox_bigStars = new GroupBox();
            lb_kfBlueBigStarValue = new Label();
            lb_kfGreenBigStarValue = new Label();
            trackBar_kfBlueBigStarValue = new TrackBar();
            trackBar_kfGreenBigStarValue = new TrackBar();
            lb_kfRedBigStarValue = new Label();
            trackBar_kfRedBigStarValue = new TrackBar();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            numericUpDown_countBigStars = new NumericUpDown();
            groupBox_imageSize = new GroupBox();
            label8 = new Label();
            numericUpDown_imageSizeHeight = new NumericUpDown();
            numericUpDown_imageSizeWidth = new NumericUpDown();
            label7 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_SpacePicture).BeginInit();
            groupBox_StaceBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_brightness).BeginInit();
            groupBox_littleStars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_kfBlueLittleStarValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_kfGreenLittleStarValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_kfRedLittleStarValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_countLittleStars).BeginInit();
            groupBox_middleStars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_kfBlueMiddleStarValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_kfGreenMiddleStarValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_kfRedMiddleStarValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_countMiddleStars).BeginInit();
            groupBox_bigStars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_kfBlueBigStarValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_kfGreenBigStarValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_kfRedBigStarValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_countBigStars).BeginInit();
            groupBox_imageSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_imageSizeHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_imageSizeWidth).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mainToolStripMenuItem, rANDOMToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1295, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip";
            // 
            // mainToolStripMenuItem
            // 
            mainToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem });
            mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            mainToolStripMenuItem.Size = new Size(46, 20);
            mainToolStripMenuItem.Text = "Main";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(98, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // rANDOMToolStripMenuItem
            // 
            rANDOMToolStripMenuItem.Name = "rANDOMToolStripMenuItem";
            rANDOMToolStripMenuItem.Size = new Size(71, 20);
            rANDOMToolStripMenuItem.Text = "RANDOM";
            rANDOMToolStripMenuItem.Click += randomToolStripMenuItem_Click;
            // 
            // pb_SpacePicture
            // 
            pb_SpacePicture.Location = new Point(12, 27);
            pb_SpacePicture.Name = "pb_SpacePicture";
            pb_SpacePicture.Size = new Size(500, 500);
            pb_SpacePicture.TabIndex = 1;
            pb_SpacePicture.TabStop = false;
            // 
            // btn_Generate
            // 
            btn_Generate.AutoSize = true;
            btn_Generate.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Generate.Location = new Point(518, 452);
            btn_Generate.Name = "btn_Generate";
            btn_Generate.Size = new Size(759, 75);
            btn_Generate.TabIndex = 2;
            btn_Generate.Text = "Generate";
            btn_Generate.UseVisualStyleBackColor = true;
            btn_Generate.Click += btn_Generate_Click;
            // 
            // groupBox_StaceBackground
            // 
            groupBox_StaceBackground.AutoSize = true;
            groupBox_StaceBackground.Controls.Add(lb_trackBarBrightnessValue);
            groupBox_StaceBackground.Controls.Add(trackBar_brightness);
            groupBox_StaceBackground.Controls.Add(label1);
            groupBox_StaceBackground.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox_StaceBackground.Location = new Point(899, 27);
            groupBox_StaceBackground.Name = "groupBox_StaceBackground";
            groupBox_StaceBackground.Size = new Size(378, 85);
            groupBox_StaceBackground.TabIndex = 3;
            groupBox_StaceBackground.TabStop = false;
            groupBox_StaceBackground.Text = "Space background";
            // 
            // lb_trackBarBrightnessValue
            // 
            lb_trackBarBrightnessValue.AutoSize = true;
            lb_trackBarBrightnessValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_trackBarBrightnessValue.Location = new Point(6, 47);
            lb_trackBarBrightnessValue.Name = "lb_trackBarBrightnessValue";
            lb_trackBarBrightnessValue.Size = new Size(38, 15);
            lb_trackBarBrightnessValue.TabIndex = 2;
            lb_trackBarBrightnessValue.Text = "Value:";
            // 
            // trackBar_brightness
            // 
            trackBar_brightness.Dock = DockStyle.Fill;
            trackBar_brightness.Location = new Point(108, 23);
            trackBar_brightness.Maximum = 255;
            trackBar_brightness.Name = "trackBar_brightness";
            trackBar_brightness.Size = new Size(267, 59);
            trackBar_brightness.TabIndex = 1;
            trackBar_brightness.TickStyle = TickStyle.None;
            trackBar_brightness.Value = 33;
            trackBar_brightness.ValueChanged += trackBar_brightness_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 23);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Brightness [0-255]:";
            // 
            // groupBox_littleStars
            // 
            groupBox_littleStars.AutoSize = true;
            groupBox_littleStars.Controls.Add(lb_kfBlueLittleStarValue);
            groupBox_littleStars.Controls.Add(lb_kfGreenLittleStarValue);
            groupBox_littleStars.Controls.Add(trackBar_kfBlueLittleStarValue);
            groupBox_littleStars.Controls.Add(trackBar_kfGreenLittleStarValue);
            groupBox_littleStars.Controls.Add(lb_kfRedLittleStarValue);
            groupBox_littleStars.Controls.Add(trackBar_kfRedLittleStarValue);
            groupBox_littleStars.Controls.Add(label6);
            groupBox_littleStars.Controls.Add(label5);
            groupBox_littleStars.Controls.Add(label4);
            groupBox_littleStars.Controls.Add(numericUpDown_countLittleStars);
            groupBox_littleStars.Controls.Add(label2);
            groupBox_littleStars.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox_littleStars.Location = new Point(518, 27);
            groupBox_littleStars.Name = "groupBox_littleStars";
            groupBox_littleStars.Size = new Size(375, 177);
            groupBox_littleStars.TabIndex = 4;
            groupBox_littleStars.TabStop = false;
            groupBox_littleStars.Text = "Little stars:";
            // 
            // lb_kfBlueLittleStarValue
            // 
            lb_kfBlueLittleStarValue.AutoSize = true;
            lb_kfBlueLittleStarValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_kfBlueLittleStarValue.Location = new Point(347, 111);
            lb_kfBlueLittleStarValue.Name = "lb_kfBlueLittleStarValue";
            lb_kfBlueLittleStarValue.Size = new Size(22, 15);
            lb_kfBlueLittleStarValue.TabIndex = 10;
            lb_kfBlueLittleStarValue.Text = "1.0";
            // 
            // lb_kfGreenLittleStarValue
            // 
            lb_kfGreenLittleStarValue.AutoSize = true;
            lb_kfGreenLittleStarValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_kfGreenLittleStarValue.Location = new Point(347, 85);
            lb_kfGreenLittleStarValue.Name = "lb_kfGreenLittleStarValue";
            lb_kfGreenLittleStarValue.Size = new Size(22, 15);
            lb_kfGreenLittleStarValue.TabIndex = 9;
            lb_kfGreenLittleStarValue.Text = "1.0";
            // 
            // trackBar_kfBlueLittleStarValue
            // 
            trackBar_kfBlueLittleStarValue.Location = new Point(110, 106);
            trackBar_kfBlueLittleStarValue.Name = "trackBar_kfBlueLittleStarValue";
            trackBar_kfBlueLittleStarValue.Size = new Size(231, 45);
            trackBar_kfBlueLittleStarValue.TabIndex = 8;
            trackBar_kfBlueLittleStarValue.Tag = "KF_BLUE_LITTLE_STAR";
            trackBar_kfBlueLittleStarValue.TickStyle = TickStyle.None;
            trackBar_kfBlueLittleStarValue.Value = 10;
            trackBar_kfBlueLittleStarValue.ValueChanged += trackBar_kfStarValue_ValueChanged;
            // 
            // trackBar_kfGreenLittleStarValue
            // 
            trackBar_kfGreenLittleStarValue.Location = new Point(110, 81);
            trackBar_kfGreenLittleStarValue.Name = "trackBar_kfGreenLittleStarValue";
            trackBar_kfGreenLittleStarValue.Size = new Size(231, 45);
            trackBar_kfGreenLittleStarValue.TabIndex = 7;
            trackBar_kfGreenLittleStarValue.Tag = "KF_GREEN_LITTLE_STAR";
            trackBar_kfGreenLittleStarValue.TickStyle = TickStyle.None;
            trackBar_kfGreenLittleStarValue.Value = 10;
            trackBar_kfGreenLittleStarValue.ValueChanged += trackBar_kfStarValue_ValueChanged;
            // 
            // lb_kfRedLittleStarValue
            // 
            lb_kfRedLittleStarValue.AutoSize = true;
            lb_kfRedLittleStarValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_kfRedLittleStarValue.Location = new Point(347, 57);
            lb_kfRedLittleStarValue.Name = "lb_kfRedLittleStarValue";
            lb_kfRedLittleStarValue.Size = new Size(22, 15);
            lb_kfRedLittleStarValue.TabIndex = 6;
            lb_kfRedLittleStarValue.Text = "1.0";
            // 
            // trackBar_kfRedLittleStarValue
            // 
            trackBar_kfRedLittleStarValue.Location = new Point(110, 55);
            trackBar_kfRedLittleStarValue.Name = "trackBar_kfRedLittleStarValue";
            trackBar_kfRedLittleStarValue.Size = new Size(231, 45);
            trackBar_kfRedLittleStarValue.TabIndex = 5;
            trackBar_kfRedLittleStarValue.Tag = "KF_RED_LITTLE_STAR";
            trackBar_kfRedLittleStarValue.TickStyle = TickStyle.None;
            trackBar_kfRedLittleStarValue.Value = 10;
            trackBar_kfRedLittleStarValue.ValueChanged += trackBar_kfStarValue_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 111);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 4;
            label6.Text = "KF Blue [0.0-1.0]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 85);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 3;
            label5.Text = "KF Green[0.0-1.0]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(7, 57);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 2;
            label4.Text = "KF Red [0.0-1.0]";
            // 
            // numericUpDown_countLittleStars
            // 
            numericUpDown_countLittleStars.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_countLittleStars.Location = new Point(117, 26);
            numericUpDown_countLittleStars.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown_countLittleStars.Name = "numericUpDown_countLittleStars";
            numericUpDown_countLittleStars.Size = new Size(62, 23);
            numericUpDown_countLittleStars.TabIndex = 1;
            numericUpDown_countLittleStars.Tag = "COUNT_LITTLE_STARS";
            numericUpDown_countLittleStars.ValueChanged += numericUpDown_countStars_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 33);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 0;
            label2.Text = "Count:";
            // 
            // groupBox_middleStars
            // 
            groupBox_middleStars.AutoSize = true;
            groupBox_middleStars.Controls.Add(lb_kfBlueMiddleStarValue);
            groupBox_middleStars.Controls.Add(lb_kfGreenMiddleStarValue);
            groupBox_middleStars.Controls.Add(trackBar_kfBlueMiddleStarValue);
            groupBox_middleStars.Controls.Add(trackBar_kfGreenMiddleStarValue);
            groupBox_middleStars.Controls.Add(lb_kfRedMiddleStarValue);
            groupBox_middleStars.Controls.Add(trackBar_kfRedMiddleStarValue);
            groupBox_middleStars.Controls.Add(label10);
            groupBox_middleStars.Controls.Add(label11);
            groupBox_middleStars.Controls.Add(label12);
            groupBox_middleStars.Controls.Add(label3);
            groupBox_middleStars.Controls.Add(numericUpDown_countMiddleStars);
            groupBox_middleStars.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox_middleStars.Location = new Point(518, 210);
            groupBox_middleStars.Name = "groupBox_middleStars";
            groupBox_middleStars.Size = new Size(375, 175);
            groupBox_middleStars.TabIndex = 5;
            groupBox_middleStars.TabStop = false;
            groupBox_middleStars.Text = "Middle stars";
            // 
            // lb_kfBlueMiddleStarValue
            // 
            lb_kfBlueMiddleStarValue.AutoSize = true;
            lb_kfBlueMiddleStarValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_kfBlueMiddleStarValue.Location = new Point(347, 109);
            lb_kfBlueMiddleStarValue.Name = "lb_kfBlueMiddleStarValue";
            lb_kfBlueMiddleStarValue.Size = new Size(22, 15);
            lb_kfBlueMiddleStarValue.TabIndex = 19;
            lb_kfBlueMiddleStarValue.Text = "1.0";
            // 
            // lb_kfGreenMiddleStarValue
            // 
            lb_kfGreenMiddleStarValue.AutoSize = true;
            lb_kfGreenMiddleStarValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_kfGreenMiddleStarValue.Location = new Point(347, 83);
            lb_kfGreenMiddleStarValue.Name = "lb_kfGreenMiddleStarValue";
            lb_kfGreenMiddleStarValue.Size = new Size(22, 15);
            lb_kfGreenMiddleStarValue.TabIndex = 18;
            lb_kfGreenMiddleStarValue.Text = "1.0";
            // 
            // trackBar_kfBlueMiddleStarValue
            // 
            trackBar_kfBlueMiddleStarValue.Location = new Point(110, 104);
            trackBar_kfBlueMiddleStarValue.Name = "trackBar_kfBlueMiddleStarValue";
            trackBar_kfBlueMiddleStarValue.Size = new Size(231, 45);
            trackBar_kfBlueMiddleStarValue.TabIndex = 17;
            trackBar_kfBlueMiddleStarValue.Tag = "KF_BLUE_MIDDLE_STAR";
            trackBar_kfBlueMiddleStarValue.TickStyle = TickStyle.None;
            trackBar_kfBlueMiddleStarValue.Value = 10;
            trackBar_kfBlueMiddleStarValue.ValueChanged += trackBar_kfStarValue_ValueChanged;
            // 
            // trackBar_kfGreenMiddleStarValue
            // 
            trackBar_kfGreenMiddleStarValue.Location = new Point(110, 79);
            trackBar_kfGreenMiddleStarValue.Name = "trackBar_kfGreenMiddleStarValue";
            trackBar_kfGreenMiddleStarValue.Size = new Size(231, 45);
            trackBar_kfGreenMiddleStarValue.TabIndex = 16;
            trackBar_kfGreenMiddleStarValue.Tag = "KF_GREEN_MIDDLE_STAR";
            trackBar_kfGreenMiddleStarValue.TickStyle = TickStyle.None;
            trackBar_kfGreenMiddleStarValue.Value = 10;
            trackBar_kfGreenMiddleStarValue.ValueChanged += trackBar_kfStarValue_ValueChanged;
            // 
            // lb_kfRedMiddleStarValue
            // 
            lb_kfRedMiddleStarValue.AutoSize = true;
            lb_kfRedMiddleStarValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_kfRedMiddleStarValue.Location = new Point(347, 55);
            lb_kfRedMiddleStarValue.Name = "lb_kfRedMiddleStarValue";
            lb_kfRedMiddleStarValue.Size = new Size(22, 15);
            lb_kfRedMiddleStarValue.TabIndex = 15;
            lb_kfRedMiddleStarValue.Text = "1.0";
            // 
            // trackBar_kfRedMiddleStarValue
            // 
            trackBar_kfRedMiddleStarValue.Location = new Point(110, 53);
            trackBar_kfRedMiddleStarValue.Name = "trackBar_kfRedMiddleStarValue";
            trackBar_kfRedMiddleStarValue.Size = new Size(231, 45);
            trackBar_kfRedMiddleStarValue.TabIndex = 14;
            trackBar_kfRedMiddleStarValue.Tag = "KF_RED_MIDDLE_STAR";
            trackBar_kfRedMiddleStarValue.TickStyle = TickStyle.None;
            trackBar_kfRedMiddleStarValue.Value = 10;
            trackBar_kfRedMiddleStarValue.ValueChanged += trackBar_kfStarValue_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(6, 109);
            label10.Name = "label10";
            label10.Size = new Size(92, 15);
            label10.TabIndex = 13;
            label10.Text = "KF Blue [0.0-1.0]";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(6, 83);
            label11.Name = "label11";
            label11.Size = new Size(97, 15);
            label11.TabIndex = 12;
            label11.Text = "KF Green[0.0-1.0]";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(7, 55);
            label12.Name = "label12";
            label12.Size = new Size(89, 15);
            label12.TabIndex = 11;
            label12.Text = "KF Red [0.0-1.0]";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(7, 26);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 1;
            label3.Text = "Count:";
            // 
            // numericUpDown_countMiddleStars
            // 
            numericUpDown_countMiddleStars.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_countMiddleStars.Location = new Point(117, 24);
            numericUpDown_countMiddleStars.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown_countMiddleStars.Name = "numericUpDown_countMiddleStars";
            numericUpDown_countMiddleStars.Size = new Size(62, 23);
            numericUpDown_countMiddleStars.TabIndex = 0;
            numericUpDown_countMiddleStars.Tag = "COUNT_MIDDLE_STARS";
            numericUpDown_countMiddleStars.ValueChanged += numericUpDown_countStars_ValueChanged;
            // 
            // groupBox_bigStars
            // 
            groupBox_bigStars.AutoSize = true;
            groupBox_bigStars.Controls.Add(lb_kfBlueBigStarValue);
            groupBox_bigStars.Controls.Add(lb_kfGreenBigStarValue);
            groupBox_bigStars.Controls.Add(trackBar_kfBlueBigStarValue);
            groupBox_bigStars.Controls.Add(trackBar_kfGreenBigStarValue);
            groupBox_bigStars.Controls.Add(lb_kfRedBigStarValue);
            groupBox_bigStars.Controls.Add(trackBar_kfRedBigStarValue);
            groupBox_bigStars.Controls.Add(label13);
            groupBox_bigStars.Controls.Add(label14);
            groupBox_bigStars.Controls.Add(label15);
            groupBox_bigStars.Controls.Add(label16);
            groupBox_bigStars.Controls.Add(numericUpDown_countBigStars);
            groupBox_bigStars.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox_bigStars.Location = new Point(899, 210);
            groupBox_bigStars.Name = "groupBox_bigStars";
            groupBox_bigStars.Size = new Size(378, 175);
            groupBox_bigStars.TabIndex = 20;
            groupBox_bigStars.TabStop = false;
            groupBox_bigStars.Text = "Big stars";
            // 
            // lb_kfBlueBigStarValue
            // 
            lb_kfBlueBigStarValue.AutoSize = true;
            lb_kfBlueBigStarValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_kfBlueBigStarValue.Location = new Point(347, 109);
            lb_kfBlueBigStarValue.Name = "lb_kfBlueBigStarValue";
            lb_kfBlueBigStarValue.Size = new Size(22, 15);
            lb_kfBlueBigStarValue.TabIndex = 19;
            lb_kfBlueBigStarValue.Text = "1.0";
            // 
            // lb_kfGreenBigStarValue
            // 
            lb_kfGreenBigStarValue.AutoSize = true;
            lb_kfGreenBigStarValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_kfGreenBigStarValue.Location = new Point(347, 83);
            lb_kfGreenBigStarValue.Name = "lb_kfGreenBigStarValue";
            lb_kfGreenBigStarValue.Size = new Size(22, 15);
            lb_kfGreenBigStarValue.TabIndex = 18;
            lb_kfGreenBigStarValue.Text = "1.0";
            // 
            // trackBar_kfBlueBigStarValue
            // 
            trackBar_kfBlueBigStarValue.Location = new Point(110, 104);
            trackBar_kfBlueBigStarValue.Name = "trackBar_kfBlueBigStarValue";
            trackBar_kfBlueBigStarValue.Size = new Size(231, 45);
            trackBar_kfBlueBigStarValue.TabIndex = 17;
            trackBar_kfBlueBigStarValue.Tag = "KF_BLUE_BIG_STAR";
            trackBar_kfBlueBigStarValue.TickStyle = TickStyle.None;
            trackBar_kfBlueBigStarValue.Value = 10;
            trackBar_kfBlueBigStarValue.ValueChanged += trackBar_kfStarValue_ValueChanged;
            // 
            // trackBar_kfGreenBigStarValue
            // 
            trackBar_kfGreenBigStarValue.Location = new Point(110, 79);
            trackBar_kfGreenBigStarValue.Name = "trackBar_kfGreenBigStarValue";
            trackBar_kfGreenBigStarValue.Size = new Size(231, 45);
            trackBar_kfGreenBigStarValue.TabIndex = 16;
            trackBar_kfGreenBigStarValue.Tag = "KF_GREEN_BIG_STAR";
            trackBar_kfGreenBigStarValue.TickStyle = TickStyle.None;
            trackBar_kfGreenBigStarValue.Value = 10;
            trackBar_kfGreenBigStarValue.ValueChanged += trackBar_kfStarValue_ValueChanged;
            // 
            // lb_kfRedBigStarValue
            // 
            lb_kfRedBigStarValue.AutoSize = true;
            lb_kfRedBigStarValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_kfRedBigStarValue.Location = new Point(347, 55);
            lb_kfRedBigStarValue.Name = "lb_kfRedBigStarValue";
            lb_kfRedBigStarValue.Size = new Size(22, 15);
            lb_kfRedBigStarValue.TabIndex = 15;
            lb_kfRedBigStarValue.Text = "1.0";
            // 
            // trackBar_kfRedBigStarValue
            // 
            trackBar_kfRedBigStarValue.Location = new Point(110, 53);
            trackBar_kfRedBigStarValue.Name = "trackBar_kfRedBigStarValue";
            trackBar_kfRedBigStarValue.Size = new Size(231, 45);
            trackBar_kfRedBigStarValue.TabIndex = 14;
            trackBar_kfRedBigStarValue.Tag = "KF_RED_BIG_STAR";
            trackBar_kfRedBigStarValue.TickStyle = TickStyle.None;
            trackBar_kfRedBigStarValue.Value = 10;
            trackBar_kfRedBigStarValue.ValueChanged += trackBar_kfStarValue_ValueChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(6, 109);
            label13.Name = "label13";
            label13.Size = new Size(92, 15);
            label13.TabIndex = 13;
            label13.Text = "KF Blue [0.0-1.0]";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(6, 83);
            label14.Name = "label14";
            label14.Size = new Size(97, 15);
            label14.TabIndex = 12;
            label14.Text = "KF Green[0.0-1.0]";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(7, 55);
            label15.Name = "label15";
            label15.Size = new Size(89, 15);
            label15.TabIndex = 11;
            label15.Text = "KF Red [0.0-1.0]";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(7, 26);
            label16.Name = "label16";
            label16.Size = new Size(43, 15);
            label16.TabIndex = 1;
            label16.Text = "Count:";
            // 
            // numericUpDown_countBigStars
            // 
            numericUpDown_countBigStars.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_countBigStars.Location = new Point(117, 24);
            numericUpDown_countBigStars.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown_countBigStars.Name = "numericUpDown_countBigStars";
            numericUpDown_countBigStars.Size = new Size(62, 23);
            numericUpDown_countBigStars.TabIndex = 0;
            numericUpDown_countBigStars.Tag = "COUNT_BIG_STARS";
            numericUpDown_countBigStars.ValueChanged += numericUpDown_countStars_ValueChanged;
            // 
            // groupBox_imageSize
            // 
            groupBox_imageSize.AutoSize = true;
            groupBox_imageSize.Controls.Add(label8);
            groupBox_imageSize.Controls.Add(numericUpDown_imageSizeHeight);
            groupBox_imageSize.Controls.Add(numericUpDown_imageSizeWidth);
            groupBox_imageSize.Controls.Add(label7);
            groupBox_imageSize.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox_imageSize.Location = new Point(899, 115);
            groupBox_imageSize.Name = "groupBox_imageSize";
            groupBox_imageSize.Size = new Size(378, 89);
            groupBox_imageSize.TabIndex = 21;
            groupBox_imageSize.TabStop = false;
            groupBox_imageSize.Text = "Image Size";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(152, 44);
            label8.Name = "label8";
            label8.Size = new Size(13, 15);
            label8.TabIndex = 3;
            label8.Text = "x";
            // 
            // numericUpDown_imageSizeHeight
            // 
            numericUpDown_imageSizeHeight.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown_imageSizeHeight.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_imageSizeHeight.Location = new Point(170, 40);
            numericUpDown_imageSizeHeight.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDown_imageSizeHeight.Name = "numericUpDown_imageSizeHeight";
            numericUpDown_imageSizeHeight.Size = new Size(59, 23);
            numericUpDown_imageSizeHeight.TabIndex = 2;
            numericUpDown_imageSizeHeight.Tag = "IMAGE_SIZE_HEIGHT";
            numericUpDown_imageSizeHeight.Value = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown_imageSizeHeight.ValueChanged += numericUpDown_imageSize_ValueChanged;
            // 
            // numericUpDown_imageSizeWidth
            // 
            numericUpDown_imageSizeWidth.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown_imageSizeWidth.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_imageSizeWidth.Location = new Point(87, 40);
            numericUpDown_imageSizeWidth.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDown_imageSizeWidth.Name = "numericUpDown_imageSizeWidth";
            numericUpDown_imageSizeWidth.Size = new Size(59, 23);
            numericUpDown_imageSizeWidth.TabIndex = 1;
            numericUpDown_imageSizeWidth.Tag = "IMAGE_SIZE_WIDTH";
            numericUpDown_imageSizeWidth.Value = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown_imageSizeWidth.ValueChanged += numericUpDown_imageSize_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(7, 42);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 0;
            label7.Text = "Size[W;H]:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1295, 561);
            Controls.Add(groupBox_imageSize);
            Controls.Add(groupBox_bigStars);
            Controls.Add(groupBox_middleStars);
            Controls.Add(groupBox_littleStars);
            Controls.Add(groupBox_StaceBackground);
            Controls.Add(btn_Generate);
            Controls.Add(pb_SpacePicture);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Space Generator 0)))";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_SpacePicture).EndInit();
            groupBox_StaceBackground.ResumeLayout(false);
            groupBox_StaceBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_brightness).EndInit();
            groupBox_littleStars.ResumeLayout(false);
            groupBox_littleStars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_kfBlueLittleStarValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_kfGreenLittleStarValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_kfRedLittleStarValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_countLittleStars).EndInit();
            groupBox_middleStars.ResumeLayout(false);
            groupBox_middleStars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_kfBlueMiddleStarValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_kfGreenMiddleStarValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_kfRedMiddleStarValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_countMiddleStars).EndInit();
            groupBox_bigStars.ResumeLayout(false);
            groupBox_bigStars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar_kfBlueBigStarValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_kfGreenBigStarValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_kfRedBigStarValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_countBigStars).EndInit();
            groupBox_imageSize.ResumeLayout(false);
            groupBox_imageSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_imageSizeHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_imageSizeWidth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem rANDOMToolStripMenuItem;
        private PictureBox pb_SpacePicture;
        private Button btn_Generate;
        private GroupBox groupBox_StaceBackground;
        private Label label1;
        private GroupBox groupBox_littleStars;
        private GroupBox groupBox_middleStars;
        private TrackBar trackBar_brightness;
        private Label label2;
        private Label lb_trackBarBrightnessValue;
        private NumericUpDown numericUpDown_countLittleStars;
        private Label label4;
        private Label label3;
        private NumericUpDown numericUpDown_countMiddleStars;
        private Label label6;
        private Label label5;
        private Label lb_kfRedLittleStarValue;
        private TrackBar trackBar_kfRedLittleStarValue;
        private TrackBar trackBar_kfBlueLittleStarValue;
        private TrackBar trackBar_kfGreenLittleStarValue;
        private Label lb_kfBlueLittleStarValue;
        private Label lb_kfGreenLittleStarValue;
        private Label lb_kfBlueMiddleStarValue;
        private Label lb_kfGreenMiddleStarValue;
        private TrackBar trackBar_kfBlueMiddleStarValue;
        private TrackBar trackBar_kfGreenMiddleStarValue;
        private Label lb_kfRedMiddleStarValue;
        private TrackBar trackBar_kfRedMiddleStarValue;
        private Label label10;
        private Label label11;
        private Label label12;
        private SaveFileDialog saveFileDialog1;
        private GroupBox groupBox_bigStars;
        private Label lb_kfBlueBigStarValue;
        private Label lb_kfGreenBigStarValue;
        private TrackBar trackBar_kfBlueBigStarValue;
        private TrackBar trackBar_kfGreenBigStarValue;
        private Label lb_kfRedBigStarValue;
        private TrackBar trackBar_kfRedBigStarValue;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private NumericUpDown numericUpDown_countBigStars;
        private GroupBox groupBox_imageSize;
        private Label label7;
        private Label label8;
        private NumericUpDown numericUpDown_imageSizeHeight;
        private NumericUpDown numericUpDown_imageSizeWidth;
    }
}
