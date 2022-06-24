using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumber
{
    public partial class GuessNumberForm : Form
    {
        public GuessNumberForm()
        {
            InitializeComponent();
        }
        public static int answer;
        private void btnGuess_Click(object sender, EventArgs e)
        {
            YourNumber yournumberform = new YourNumber();
            Random random = new Random();
            answer = random.Next(1, 100);
            yournumberform.ShowDialog(this);
        }

        public string GetLabelConditionText
        {
            get { return labelCondition.Text; }
            set { labelCondition.Text = value; }
        }

        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Answer: {answer}");
        }
    }
}
