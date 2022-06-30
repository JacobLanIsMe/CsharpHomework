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
        public PictureViewerForm2(string[] allJPGPath, int showIndex)
        {
            InitializeComponent();
            showForm2Index = showIndex;
            JPGPath = allJPGPath;
        }
        int showForm2Index;
        string[] JPGPath;

        private void PictureViewerForm2_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = new Bitmap(JPGPath[showForm2Index]);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            showForm2Index += 1;
            pictureBox1.Image = new Bitmap(JPGPath[showForm2Index]);
            btnLeft.Enabled = true;
            if (showForm2Index == JPGPath.Length - 1)
            {
                btnRight.Enabled = false;
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            showForm2Index -= 1;
            pictureBox1.Image = new Bitmap(JPGPath[showForm2Index]);
            btnRight.Enabled = true;
            if (showForm2Index == 0)
            {
                btnLeft.Enabled = false;
            }
        }

        
    }
}
