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
        Pen pen;
        float penPoint = 0;
        int oldx, oldy;
        Color penColor = Color.Black;
        Graphics g;

        private void DrawPaintForm_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            pen = new Pen(penColor, penPoint);
            bitmap = new Bitmap(this.Size.Width, this.Size.Height);
            g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            pictureBox1.Image = bitmap;
            pictureBox1.Refresh();
            labelColor.BackColor = Color.Black;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelPenPoint.Text = trackBar1.Value.ToString();
            penPoint = trackBar1.Value;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            oldx = e.X;
            oldy = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pen = new Pen(penColor, penPoint);
                g = Graphics.FromImage(bitmap);
                g.DrawLine(pen, oldx, oldy, e.X, e.Y);
                pictureBox1.Image = bitmap;
                oldx = e.X;
                oldy = e.Y;
            }
        }

        private void buttonColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() != DialogResult.OK) { colorDialog.Dispose(); return; }
            labelColor.BackColor = colorDialog.Color;
            penColor = colorDialog.Color;
        }

        
    }
}
