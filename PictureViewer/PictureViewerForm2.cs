using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class PictureViewerForm2 : Form
    {
        public PictureViewerForm2()
        {
            InitializeComponent();
        }
        public PictureViewerForm2(string imgPathFromForm1)
        {
            InitializeComponent();
            imgPath = imgPathFromForm1;
        }
        string imgPath;

        private void PictureViewerForm2_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = new Bitmap(imgPath);
        }
    }
}
