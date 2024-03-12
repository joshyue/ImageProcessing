using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Numerics;
using System.Net;
using System.IO;

namespace ImageProcessing_HW1
{


    public partial class Form1 : Form
    {
        private Bitmap open_Img, pre_Img, process_Img, Q5_Original_Img;
        public Form1()
        {
            InitializeComponent();
        }
        private void Image_Load_Click(object sender, EventArgs e)
        {
            var CurrentDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.InitialDirectory = CurrentDirectory;
            openFileDialog1.Filter = "All Files|*.*|Bitmap Files (.bmp)|*.bmp|Jpeg File(.jpg)|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap openImg = new Bitmap(openFileDialog1.FileName);
                open_Img = openImg;
                this.pictureBox1.Image = open_Img;
                this.pictureBox2.Image = null;
                this.pictureBox3.Image = null;
                point_X = new int[8];
                point_Y = new int[8];
                paint_dot = false;
                chart1.Series[0].Points.Clear();
                chart2.Series[0].Points.Clear();
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;
                textBox5.Text = null;
                textBox6.Text = null;
                pre_Img = null;
            }
        }
        private void Image_Save_Click(object sender, EventArgs e)
        {
            var CurrentDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.InitialDirectory = CurrentDirectory;
            saveFileDialog1.Filter = "All Files|*.*|Bitmap Files (.bmp)|*.bmp|Jpeg File(.jpg)|*.jpg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(saveFileDialog1.FileName);
            }
        }
        private void Image_Undo_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = pre_Img;
            open_Img = (Bitmap)pre_Img.Clone();
            pictureBox1.Image = open_Img;
            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();
            pictureBox3.Image = null;
            point_X = new int[8];
            point_Y = new int[8];
            paint_dot = false;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
        }
        private void Color_R_Click(object sender, EventArgs e)//Question 1-1
        {
            pre_Img = (Bitmap)open_Img.Clone();
            for (int y = 0; y < open_Img.Height; y++)
            {
                for (int x = 0; x < open_Img.Width; x++)
                {
                    Color RGB = open_Img.GetPixel(x, y);
                    int ch_R = RGB.R;
                    open_Img.SetPixel(x, y, Color.FromArgb(ch_R, ch_R, ch_R));
                    pictureBox2.Image = open_Img;
                }
            }
        }
        private void Color_G_Click(object sender, EventArgs e)//Question 1-2
        {
            pre_Img = (Bitmap)open_Img.Clone();
            for (int y = 0; y < open_Img.Height; y++)
            {
                for (int x = 0; x < open_Img.Width; x++)
                {
                    Color RGB = open_Img.GetPixel(x, y);
                    int ch_G = RGB.G;
                    open_Img.SetPixel(x, y, Color.FromArgb(ch_G, ch_G, ch_G));
                    pictureBox2.Image = open_Img;
                }
            }
        }
        private void Color_B_Click(object sender, EventArgs e)//Question 1-3
        {
            pre_Img = (Bitmap)open_Img.Clone();
            for (int y = 0; y < open_Img.Height; y++)
            {
                for (int x = 0; x < open_Img.Width; x++)
                {
                    Color RGB = open_Img.GetPixel(x, y);
                    int ch_B = RGB.B;
                    open_Img.SetPixel(x, y, Color.FromArgb(ch_B, ch_B, ch_B));
                    pictureBox2.Image = open_Img;
                }
            }
        }
        private void Color_Grayscale_Click(object sender, EventArgs e)//Question 1-4
        {
            pre_Img = (Bitmap)open_Img.Clone();
            for (int y = 0; y < open_Img.Height; y++)
            {
                for (int x = 0; x < open_Img.Width; x++)
                {
                    Color RGB = open_Img.GetPixel(x, y);
                    int ch_Gray = Convert.ToInt32(0.299 * RGB.R + 0.587 * RGB.G + 0.114 * RGB.B);
                    open_Img.SetPixel(x, y, Color.FromArgb(ch_Gray, ch_Gray, ch_Gray));
                    pictureBox2.Image = open_Img;
                }
            }
        }
        private void Mean_Filter_Click(object sender, EventArgs e)//Question 2-1
        {
            pre_Img = (Bitmap)open_Img.Clone();
            process_Img = (Bitmap)open_Img.Clone();
            for (int y = 0; y < open_Img.Height; y++)
            {
                for (int x = 0; x < open_Img.Width; x++)
                {
                    int filter_value = 0;
                    for (int fy = -1; fy < 2; fy++)//3 * 3 filter
                    {
                        for (int fx = -1; fx < 2; fx++)
                        {
                            if (x + fx < 0 || y + fy < 0 || x + fx >= open_Img.Width || y + fy >= open_Img.Height)
                                filter_value += 0;
                            else
                            {
                                Color RGB = open_Img.GetPixel(x + fx, y + fy);
                                int ch_Gray = Convert.ToInt32(0.299 * RGB.R + 0.587 * RGB.G + 0.114 * RGB.B);
                                filter_value += ch_Gray;
                            }
                        }
                    }
                    process_Img.SetPixel(x, y, Color.FromArgb(filter_value / 9, filter_value / 9, filter_value / 9));
                }
            }
            open_Img = (Bitmap)process_Img.Clone();
            this.pictureBox2.Image = open_Img;
        }
        private void Median_Filter_Click(object sender, EventArgs e)//Question 2-2
        {
            pre_Img = (Bitmap)open_Img.Clone();
            process_Img = (Bitmap)open_Img.Clone();
            for (int y = 0; y < open_Img.Height; y++)
            {
                for (int x = 0; x < open_Img.Width; x++)
                {
                    int[] filter = new int[9];
                    int index = 0;
                    for (int fy = -1; fy < 2; fy++)//3 * 3 filter
                    {
                        for (int fx = -1; fx < 2; fx++)
                        {
                            if (x + fx < 0 || y + fy < 0 || x + fx >= open_Img.Width || y + fy >= open_Img.Height)
                            {
                                filter[index] = 0;
                                index++;
                            }
                            else
                            {
                                Color RGB = open_Img.GetPixel(x + fx, y + fy);
                                int ch_Gray = Convert.ToInt32(0.299 * RGB.R + 0.587 * RGB.G + 0.114 * RGB.B);
                                filter[index] = ch_Gray;
                                index++;
                            }
                        }
                    }
                    Array.Sort(filter);//sort array for getting median 
                    process_Img.SetPixel(x, y, Color.FromArgb(filter[4], filter[4], filter[4]));//filter[4] is median value
                }
            }
            open_Img = (Bitmap)process_Img.Clone();
            pictureBox2.Image = open_Img;
        }
        private void Histogram_Equalization_Click(object sender, EventArgs e)//Question 3
        {
            pre_Img = (Bitmap)open_Img.Clone();
            int[] grayscale_num = compute_grayscale_num(open_Img);
            int[] grayscale_cdf = new int[256];
            int cdf_num = 0;
            for (int i = 0; i < 256; i++)//cdf
            {
                if (grayscale_num[i] == 0)
                {
                    grayscale_cdf[i] = 0;
                }
                else
                {
                    cdf_num += grayscale_num[i];
                    grayscale_cdf[i] = cdf_num;
                }
            }
            int cdf_min = 0, cdf_max;
            for (int i = 0; i < 256; i++)
            {
                if (grayscale_cdf[i] != 0)
                {
                    cdf_min = grayscale_cdf[i];
                    break;
                }
            }
            cdf_max = grayscale_cdf.Max();
            for (int y = 0; y < open_Img.Height; y++)//Histogram Equalization
            {
                for (int x = 0; x < open_Img.Width; x++)
                {
                    Color RGB = open_Img.GetPixel(x, y);
                    int value = Convert.ToInt32(0.299 * RGB.R + 0.587 * RGB.G + 0.114 * RGB.B);
                    int equalization_value = (int)Math.Round(((double)grayscale_cdf[value] - (double)cdf_min) * 255 / ((double)cdf_max - (double)cdf_min));
                    open_Img.SetPixel(x, y, Color.FromArgb(equalization_value, equalization_value, equalization_value));
                }
            }
            pictureBox2.Image = open_Img;
            for (int i = 0; i < 256; i++)//Before Histogram Equalization
            {
                chart1.Series[0].Points.AddXY(i, grayscale_num[i]);
            }
            grayscale_num = compute_grayscale_num(open_Img);
            for (int i = 0; i < 256; i++)//After Histogram Equalization
            {
                chart2.Series[0].Points.AddXY(i, grayscale_num[i]);
            }
        }
        private void Thresholding_Click(object sender, EventArgs e)//Question 4
        {
            pre_Img = (Bitmap)open_Img.Clone();
            int threshold = trackBar1.Value;
            textBox1.Text = trackBar1.Value.ToString();
            compute_threshold(open_Img, threshold);
            pictureBox2.Image = open_Img;
        }

        private void Sobel_Edge_Vertical_Click(object sender, EventArgs e)//Question 5-1
        {
            pre_Img = (Bitmap)open_Img.Clone();
            int[] filter = new int[9] { -1, 0, 1, -2, 0, 2, -1, 0, 1 };//Detect vertical line
            compute_edge_detection(open_Img, filter);
            pictureBox2.Image = open_Img;
        }
        private void Sobel_Edge_Horizontal_Click(object sender, EventArgs e)//Question 5-2
        {
            pre_Img = (Bitmap)open_Img.Clone();
            int[] filter = new int[9] { -1, -2, -1, 0, 0, 0, 1, 2, 1 };//Detect horizontal line
            compute_edge_detection(open_Img, filter);
            pictureBox2.Image = open_Img;
        }
        private void Sobel_Edge_Combined_Click(object sender, EventArgs e)//Question 5-3
        {
            pre_Img = (Bitmap)open_Img.Clone();
            Q5_Original_Img = (Bitmap)open_Img.Clone();//for Question 6 
            process_Img = (Bitmap)open_Img.Clone();
            int[] filter1 = new int[9] { -1, 0, 1, -2, 0, 2, -1, 0, 1 };//Detect vertical line
            int[] filter2 = new int[9] { -1, -2, -1, 0, 0, 0, 1, 2, 1 };//Detect horizontal line
            for (int y = 0; y < process_Img.Height; y++)
            {
                for (int x = 0; x < process_Img.Width; x++)
                {
                    int filter_sum1 = 0;
                    int filter_sum2 = 0;
                    int index = 0;
                    for (int fy = -1; fy < 2; fy++)//3 * 3 filter
                    {
                        for (int fx = -1; fx < 2; fx++)
                        {
                            if (x + fx < 0 || y + fy < 0 || x + fx >= process_Img.Width || y + fy >= process_Img.Height)
                            {
                                filter_sum1 += 0;
                                filter_sum2 += 0;
                                index++;
                            }
                            else
                            {
                                Color RGB = process_Img.GetPixel(x + fx, y + fy);
                                int ch_Gray = Convert.ToInt32(0.299 * RGB.R + 0.587 * RGB.G + 0.114 * RGB.B);
                                filter_sum1 += filter1[index] * ch_Gray;
                                filter_sum2 += filter2[index] * ch_Gray;
                                index++;
                            }
                        }
                    }
                    int filter = Convert.ToInt32(Math.Sqrt(Math.Pow(filter_sum1, 2) + Math.Pow(filter_sum2, 2)));
                    if (filter > 255)
                        filter = 255;
                    open_Img.SetPixel(x, y, Color.FromArgb(filter, filter, filter));

                }
            }
            pictureBox2.Image = open_Img;
        }

        private void Edge_Overlapping_Click(object sender, EventArgs e)//Question 6
        { 
            pre_Img = (Bitmap)open_Img.Clone();
            int threshold = trackBar2.Value;
            textBox2.Text = trackBar2.Value.ToString();
            compute_threshold(open_Img, threshold);//threshoding
            for (int y = 0; y < open_Img.Height; y++)//overlapping
            {
                for (int x = 0; x < open_Img.Width; x++)
                {
                    Color RGB_ori = Q5_Original_Img.GetPixel(x, y);
                    Color RGB = open_Img.GetPixel(x, y);
                    int ch_Gray = Convert.ToInt32(0.299 * RGB.R + 0.587 * RGB.G + 0.114 * RGB.B); 
                    if(RGB_ori.G + ch_Gray > 255)
                        open_Img.SetPixel(x, y, Color.FromArgb(RGB_ori.R, 255, RGB_ori.B));
                    else
                        open_Img.SetPixel(x, y, Color.FromArgb(RGB_ori.R, RGB_ori.G + ch_Gray, RGB_ori.B));
                }
            }
            pictureBox2.Image = open_Img;
        }
        private int[,] visit;
        private int index;
        private void Connected_Component_Click(object sender, EventArgs e)//Question 7
        {
            pre_Img = (Bitmap)open_Img.Clone();
            open_Img = open_Img.Clone(new Rectangle(0,0, open_Img.Width, open_Img.Height),PixelFormat.Format24bppRgb);
            visit = new int[open_Img.Width, open_Img.Height] ;//save component index for drawing different color
            index = 0;//component index
            for (int y = 0; y < open_Img.Height; y++)//find connected component
            {
                for (int x = 0; x < open_Img.Width; x++)
                {
                    Color center = open_Img.GetPixel(x, y);
                    if (center.R == 0 && visit[x, y] == 0)//if center color is black and not been visited yet
                    {
                        index++;
                        visit[x, y] = index;
                        open_Img.SetPixel(x, y, Color.FromArgb(index* 12345 % 255, index * 45678 % 255, index * 78901 % 255));
                        dfs(x,y);//8 adjacency point to do dfs algo   
                    }
                }
            }
            pictureBox2.Image = open_Img;
            Console.WriteLine(index);
            textBox3.Text = Convert.ToString(index);
        }
        int[] point_X;
        int[] point_Y;
        int point_index;
        Bitmap second_Img;
        Bitmap process_ori_Img;
        bool paint_dot =false;
        private void Image_Registration_Click(object sender, EventArgs e)//Question 8
        {

            pre_Img = (Bitmap)open_Img.Clone();
            process_ori_Img = (Bitmap)open_Img.Clone();
            var CurrentDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.InitialDirectory = CurrentDirectory;
            openFileDialog1.Filter = "All Files|*.*|Bitmap Files (.bmp)|*.bmp|Jpeg File(.jpg)|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                second_Img = new Bitmap(openFileDialog1.FileName);
                this.pictureBox2.Image = second_Img;
            }
            process_Img = (Bitmap)second_Img.Clone();
            point_X = new int[8];
            point_Y = new int[8];
            point_index = 0;
            paint_dot = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)//get the pixel coordinate of image
        {
            if (paint_dot)
            {
                Point pixel_location = new Point(e.X, e.Y);
                Graphics g = pictureBox1.CreateGraphics();//create a paint board
                g.FillEllipse(Brushes.Red, pixel_location.X, pixel_location.Y, 8, 8);
                point_X[point_index] = e.X;
                point_Y[point_index] = e.Y;
                point_index++;
            }
        }
        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)//get the pixel coordinate of registered image
        {
            if (paint_dot)
            {
                Point pixel_location = new Point(e.X, e.Y);
                Graphics g = pictureBox2.CreateGraphics();//create a paint board
                g.FillEllipse(Brushes.Red, pixel_location.X, pixel_location.Y, 8, 8);
                point_X[point_index] = e.X;
                point_Y[point_index] = e.Y;
                point_index++;
                if (point_index == 8)
                {
                    compute_Image_Registration();
                }
            }
        }
        private void compute_Image_Registration()//compute scaling factor and angle 
        {
            int ori_x = Math.Abs(point_X[1] - point_X[0]);
            int ori_y = Math.Abs(point_Y[1] - point_Y[0]);
            double ori_len = Math.Sqrt(ori_x * ori_x + ori_y * ori_y);
            int aft_x = Math.Abs(point_X[5] - point_X[4]);
            int aft_y = Math.Abs(point_Y[5] - point_Y[4]);
            double aft_len = Math.Sqrt(aft_x * aft_x + aft_y * aft_y);
            double scaling_factor = ori_len / aft_len;
            int angle = Convert.ToInt32(Math.Atan2((point_Y[5] - point_Y[4]), (point_X[5] - point_X[4])) * 180 / Math.PI);
            Console.WriteLine(scaling_factor);
            Console.WriteLine(angle);
            double ix, iy, sx, sy, rsx, rsy;
            for (int y = 0; y < process_Img.Height; y++)//do registration
            {
                for (int x = 0; x < process_Img.Width; x++)
                {
                    Color RGB = process_Img.GetPixel(x, y);
                    double angle_theda = Convert.ToDouble(-angle) / 180 * Math.PI;
                    ix = x - 0.5 * process_Img.Width;
                    iy = (-1) * y + 0.5 * process_Img.Height;
                    sx = scaling_factor * (ix);
                    sy = scaling_factor * (iy);
                    rsx = sx * Math.Cos(angle_theda) + sy * Math.Sin(angle_theda);//clockwise 
                    rsy = (-1) * sx * Math.Sin(angle_theda) + sy * Math.Cos(angle_theda);  
                    ix = rsx + 0.5 * open_Img.Width;
                    iy = (-1) * rsy + 0.5 * open_Img.Height;
                    if (ix < open_Img.Width && iy < open_Img.Height && ix >= 0 && iy >= 0 && RGB.R != 0)
                    {
                        open_Img.SetPixel((int)ix, (int)iy, Color.FromArgb(RGB.R, RGB.G, RGB.B));
                    }
                }
            }
            process_Img = (Bitmap)open_Img.Clone();
  
            double d_pixel = 0;
            for (int y = 0; y < process_Img.Height; y++)//do intensity difference
            {
                for (int x = 0; x < process_Img.Width; x++)
                {
                    Color ori = process_ori_Img.GetPixel(x, y);
                    Color aft = process_Img.GetPixel(x, y);
                    d_pixel = d_pixel + Math.Abs(ori.R - aft.R);
                }
            }
            d_pixel = d_pixel / (process_Img.Height * process_Img.Width);//intensity difference
            pictureBox3.Image = process_Img;
            textBox4.Text = Convert.ToString(scaling_factor);
            textBox5.Text = Convert.ToString((360 - (int)angle) % 360) + "°";
            textBox6.Text = Convert.ToString(d_pixel);
        }
        private int[] fx = { 0, 0, -1, -1, -1, 1, 1, 1 };
        private int[] fy = { 1, -1, 0, 1, -1, 0, 1, -1 };
      
        private void dfs(int x, int y)//dfs algorithm
        {
            for (int i = 0; i < 8; i++)
            {
                int xx = x + fx[i];
                int yy = y + fy[i];
                if (xx >= 0 && xx < open_Img.Width && yy >= 0 && yy < open_Img.Height)
                {
                    Color adjacency = open_Img.GetPixel(xx, yy);
                    if (visit[xx, yy] == 0 && adjacency.R == 0)//if adjacency color is black and not been visited yet
                    {
                        visit[xx, yy] = index;
                        open_Img.SetPixel(xx, yy, Color.FromArgb(index * 12345 % 255, index * 45678 % 255, index * 78901 % 255));
                        dfs(xx, yy);
                    }
                }
            }
           
        }


        public int[] compute_grayscale_num(Bitmap open_img)//num of every gray scale
        {
            int[] grayscale_num = new int[256];
            for (int y = 0; y < open_Img.Height; y++)//num of the every grayscale
            {
                for (int x = 0; x < open_Img.Width; x++)
                {
                    Color RGB = open_Img.GetPixel(x, y);
                    int ch_Gray = Convert.ToInt32(0.299 * RGB.R + 0.587 * RGB.G + 0.114 * RGB.B);
                    grayscale_num[ch_Gray]++;
                }
            }
            return grayscale_num;
        }
        public void compute_edge_detection(Bitmap open_img, int[] filter)//Edge_detection
        {
            process_Img = (Bitmap)open_Img.Clone();
            for (int y = 0; y < process_Img.Height; y++)
            {
                for (int x = 0; x < process_Img.Width; x++)
                {
                    int filter_sum = 0;
                    int index = 0;
                    for (int fy = -1; fy < 2; fy++)//3 * 3 filter
                    {
                        for (int fx = -1; fx < 2; fx++)
                        {
                            if (x + fx < 0 || y + fy < 0 || x + fx >= process_Img.Width || y + fy >= process_Img.Height)
                            {
                                filter_sum += 0;
                                index++;
                            }
                            else
                            {
                                Color RGB = process_Img.GetPixel(x + fx, y + fy);
                                int ch_Gray = Convert.ToInt32(0.299 * RGB.R + 0.587 * RGB.G + 0.114 * RGB.B);
                                filter_sum += filter[index] * ch_Gray;
                                index++;
                            }
                        }
                    }
                    if (filter_sum < 0)//set if filter_sum is overflow or underflow
                        filter_sum = 0;
                    else if (filter_sum > 255)
                        filter_sum = 255;
                    open_Img.SetPixel(x, y, Color.FromArgb(filter_sum, filter_sum, filter_sum));

                }
            }
        }
        public void compute_threshold(Bitmap open_img,int threshold)//Thresholding
        {  
            for (int y = 0; y < open_Img.Height; y++)
            {
                for (int x = 0; x < open_Img.Width; x++)
                {
                    Color RGB = open_Img.GetPixel(x, y);
                    int ch_Gray = Convert.ToInt32(0.299 * RGB.R + 0.587 * RGB.G + 0.114 * RGB.B);
                    if (ch_Gray < threshold)
                        open_Img.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    else
                        open_Img.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
            }
        }
    }
}
