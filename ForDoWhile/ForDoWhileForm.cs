using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForDoWhile
{
    public partial class btnClearResult : Form
    {
        public btnClearResult()
        {
            InitializeComponent();
        }

        private void btnOddOrEven_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxNumber.Text, out int num))
            {
                int remainder = num % 2;
                if (remainder == 0)
                    labelResult.Text = $"輸入的數{Convert.ToInt32(textBoxNumber.Text)}為 偶數";
                else
                    labelResult.Text = $"輸入的數{Convert.ToInt32(textBoxNumber.Text)}為 奇數";
            }
            else
            {
                MessageBox.Show("請輸入數值");
                textBoxNumber.Focus();
            }

        }

        private void btnCalOddEvenFromArray_Click(object sender, EventArgs e)
        {
            int[] arr = new int[10] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int oddCount = 0, evenCount = 0;
            foreach (int i in arr)
            {
                if (i % 2 == 0) evenCount++;
                else oddCount++;
            }
            labelResult.Text = $"int陣列arr[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n奇數共 {oddCount}\n偶數共 {evenCount}";
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            int[] arr = new int[10] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int maxValue = arr.Max();
            int minValue = arr.Min();
            labelResult.Text = $"int陣列arr[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n最大值為 {maxValue}\n最小值為 {minValue}";
        }

        private void btnCAndc_Click(object sender, EventArgs e)
        {
            string[] arr = new string[8]
            {
                "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker"
            };
            int CorcCount = 0;
            foreach (string i in arr)
            {
                bool isCorc = false;
                char[] name = i.ToCharArray();
                foreach (char j in name)
                {
                    if (j == 'C' || j == 'c') isCorc = true;
                }
                if (isCorc) CorcCount++;
            }
            labelResult.Text = $"arr_Str陣列: mother張, emma, 迪克蕭, J40, Candy, Cindy, Coconut, Motherfacker\n有 C 及 c 的名字共有 {CorcCount} 個";
        }

        private void btnLongName_Click(object sender, EventArgs e)
        {
            string[] arr = new string[8]
            {
                "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker"
            };
            int[] nameLength = new int[8];
            for (int i = 0; i < arr.Length; i++)
            {
                nameLength[i] = arr[i].Length;
            }
            string longName = arr[Array.IndexOf(nameLength, nameLength.ToList().Max())];
            labelResult.Text = $"arr_Str陣列: mother張, emma, 迪克蕭, J40, Candy, Cindy, Coconut, Motherfacker\n最長的名字為 {longName}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[10, 10];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == 0 || i == 9 || j == 0 || j == 9)
                        arr[i, j] = 1;
                    else
                        arr[i, j] = 0;
                }
            }
            string result = ShowArray(arr);
            labelResult.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[10, 10];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == 0 || i == 9 || j == 0 || j == 9)
                        arr[i, j] = 0;
                    else
                        arr[i, j] = 1;
                }
            }
            string result = ShowArray(arr);
            labelResult.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[10, 10];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i % 2 == j % 2)
                        arr[i, j] = 1;
                    else
                        arr[i, j] = 0;
                }
            }
            string result = ShowArray(arr);
            labelResult.Text = result;
        }

        private void btnSumArray_Click(object sender, EventArgs e)
        {
            int[] arr = new int[10] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int sum = arr.Sum();
            labelResult.Text = $"int陣列arr[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n加總為 {sum}";
        }

        private void btnMaxArray_Click(object sender, EventArgs e)
        {
            int[] arr = new int[10] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int max = arr.Max();
            labelResult.Text = $"int陣列arr[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n最大值為 {max}";
        }

        private void btnMinArray_Click(object sender, EventArgs e)
        {
            int[] arr = new int[10] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int min = arr.Min();
            labelResult.Text = $"int陣列arr[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n最小值為 {min}";
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string result = "";
            int n1 = 100, n2 = 200;
            result += $"換位前 n1 = {n1}, n2 = {n2}\n";
            GenericSwap<int>(ref n1, ref n2);
            result += $"換位後 n1 = {n1}, n2 = {n2}";
            labelResult.Text = result;
        }

        private void GenericSwap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelResult.Text = "結果";
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxFrom.Text, out int from)) ;
            else
            {
                MessageBox.Show("請輸入正確的數字格式!");
                textBoxFrom.Clear();
                textBoxFrom.Focus();
                return;
            } 
            if (int.TryParse(textBoxTo.Text, out int to)) ;
            else
            {
                MessageBox.Show("請輸入正確的數字格式!");
                textBoxTo.Clear();
                textBoxTo.Focus();
                return;
            }
            if (int.TryParse(textBoxStep.Text, out int step)) ;
            else
            {
                MessageBox.Show("請輸入正確的數字格式!");
                textBoxStep.Clear();
                textBoxStep.Focus();
                return;
            }
            int sum = 0;
            for (int i = from; i <= to; i = i + step)
            {
                sum += i;
            }
            labelResult.Text = $"{from} 到 {to} 相隔 {step}\n加總為 {sum}";
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxFrom.Text, out int from)) ;
            else
            {
                MessageBox.Show("請輸入正確的數字格式!");
                textBoxFrom.Clear();
                textBoxFrom.Focus();
                return;
            }
            if (int.TryParse(textBoxTo.Text, out int to)) ;
            else
            {
                MessageBox.Show("請輸入正確的數字格式!");
                textBoxTo.Clear();
                textBoxTo.Focus();
                return;
            }
            if (int.TryParse(textBoxStep.Text, out int step)) ;
            else
            {
                MessageBox.Show("請輸入正確的數字格式!");
                textBoxStep.Clear();
                textBoxStep.Focus();
                return;
            }
            int sum = 0;
            int i = from;
            while (i <= to)
            {
                sum += i;
                i = i + step;
            }
            labelResult.Text = $"{from} 到 {to} 相隔 {step}\n加總為 {sum}";
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxFrom.Text, out int from)) ;
            else
            {
                MessageBox.Show("請輸入正確的數字格式!");
                textBoxFrom.Clear();
                textBoxFrom.Focus();
                return;
            }
            if (int.TryParse(textBoxTo.Text, out int to)) ;
            else
            {
                MessageBox.Show("請輸入正確的數字格式!");
                textBoxTo.Clear();
                textBoxTo.Focus();
                return;
            }
            if (int.TryParse(textBoxStep.Text, out int step)) ;
            else
            {
                MessageBox.Show("請輸入正確的數字格式!");
                textBoxStep.Clear();
                textBoxStep.Focus();
                return;
            }
            int sum = 0;
            int i = from;
            do
            {
                sum += i;
                i = i + step;
            } while (i <= to);
            labelResult.Text = $"{from} 到 {to} 相隔 {step}\n加總為 {sum}";
        }

        private void btnChristmasTree_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxRows.Text, out int row)) ;
            else
            {
                MessageBox.Show("錯誤");
                textBoxRows.Clear();
                textBoxRows.Focus();
                return;
            }
            string result = "";
            for (int i = 0; i < row; i++)
            {
                string star = "";
                for (int j = 0; j <= i; j++)
                {
                    star += "*"; 
                }
                result += star + "\n";
            }
            labelResult.Text = result;
        }

        private void btn99Table_Click(object sender, EventArgs e)
        {
            string result = "九九乘法表\n";
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 2; j <= 9; j++)
                {
                    result += $"{j} x {i} = {(j*i).ToString().PadLeft(2)}| ";
                }
                result += "\n";
            }
            labelResult.Text = result;
        }






        private void btn100Binary_Click(object sender, EventArgs e)
        {
            int num = 100;
            string binary = "";
            while (num > 0)
            {
                binary = (num % 2) + binary;
                num /= 2;
            }
            labelResult.Text = binary;
        }

        private void btnLottery_Click(object sender, EventArgs e)
        {
            int[] lotteryNum = new int[8];
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                lotteryNum[i] = random.Next(1, 50);
            }
            string result = "";
            foreach (int num in lotteryNum)
            {
                result += num + " ";
            }
            result = result.Substring(0, result.Length - 1);
            labelResult.Text = $"樂透號碼\n{result}";
        }
    }
}
