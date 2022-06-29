using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm
{
    public partial class AlarmForm : Form
    {
        public AlarmForm()
        {
            InitializeComponent();
        }

        private void AlarmForm_Load(object sender, EventArgs e)
        {
            labelNowTime.Text = DateTime.Now.ToString("HH:mm:ss");
            timer1.Enabled = true;
            maskedTextBox1.Mask = "00時00分00秒";
            maskedTextBox1.ValidatingType = typeof(DateTime);
            maskedTextBox1.TypeValidationCompleted += new TypeValidationEventHandler(maskedTextBox1_TypeValidationCompleted);
        }

        bool isSetAlarm;
        bool isAlarmTime;
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelNowTime.Text = DateTime.Now.ToString("HH:mm:ss");
            if (DateTime.Now.ToString("HH時mm分ss秒") == maskedTextBox1.Text && checkBox1.Checked)
            {
                isSetAlarm = true;
            }

            if (isSetAlarm && checkBox1.Checked)
            {
                if (isAlarmTime) labelNowTime.ForeColor = Color.Red;
                else labelNowTime.ForeColor = Color.Green;
                isAlarmTime = !isAlarmTime;
            }
        }
        private void maskedTextBox1_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.ToolTipTitle = "Invalid Date Value";
                toolTip1.Show("The value you entered is not a valid date.", maskedTextBox1, 5000);
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isSetAlarm = false;
            labelNowTime.ForeColor = Color.Black;
        }
    }
}
