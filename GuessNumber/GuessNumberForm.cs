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
        public int answer;
        private void btnGuess_Click(object sender, EventArgs e)
        {
            
            Random random = new Random();
            answer = random.Next(1, 100);
            YourNumber yournumberform = new YourNumber(answer);
            yournumberform.Show();
        }
        

        public string GetLabelConditionText
        {
            get { return labelCondition.Text; }
            set { labelCondition.Text = value; }
        }

        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            DialogResult result  = MessageBox.Show($"Answer: {answer}", "答案", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                labelCondition.Text = "Please Select A Number Between 0 to 100";
            }
        }
    }
}
