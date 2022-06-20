using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            Information(out string chiName, out string engName, out string gender, out string zodiac);
            string result = $"Hello!\n我叫{chiName}\n我的英文名字是{engName}\n我的性別是{gender}\n我的星座是{zodiac}";
            MessageBox.Show(result);
        }

        private void Information(out string chiName, out string engName, out string gender, out string zodiac)
        {
            chiName = textBoxChiName.Text;
            engName = textBoxEngName.Text;
            gender = textBoxGender.Text;
            zodiac = textBoxZodiac.Text;
        }

        private void btnHi_Click(object sender, EventArgs e)
        {
            Information(out string chiName, out string engName, out string gender, out string zodiac);
            string result = $"Hi!\n我叫{chiName}\n我的英文名字是{engName}\n我的性別是{gender}\n我的星座是{zodiac}";
            MessageBox.Show(result);
        }
    }
}
