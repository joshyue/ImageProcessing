namespace ImageProcessing_HW1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Image_Undo = new System.Windows.Forms.Button();
            this.Image_Save = new System.Windows.Forms.Button();
            this.Image_Load = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Color_Grayscale = new System.Windows.Forms.Button();
            this.Color_B = new System.Windows.Forms.Button();
            this.Color_G = new System.Windows.Forms.Button();
            this.Color_R = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Median_Filter = new System.Windows.Forms.Button();
            this.Mean_Filter = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Histogram_Equalization = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Thresholding = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Sobel_Edge_Combined = new System.Windows.Forms.Button();
            this.Sobel_Edge_Vertical = new System.Windows.Forms.Button();
            this.Sobel_Edge_Horizontal = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.Edge_Overlapping = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.Connected_Component = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.Image_Registration = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Image_Undo);
            this.groupBox1.Controls.Add(this.Image_Save);
            this.groupBox1.Controls.Add(this.Image_Load);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Load/Save/Undo";
            // 
            // Image_Undo
            // 
            this.Image_Undo.Location = new System.Drawing.Point(176, 18);
            this.Image_Undo.Name = "Image_Undo";
            this.Image_Undo.Size = new System.Drawing.Size(75, 31);
            this.Image_Undo.TabIndex = 2;
            this.Image_Undo.Text = "Undo";
            this.Image_Undo.UseVisualStyleBackColor = true;
            this.Image_Undo.Click += new System.EventHandler(this.Image_Undo_Click);
            // 
            // Image_Save
            // 
            this.Image_Save.Location = new System.Drawing.Point(97, 18);
            this.Image_Save.Name = "Image_Save";
            this.Image_Save.Size = new System.Drawing.Size(73, 31);
            this.Image_Save.TabIndex = 1;
            this.Image_Save.Text = "Save";
            this.Image_Save.UseVisualStyleBackColor = true;
            this.Image_Save.Click += new System.EventHandler(this.Image_Save_Click);
            // 
            // Image_Load
            // 
            this.Image_Load.Location = new System.Drawing.Point(18, 18);
            this.Image_Load.Name = "Image_Load";
            this.Image_Load.Size = new System.Drawing.Size(73, 31);
            this.Image_Load.TabIndex = 0;
            this.Image_Load.Text = "Load";
            this.Image_Load.UseVisualStyleBackColor = true;
            this.Image_Load.Click += new System.EventHandler(this.Image_Load_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Color_Grayscale);
            this.groupBox2.Controls.Add(this.Color_B);
            this.groupBox2.Controls.Add(this.Color_G);
            this.groupBox2.Controls.Add(this.Color_R);
            this.groupBox2.Location = new System.Drawing.Point(0, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extraction";
            // 
            // Color_Grayscale
            // 
            this.Color_Grayscale.Location = new System.Drawing.Point(143, 49);
            this.Color_Grayscale.Name = "Color_Grayscale";
            this.Color_Grayscale.Size = new System.Drawing.Size(73, 31);
            this.Color_Grayscale.TabIndex = 4;
            this.Color_Grayscale.Text = "Grayscale";
            this.Color_Grayscale.UseVisualStyleBackColor = true;
            this.Color_Grayscale.Click += new System.EventHandler(this.Color_Grayscale_Click);
            // 
            // Color_B
            // 
            this.Color_B.Location = new System.Drawing.Point(35, 49);
            this.Color_B.Name = "Color_B";
            this.Color_B.Size = new System.Drawing.Size(73, 31);
            this.Color_B.TabIndex = 3;
            this.Color_B.Text = "B";
            this.Color_B.UseVisualStyleBackColor = true;
            this.Color_B.Click += new System.EventHandler(this.Color_B_Click);
            // 
            // Color_G
            // 
            this.Color_G.Location = new System.Drawing.Point(143, 12);
            this.Color_G.Name = "Color_G";
            this.Color_G.Size = new System.Drawing.Size(73, 31);
            this.Color_G.TabIndex = 2;
            this.Color_G.Text = "G";
            this.Color_G.UseVisualStyleBackColor = true;
            this.Color_G.Click += new System.EventHandler(this.Color_G_Click);
            // 
            // Color_R
            // 
            this.Color_R.Location = new System.Drawing.Point(35, 12);
            this.Color_R.Name = "Color_R";
            this.Color_R.Size = new System.Drawing.Size(73, 31);
            this.Color_R.TabIndex = 1;
            this.Color_R.Text = "R";
            this.Color_R.UseVisualStyleBackColor = true;
            this.Color_R.Click += new System.EventHandler(this.Color_R_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Median_Filter);
            this.groupBox3.Controls.Add(this.Mean_Filter);
            this.groupBox3.Location = new System.Drawing.Point(0, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 51);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Smooth Filter";
            // 
            // Median_Filter
            // 
            this.Median_Filter.Location = new System.Drawing.Point(143, 18);
            this.Median_Filter.Name = "Median_Filter";
            this.Median_Filter.Size = new System.Drawing.Size(79, 31);
            this.Median_Filter.TabIndex = 5;
            this.Median_Filter.Text = "Median Filter";
            this.Median_Filter.UseVisualStyleBackColor = true;
            this.Median_Filter.Click += new System.EventHandler(this.Median_Filter_Click);
            // 
            // Mean_Filter
            // 
            this.Mean_Filter.Location = new System.Drawing.Point(35, 18);
            this.Mean_Filter.Name = "Mean_Filter";
            this.Mean_Filter.Size = new System.Drawing.Size(73, 31);
            this.Mean_Filter.TabIndex = 5;
            this.Mean_Filter.Text = "Mean Filter";
            this.Mean_Filter.UseVisualStyleBackColor = true;
            this.Mean_Filter.Click += new System.EventHandler(this.Mean_Filter_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Histogram_Equalization);
            this.groupBox4.Location = new System.Drawing.Point(0, 204);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(260, 58);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Equalization";
            // 
            // Histogram_Equalization
            // 
            this.Histogram_Equalization.Location = new System.Drawing.Point(35, 17);
            this.Histogram_Equalization.Name = "Histogram_Equalization";
            this.Histogram_Equalization.Size = new System.Drawing.Size(181, 31);
            this.Histogram_Equalization.TabIndex = 7;
            this.Histogram_Equalization.Text = "Histogram Equalization";
            this.Histogram_Equalization.UseVisualStyleBackColor = true;
            this.Histogram_Equalization.Click += new System.EventHandler(this.Histogram_Equalization_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.trackBar1);
            this.groupBox5.Controls.Add(this.Thresholding);
            this.groupBox5.Location = new System.Drawing.Point(3, 268);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(257, 66);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thresholding";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(31, 22);
            this.textBox1.TabIndex = 3;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(3, 15);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(111, 45);
            this.trackBar1.TabIndex = 7;
            // 
            // Thresholding
            // 
            this.Thresholding.Location = new System.Drawing.Point(143, 19);
            this.Thresholding.Name = "Thresholding";
            this.Thresholding.Size = new System.Drawing.Size(108, 31);
            this.Thresholding.TabIndex = 1;
            this.Thresholding.Text = "Start";
            this.Thresholding.UseVisualStyleBackColor = true;
            this.Thresholding.Click += new System.EventHandler(this.Thresholding_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Sobel_Edge_Combined);
            this.groupBox6.Controls.Add(this.Sobel_Edge_Vertical);
            this.groupBox6.Controls.Add(this.Sobel_Edge_Horizontal);
            this.groupBox6.Location = new System.Drawing.Point(0, 351);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(260, 61);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Sobel Edge Detection";
            // 
            // Sobel_Edge_Combined
            // 
            this.Sobel_Edge_Combined.Location = new System.Drawing.Point(176, 20);
            this.Sobel_Edge_Combined.Name = "Sobel_Edge_Combined";
            this.Sobel_Edge_Combined.Size = new System.Drawing.Size(75, 31);
            this.Sobel_Edge_Combined.TabIndex = 4;
            this.Sobel_Edge_Combined.Text = "Combined";
            this.Sobel_Edge_Combined.UseVisualStyleBackColor = true;
            this.Sobel_Edge_Combined.Click += new System.EventHandler(this.Sobel_Edge_Combined_Click);
            // 
            // Sobel_Edge_Vertical
            // 
            this.Sobel_Edge_Vertical.Location = new System.Drawing.Point(18, 20);
            this.Sobel_Edge_Vertical.Name = "Sobel_Edge_Vertical";
            this.Sobel_Edge_Vertical.Size = new System.Drawing.Size(73, 31);
            this.Sobel_Edge_Vertical.TabIndex = 2;
            this.Sobel_Edge_Vertical.Text = "Vertical";
            this.Sobel_Edge_Vertical.UseVisualStyleBackColor = true;
            this.Sobel_Edge_Vertical.Click += new System.EventHandler(this.Sobel_Edge_Vertical_Click);
            // 
            // Sobel_Edge_Horizontal
            // 
            this.Sobel_Edge_Horizontal.Location = new System.Drawing.Point(97, 20);
            this.Sobel_Edge_Horizontal.Name = "Sobel_Edge_Horizontal";
            this.Sobel_Edge_Horizontal.Size = new System.Drawing.Size(73, 31);
            this.Sobel_Edge_Horizontal.TabIndex = 3;
            this.Sobel_Edge_Horizontal.Text = "Horizontal";
            this.Sobel_Edge_Horizontal.UseVisualStyleBackColor = true;
            this.Sobel_Edge_Horizontal.Click += new System.EventHandler(this.Sobel_Edge_Horizontal_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox2);
            this.groupBox7.Controls.Add(this.trackBar2);
            this.groupBox7.Controls.Add(this.Edge_Overlapping);
            this.groupBox7.Location = new System.Drawing.Point(3, 418);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(257, 64);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Edge Overlapping";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(31, 22);
            this.textBox2.TabIndex = 9;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(3, 16);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(108, 45);
            this.trackBar2.TabIndex = 8;
            // 
            // Edge_Overlapping
            // 
            this.Edge_Overlapping.Location = new System.Drawing.Point(143, 16);
            this.Edge_Overlapping.Name = "Edge_Overlapping";
            this.Edge_Overlapping.Size = new System.Drawing.Size(108, 31);
            this.Edge_Overlapping.TabIndex = 2;
            this.Edge_Overlapping.Text = "Edge Overlapping";
            this.Edge_Overlapping.UseVisualStyleBackColor = true;
            this.Edge_Overlapping.Click += new System.EventHandler(this.Edge_Overlapping_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.Connected_Component);
            this.groupBox8.Location = new System.Drawing.Point(3, 488);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(257, 52);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Connected Component ";
            // 
            // Connected_Component
            // 
            this.Connected_Component.Location = new System.Drawing.Point(38, 11);
            this.Connected_Component.Name = "Connected_Component";
            this.Connected_Component.Size = new System.Drawing.Size(181, 35);
            this.Connected_Component.TabIndex = 8;
            this.Connected_Component.Text = "Connected";
            this.Connected_Component.UseVisualStyleBackColor = true;
            this.Connected_Component.Click += new System.EventHandler(this.Connected_Component_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.Image_Registration);
            this.groupBox9.Location = new System.Drawing.Point(6, 624);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(257, 53);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Image Registration";
            // 
            // Image_Registration
            // 
            this.Image_Registration.Location = new System.Drawing.Point(38, 12);
            this.Image_Registration.Name = "Image_Registration";
            this.Image_Registration.Size = new System.Drawing.Size(181, 35);
            this.Image_Registration.TabIndex = 9;
            this.Image_Registration.Text = "Image Registration";
            this.Image_Registration.UseVisualStyleBackColor = true;
            this.Image_Registration.Click += new System.EventHandler(this.Image_Registration_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(402, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(479, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(402, 434);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(479, 304);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(1091, 0);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "num";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(365, 184);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "Before";
            title3.ForeColor = System.Drawing.Color.Blue;
            title3.Name = "Title1";
            title3.Text = "Histogram of Gray Level (Before)";
            this.chart1.Titles.Add(title3);
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(1091, 190);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "num";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(365, 184);
            this.chart2.TabIndex = 10;
            this.chart2.Text = "Before";
            title4.ForeColor = System.Drawing.Color.Blue;
            title4.Name = "Title1";
            title4.Text = "Histogram of Gray Level (After)";
            this.chart2.Titles.Add(title4);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(965, 434);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(479, 304);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(31, 21);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(50, 22);
            this.textBox3.TabIndex = 12;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.textBox3);
            this.groupBox10.Location = new System.Drawing.Point(59, 554);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(111, 64);
            this.groupBox10.TabIndex = 13;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Num of component";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.textBox6);
            this.groupBox11.Controls.Add(this.textBox5);
            this.groupBox11.Controls.Add(this.textBox4);
            this.groupBox11.Controls.Add(this.label3);
            this.groupBox11.Controls.Add(this.label2);
            this.groupBox11.Controls.Add(this.label1);
            this.groupBox11.Location = new System.Drawing.Point(22, 697);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(200, 126);
            this.groupBox11.TabIndex = 14;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "registered image";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(132, 91);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(49, 22);
            this.textBox6.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(132, 56);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(49, 22);
            this.textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(132, 21);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(49, 22);
            this.textBox4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Intensity difference:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rotation angle:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scaling factor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "BEFORE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "AFTER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(953, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "REGISTRATION";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 835);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Image_Undo;
        private System.Windows.Forms.Button Image_Save;
        private System.Windows.Forms.Button Image_Load;
        private System.Windows.Forms.Button Color_Grayscale;
        private System.Windows.Forms.Button Color_B;
        private System.Windows.Forms.Button Color_G;
        private System.Windows.Forms.Button Color_R;
        private System.Windows.Forms.Button Median_Filter;
        private System.Windows.Forms.Button Mean_Filter;
        private System.Windows.Forms.Button Histogram_Equalization;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Thresholding;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button Sobel_Edge_Combined;
        private System.Windows.Forms.Button Sobel_Edge_Vertical;
        private System.Windows.Forms.Button Sobel_Edge_Horizontal;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button Edge_Overlapping;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button Connected_Component;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button Image_Registration;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

