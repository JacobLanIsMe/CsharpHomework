using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class PictureViewerForm : Form
    {
        public PictureViewerForm()
        {
            InitializeComponent();
        }
        public string[] allJPG;
        int imgX;
        int imgY;
        private void PictureViewerForm_Load(object sender, EventArgs e)
        {
            allJPG = Directory.GetFiles(@"../../../image", "*.jpg");
            imgX = 10;
            imgY = 10;
            for (int i = 0; i < allJPG.Length; i++)
            {
                if (imgX + 150 > this.Size.Width)
                {
                    imgX = 10;
                    imgY += 110;
                }
                PictureBox pictureBox = new PictureBox()
                {
                    Left = imgX,
                    Top = imgY,
                    Size = new Size(140, 100),
                    Image = new Bitmap(allJPG[i]),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Name = "pictureBox"+i,
                };
                Controls.Add(pictureBox);
                //pictureBox.BringToFront();
                imgX += 150;
                pictureBox.MouseUp += pictureBox1_MouseUp;
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(PictureBox) && control == sender)
                {
                    int pictureIndex = Convert.ToInt32(control.Name.Substring(10));
                    PictureViewerForm2 form2 = new PictureViewerForm2(allJPG, pictureIndex);
                    form2.Show();
                    return;
                }
            }
        }
        private void PictureViewerForm_SizeChanged(object sender, EventArgs e)
        {
            imgX = 10;
            imgY = 10;
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(PictureBox))
                {
                    if (imgX + 150 > this.Size.Width)
                    {
                        imgX = 10;
                        imgY += 110;
                    }
                    control.Left = imgX;
                    control.Top = imgY;
                }
                imgX += 150;
            }
        }
    }
}
