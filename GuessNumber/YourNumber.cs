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
    public partial class YourNumber : Form
    {
        public YourNumber()
        {
            InitializeComponent();
        }
        int yourNumberMax = 100;
        int yourNumberMin = 0;
        private void btnEnter_Click(object sender, EventArgs e)
        {
            int yourNumber;
            bool isCorrectNumberFormat = int.TryParse(textBoxYourNumber.Text, out yourNumber);

            if (isCorrectNumberFormat && yourNumber > yourNumberMin && yourNumber < yourNumberMax)
            {
                //GuessNumberForm guessNumberForm = (GuessNumberForm)this.Owner;
                GuessNumberForm guessNumberForm = (GuessNumberForm)this.Owner;

                if (yourNumber > guessNumberForm.answer)
                {
                    yourNumberMax = yourNumber;
                    guessNumberForm.GetLabelConditionText = $"Too Large!!!\nBetween {yourNumberMin} and {yourNumberMax}";
                    textBoxYourNumber.Focus();
                    textBoxYourNumber.Select(0, textBoxYourNumber.Text.Length);

                }
                else if (yourNumber < guessNumberForm.answer)
                {
                    yourNumberMin = yourNumber;
                    guessNumberForm.GetLabelConditionText = $"Too Samll!!!\nBetween {yourNumberMin} and {yourNumberMax}";
                    textBoxYourNumber.Focus();
                    textBoxYourNumber.Select(0, textBoxYourNumber.Text.Length);
                }
                else
                {
                    MessageBox.Show($"Congradulations!!! You got {guessNumberForm.answer}!!!");
                    this.Close();
                    guessNumberForm.GetLabelConditionText = "Please Select A Number Between 0 to 100";
                }
            }
            else
            {
                MessageBox.Show($"請輸入 {yourNumberMin} 到 {yourNumberMax} 的數字!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxYourNumber.Clear();
                textBoxYourNumber.Focus();
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
