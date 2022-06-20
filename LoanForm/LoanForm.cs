using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanForm
{
    public partial class LoanForm : Form
    {
        public LoanForm()
        {
            InitializeComponent();
        }

        private void btnPMT_Click(object sender, EventArgs e)
        {
            double pmt = PMT();
            int pmtResult = Convert.ToInt32(pmt);
            MessageBox.Show("月付額: " + pmtResult.ToString() + "元");
        }

        private double PMT()
        {
            double loanAmount = Convert.ToDouble(textBoxLoanAmount.Text);
            double period = Convert.ToDouble(textBoxPeriod.Text);
            period = period * 12;
            double yearRate = Convert.ToDouble(textBoxRate.Text);
            double monthRate = yearRate / 12;
            monthRate = monthRate / 100;
            double downPayment = Convert.ToDouble(textBoxDownPayment.Text);
            loanAmount = loanAmount - downPayment;
            double pmt = loanAmount * (Math.Pow(1 + monthRate, period) * monthRate) / (Math.Pow(1 + monthRate, period) - 1);
            return pmt;
        }

        private void btnTotalAmount_Click(object sender, EventArgs e)
        {
            int pmt = Convert.ToInt32(PMT());
            int totalAmount = pmt * Convert.ToInt32(textBoxPeriod.Text) * 12;
            MessageBox.Show("總付款" + totalAmount + "元");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            LoanFormReport loanFormReport = new LoanFormReport();
            loanFormReport.labelLoanAmount.Text = textBoxLoanAmount.Text;
            loanFormReport.labelPeriod.Text = textBoxPeriod.Text;
            loanFormReport.labelRate.Text = textBoxRate.Text;
            loanFormReport.labelPmt.Text = Convert.ToInt32(PMT()).ToString();
            loanFormReport.labelTotalAmount.Text = (Convert.ToInt32(PMT()) * Convert.ToInt32(textBoxPeriod.Text) * 12).ToString();
            loanFormReport.Show();
        }
    }
}
