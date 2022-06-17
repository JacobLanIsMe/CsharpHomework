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
        public List<string> chiList = new List<string>();
        public List<string> engList = new List<string>();
        public List<int> price = new List<int>();



        private void panelBeer_Click(object sender, EventArgs e)
        {
            chiList.Add(labelChiBeer.Text);
            engList.Add(labelEngBeer.Text);
            price.Add(Convert.ToInt32(labelBeerPrice.Text));
        }

    }
}
