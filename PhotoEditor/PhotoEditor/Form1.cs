using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging.Filters;
using System.Drawing.Imaging;

namespace PhotoEditor
{
    public partial class Form1 : Form
    {
        bool draw = false;
        int x, y = 0;
        Color paintcolor;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "jpg|*jpg";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image = (Image)Image.FromFile(openFileDialog.FileName).Clone();
            }
            resize();
        }
        
        private void btn_filter1_Click(object sender, EventArgs e)
        {
            AForge.Imaging.Filters.OilPainting filter = new OilPainting();
            pictureBox1.Image = filter.Apply((Bitmap)pictureBox1.Image);
        }

        private void btn_filter2_Click(object sender, EventArgs e)
        {
            AForge.Imaging.Filters.SimplePosterization filter = new SimplePosterization();
            pictureBox1.Image = filter.Apply((Bitmap)pictureBox1.Image);
        }

        private void btn_filter3_Click(object sender, EventArgs e)
        {
            AForge.Imaging.Filters.WaterWave filter = new WaterWave();
            pictureBox1.Image = filter.Apply((Bitmap)pictureBox1.Image);
        }
        

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            x = e.X;
            y = e.Y;
        }

        private void bar_red_Scroll(object sender, EventArgs e)
        {
            paintcolor = Color.FromArgb(255, bar_red.Value, bar_green.Value, bar_blue.Value);
        }

        private void bar_green_Scroll(object sender, EventArgs e)
        {
            paintcolor = Color.FromArgb(255, bar_red.Value, bar_green.Value, bar_blue.Value);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            Rectangle rect = pictureBox1.RectangleToScreen(pictureBox1.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, pictureBox1.Size);
            g.Dispose();
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "jpg|*jpg";
            if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bmp.Save(s.FileName, ImageFormat.Jpeg);
            }
        }

        private void bar_blue_Scroll(object sender, EventArgs e)
        {
            paintcolor = Color.FromArgb(255, bar_red.Value, bar_green.Value, bar_blue.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resize();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resize();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            resize();
        }
        

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                Graphics g = pictureBox1.CreateGraphics();
                //currItem = Item.Brush;
                g.FillEllipse(new SolidBrush(paintcolor), e.X - x + x, e.Y - y + y, Convert.ToInt32(text_brushSize.Text), Convert.ToInt32(text_brushSize.Text));
                g.Dispose();
            }
        }
        
        private void resize()
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Width = (int)(0.8 * Form1.ActiveForm.Width);
                pictureBox1.Height = (int)(0.8 * Form1.ActiveForm.Height);
                pictureBox1.Anchor = 0;
                pictureBox1.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
                pictureBox1.SizeMode = 0;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.MaximumSize = new Size(Form1.ActiveForm.Width - panel1.Width - 50, Form1.ActiveForm.Height - 100);
            }
        }

    }
}
