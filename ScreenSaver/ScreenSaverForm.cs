using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenSaver
{
    public partial class ScreenSaverForm : Form
    {
        public ScreenSaverForm()
        {
            InitializeComponent();
        }

        int startX = 10;
        int startY = 10;
        int screenX;
        int screenY;
        int startMousePositionX;
        int startMousePositionY;
        private void ScreenSaverForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Random random = new Random();
            Rectangle workArea = Screen.GetWorkingArea(this);
            screenX = workArea.Width;
            screenY = workArea.Height;
            startX = random.Next(workArea.Width / 2);
            startY = 0;
            Point mousePosition = MousePosition;
            startMousePositionX = mousePosition.X;
            startMousePositionY = mousePosition.Y;
        }
        private void ScreenSaverForm_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Exit();
        }
        int i = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Random random = new Random();
            pictureBox1.Location = new Point(startX + i, startY + i);
            i += 2;
            if (startX+i >= screenX - pictureBox1.Width || startY+i >= screenY - pictureBox1.Height)
            {
                startX = random.Next(screenX / 2);
                startY = 0;
                pictureBox1.Location = new Point(startX + 1, startY + 1);

                i = 0;
            }
            Point mousePosition = MousePosition;
            if (mousePosition.X != startMousePositionX || mousePosition.Y != startMousePositionY)
            {
                Application.Exit();
            }
        }

        
    }
}
