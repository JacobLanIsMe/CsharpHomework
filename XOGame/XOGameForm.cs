using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOGame
{
    public partial class XOGameForm : Form
    {
        public XOGameForm()
        {
            InitializeComponent();
        }
        string[,] arr = new string[3, 3] { {"1 ", "2 ", "3 " },
                                           {"4 ", "5 ", "6 " },
                                           {"7 ", "8 ", "9 " } };
        bool change = true;
        
        private void IsWin()
        {
            if ((arr[0,0] == arr[0,1] && arr[0,1] == arr[0,2]) ||
                (arr[1,0] == arr[1,1] && arr[1,1] == arr[1,2]) ||
                (arr[2,0] == arr[2,1] && arr[2,1] == arr[2,2]) ||
                (arr[0,0] == arr[1,0] && arr[1,0] == arr[2,0]) ||
                (arr[0,1] == arr[1,1] && arr[1,1] == arr[2,1]) ||
                (arr[0,2] == arr[1,2] && arr[1,2] == arr[2,2]) ||
                (arr[0,0] == arr[1,1] && arr[1,1] == arr[2,2]) ||
                (arr[2,0] == arr[1,1] && arr[1,1] == arr[0,2]))
            {
                if (change) MessageBox.Show($"X 手獲勝", "完局!", MessageBoxButtons.OK);
                else MessageBox.Show($"O 手獲勝", "完局!", MessageBoxButtons.OK);
                AllClear();
            }
            
        }
        private void AllClear()
        {
            int count = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = count + " ";
                    count++;
                }
            }
            Button[] buttons = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            foreach (Button i in buttons)
            {
                i.Text = "";
            }
            change = true;
        }
        private void ClickBtn(int i, int j, Button k)
        {
            if (change)
            {
                arr[i, j] = "O";
                k.Text = "O";
            }
            else
            {
                arr[i, j] = "X";
                k.Text = "X";
            }
            change = !change;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            ClickBtn(0, 0, btn1);
            IsWin();
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            ClickBtn(0, 1, btn2);
            IsWin();
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            ClickBtn(0, 2, btn3);
            IsWin();
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            ClickBtn(1, 0, btn4);
            IsWin();
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            ClickBtn(1, 1, btn5);
            IsWin();
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            ClickBtn(1, 2, btn6);
            IsWin();
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            ClickBtn(2, 0, btn7);
            IsWin();
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            ClickBtn(2, 1, btn8);
            IsWin();
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            ClickBtn(2, 2, btn9);
            IsWin();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            AllClear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
