using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class BarPOS : Form
    {
        public BarPOS()
        {
            InitializeComponent();
        }
        private int totalPrice = 0;
        List<string> lists = new List<string>();
        private int numBeer = 0;
        private int numTequila = 0;
        private int numWhisky = 0;
        private int numWine = 0;

        private void ShowTotalPrice()
        {
            textBoxTotalPrice.Text = "NT$ " + totalPrice;
        }
        private void ShowList()
        {
            listBox1.Items.Clear();
            totalPrice = 0;
            for (int i = 0; i < lists.Count; i++)
            {
                if (lists[i] == "啤酒Beer")
                {
                    string[] beer = btnBeer.Text.Split('$');
                    int beerPrice = Convert.ToInt32(beer[1]);
                    int beerPriceList = numBeer * beerPrice;
                    totalPrice += beerPriceList;
                    string beerResult = (lists[i] + " X" + numBeer + ", 共NT$ " + beerPriceList + " 元").PadLeft(31);
                    listBox1.Items.Add(beerResult);
                }
                else if (lists[i] == "龍舌蘭Tequila")
                {
                    string[] tequila = btnTequila.Text.Split('$');
                    int tequilaPrice = Convert.ToInt32(tequila[1]);
                    int tequilaPriceList = numTequila * tequilaPrice;
                    totalPrice += tequilaPriceList;
                    string tequilaResult = (lists[i] + " X" + numTequila + ", 共NT$ " + tequilaPriceList + " 元").PadLeft(30);
                    listBox1.Items.Add(tequilaResult);
                }
                else if (lists[i] == "威士忌Whisky")
                {
                    string[] whisky = btnWhisky.Text.Split('$');
                    int whiskyPrice = Convert.ToInt32(whisky[1]);
                    int whiskyPriceList = numWhisky * whiskyPrice;
                    totalPrice += whiskyPriceList;
                    string whiskyResult = (lists[i] + " X" + numWhisky + ", 共NT$ " + whiskyPriceList + " 元").PadLeft(30);
                    listBox1.Items.Add(whiskyResult);
                }
                else
                {
                    string[] wine = btnWine.Text.Split('$');
                    int winePrice = Convert.ToInt32(wine[1]);
                    int winePriceList = numWine * winePrice;
                    totalPrice += winePriceList;
                    string wineResult = (lists[i] + " X" + numWine + ", 共NT$ " + winePriceList + " 元").PadLeft(31);
                    listBox1.Items.Add(wineResult);
                }
            }
        }
        private void btnBeer_Click(object sender, EventArgs e)
        {
            string[] beer = btnBeer.Text.Split('$');
            numBeer += 1;
            if (numBeer == 1) lists.Add(beer[0].Replace("\n", "").Replace("NT", ""));
            ShowList();
            ShowTotalPrice();
        }

        private void btnTequila_Click(object sender, EventArgs e)
        {
            string[] tequila = btnTequila.Text.Split('$');
            numTequila += 1;
            if (numTequila == 1) lists.Add(tequila[0].Replace("\n", "").Replace("NT", ""));
            ShowList();
            ShowTotalPrice();
        }

        private void btnWhisky_Click(object sender, EventArgs e)
        {
            string[] whisky = btnWhisky.Text.Split('$');
            numWhisky += 1;
            if (numWhisky == 1) lists.Add(whisky[0].Replace("\n", "").Replace("NT", ""));
            ShowList();
            ShowTotalPrice();
        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            string[] wine = btnWine.Text.Split('$');
            numWine += 1;
            if (numWine == 1) lists.Add(wine[0].Replace("\n", "").Replace("NT", ""));
            ShowList();
            ShowTotalPrice();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額: " + "NT$" + totalPrice);
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            int discountPrice = Convert.ToInt32(totalPrice * 0.9);
            MessageBox.Show($"總金額: NT${totalPrice}\n折扣後金額: NT${discountPrice}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lists.Clear();
            listBox1.Items.Clear();
            listBox1.Items.Add("尚未點餐".PadLeft(28));
            numBeer = 0;
            numTequila = 0;
            numWhisky = 0;
            numWine = 0;
            totalPrice = 0;
            ShowTotalPrice();
        }
    }
}
