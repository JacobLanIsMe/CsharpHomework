using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawPaint
{
    public partial class DrawPaintForm : Form
    {
        public DrawPaintForm()
        {
            InitializeComponent();
        }
        Bitmap bitmap;
        int penPoint;
        int oldx, oldy;
        Color penColor = Color.Black;
        Graphics g;
        string selectedPen = "Pencil";
        byte R = 0, G = 0, B = 0;

        private void DrawPaintForm_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            bitmap = new Bitmap(this.Size.Width, this.Size.Height);
            pictureBox1.Image = bitmap;
            g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            pictureBox1.Refresh();
            buttonColorPicker.BackColor = Color.Black;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelPenPoint.Text = trackBar1.Value.ToString();
            penPoint = trackBar1.Value;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
                if (selectedPen == "Pencil")
                {
                    Pen pen = new Pen(penColor, penPoint);
                    g.DrawLine(pen, oldx, oldy, e.X, e.Y);
                    pen.Dispose();
                }
                if (selectedPen == "Brush")
                {
                    Pen pen = new Pen(penColor, penPoint);
                    g.DrawEllipse(pen, e.X, e.Y, penPoint, penPoint);
                    pen.Dispose();
                }
                if (selectedPen == "Painting brush")
                {
                    Pen pen = new Pen(Color.FromArgb(50, R, G, B), penPoint);
                    g.DrawEllipse(pen, e.X, e.Y, penPoint, penPoint);
                    pen.Dispose();
                }
                if (selectedPen == "Marker Pen")
                {
                    SolidBrush solidBrush = new SolidBrush(penColor);
                    g.FillRectangle(solidBrush, new Rectangle(e.X, e.Y, 7, penPoint));
                    solidBrush.Dispose();
                }
                if (selectedPen == "Eraser")
                {
                    SolidBrush solidBrush = new SolidBrush(Color.White);
                    g.FillRectangle(solidBrush, new Rectangle(e.X, e.Y, penPoint, penPoint));
                    solidBrush.Dispose();
                }
                pictureBox1.Image = bitmap;
                oldx = e.X;
                oldy = e.Y;
            }
        }
        void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPen.Checked)
            {
                selectedPen = "Pencil";
                trackBar1.Minimum = 1;
                trackBar1.Maximum = 30;
                labelPenPoint.Text = trackBar1.Value.ToString();
                penPoint = trackBar1.Value;
            }
            else if (radioButtonBrush.Checked)
            {
                selectedPen = "Brush";
                trackBar1.Minimum = 5;
                trackBar1.Maximum = 30;
                labelPenPoint.Text = trackBar1.Value.ToString();
                penPoint = trackBar1.Value;
            }
            else if (radioButtonPaintingBrush.Checked)
            {
                selectedPen = "Painting brush";
                trackBar1.Minimum = 5;
                trackBar1.Maximum = 30;
                labelPenPoint.Text = trackBar1.Value.ToString();
                penPoint = trackBar1.Value;
            }
            else if (radioButtonMarkerPen.Checked)
            {
                selectedPen = "Marker Pen";
                trackBar1.Minimum = 15;
                trackBar1.Maximum = 50;
                labelPenPoint.Text = trackBar1.Value.ToString();
                penPoint = trackBar1.Value;
            }
            else
            {
                selectedPen = "Eraser";
                trackBar1.Minimum = 15;
                trackBar1.Maximum = 50;
                labelPenPoint.Text = trackBar1.Value.ToString();
                penPoint = trackBar1.Value;
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            oldx = e.X;
            oldy = e.Y;
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(this.Size.Width, this.Size.Height);
            g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            pictureBox1.Image = bitmap;
            pictureBox1.Refresh();
        }

        private void buttonColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() != DialogResult.OK) { colorDialog.Dispose(); return; }
            buttonColorPicker.BackColor = colorDialog.Color;
            penColor = colorDialog.Color;
            R = colorDialog.Color.R;
            G = colorDialog.Color.G;
            B = colorDialog.Color.B;
        }

        
    }
}
