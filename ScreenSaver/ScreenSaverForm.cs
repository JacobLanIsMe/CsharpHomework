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
        int formLoadSecond;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            Rectangle workArea = Screen.GetWorkingArea(this);
            label1.Location = new Point(random.Next(workArea.Width-label1.Width), random.Next(workArea.Height-label1.Height));
        }
        private void ScreenSaverForm_Load(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
            formLoadSecond = DateTime.Now.Second;
            
        }



        private void ScreenSaverForm_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Exit();
        }
    }
}
