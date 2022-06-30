using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxNum1.Text, out double num1) && double.TryParse(textBoxNum2.Text, out double num2))
            {
                labelAnswer.Text = (num1 + num2).ToString();
            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式!");
            }
            
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxNum1.Text, out double num1) && double.TryParse(textBoxNum2.Text, out double num2))
            {
                labelAnswer.Text = (num1 - num2).ToString();
            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式!");
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxNum1.Text, out double num1) && double.TryParse(textBoxNum2.Text, out double num2))
            {
                labelAnswer.Text = (num1 * num2).ToString();
            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式!");
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxNum1.Text, out double num1) && double.TryParse(textBoxNum2.Text, out double num2))
            {
                labelAnswer.Text = (num1 / num2).ToString();
            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式!");
            }
        }

        
    }
}
