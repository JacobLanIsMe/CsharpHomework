using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hello;
using LoanForm;
using POS;
using Student_StructForm;
using StudentsGrade;
using StudentGrade_List;
using Method;
using Calculator;
using ForDoWhile;
using XOGame;
using ScreenSaver;
using Notepad;
using DrawPaint;
using PictureViewer;
using GuessNumber;
using Alarm;
using System.IO;
using System.Drawing.Drawing2D;

namespace CsharpHomework
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent(); 
        }
        
        private void toolStripButtonHello_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            HelloForm helloForm = new HelloForm();
            helloForm.MdiParent = this;
            helloForm.StartPosition = FormStartPosition.CenterScreen;
            helloForm.Show();
        }
        private void toolStripButtonLoan_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            LoanForm.LoanForm loanForm = new LoanForm.LoanForm();
            loanForm.MdiParent = this;
            loanForm.StartPosition = FormStartPosition.CenterScreen;
            loanForm.Show();
        }

        private void toolStripButtonPOS_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            BarPOS barPOS = new BarPOS();
            barPOS.MdiParent = this;
            barPOS.StartPosition = FormStartPosition.CenterScreen;
            barPOS.Show();
        }

        private void toolStripButtonStudentStructForm_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            StructForm structForm = new StructForm();
            structForm.MdiParent = this;
            structForm.StartPosition = FormStartPosition.CenterScreen;
            structForm.Show();
        }

        private void toolStripButtonStudentsGrade_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            StudentsGradeForm studentsGradeForm = new StudentsGradeForm();
            studentsGradeForm.MdiParent = this;
            studentsGradeForm.StartPosition = FormStartPosition.CenterScreen;
            studentsGradeForm.Show();
        }

        private void toolStripButtonStudentsGrade_List_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            StudentGradeList studentGradeList = new StudentGradeList();
            studentGradeList.MdiParent = this;
            studentGradeList.StartPosition = FormStartPosition.CenterScreen;
            studentGradeList.Show();
        }

        private void toolStripButtonMethod_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Method.btnClearResult method = new Method.btnClearResult();
            method.MdiParent = this;
            method.StartPosition = FormStartPosition.CenterScreen;
            method.Show();
        }

        private void toolStripButtonMyClac_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            CalculatorForm calculatorForm = new CalculatorForm();
            calculatorForm.MdiParent = this;
            calculatorForm.StartPosition = FormStartPosition.CenterScreen;
            calculatorForm.Show();
        }

        private void toolStripButtonForDoWhile_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ForDoWhile.btnClearResult forDoWhile = new ForDoWhile.btnClearResult();
            forDoWhile.MdiParent = this;
            forDoWhile.StartPosition = FormStartPosition.CenterScreen;
            forDoWhile.Show();
        }

        private void toolStripButtonXOGame_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            XOGameForm xOGameForm = new XOGameForm();
            xOGameForm.MdiParent = this;
            xOGameForm.StartPosition = FormStartPosition.CenterScreen;
            xOGameForm.Show();
        }

        private void toolStripButtonScreenSaver_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            ScreenSaverForm screenSaverForm = new ScreenSaverForm();
            screenSaverForm.Show();
        }

        private void toolStripButtonGuess_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            GuessNumberForm guessNumberForm = new GuessNumberForm();
            guessNumberForm.MdiParent = this;
            guessNumberForm.StartPosition = FormStartPosition.CenterScreen;
            guessNumberForm.Show();
        }

        private void toolStripButtonAlarm_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            AlarmForm alarmForm = new AlarmForm();
            alarmForm.MdiParent = this;
            alarmForm.StartPosition = FormStartPosition.CenterScreen;
            alarmForm.Show();
        }

        private void toolStripButtonNotepad_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            NotepadForm notepadForm = new NotepadForm();
            notepadForm.MdiParent = this;
            notepadForm.StartPosition = FormStartPosition.CenterScreen;
            notepadForm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            PictureViewerForm pictureViewerForm = new PictureViewerForm();
            pictureViewerForm.MdiParent = this;
            pictureViewerForm.StartPosition = FormStartPosition.CenterScreen;
            pictureViewerForm.Show();
        }

        private void toolStripButtonPainter_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            DrawPaintForm drawPaintForm = new DrawPaintForm();
            drawPaintForm.MdiParent = this;
            drawPaintForm.StartPosition = FormStartPosition.CenterScreen;
            drawPaintForm.Show();
        }
        public string[] allJPG;
        private void MainForm_Load(object sender, EventArgs e)
        {
            allJPG = Directory.GetFiles(@"../../../image/BackImage", "*.jpg");
            Random random = new Random();
            int backImageIndex = random.Next(allJPG.Length-2);
            this.BackgroundImage = new Bitmap(allJPG[backImageIndex]);
            toolStrip1.BackgroundImage = Image.FromFile(allJPG[backImageIndex+1]);
            string[] fileName = allJPG[backImageIndex+1].Split('\\');
            if (fileName[fileName.Length - 1] == "下載(21).jpg") toolStrip1.ForeColor = Color.White;
            else toolStrip1.ForeColor = Color.Black;
            pictureBox1.Width = this.Size.Width;
            pictureBox1.Image = Image.FromFile(allJPG[backImageIndex+2]);
            string[] fileName1 = allJPG[backImageIndex+2].Split('\\');
            if (fileName1[fileName1.Length - 1] == "下載(21).jpg")
            {
                label1.ForeColor = Color.White;
                labelEngName.ForeColor = Color.White;
            }
            else
            {
                label1.ForeColor = Color.Black;
                labelEngName.ForeColor = Color.Black;
            }
            label1.Parent = pictureBox1;
            labelEngName.Parent = pictureBox1;
            linkLabelGitHub.Parent = pictureBox1;
            linkLabelLinkedIn.Parent = pictureBox1;
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(pictureBoxPhoto.ClientRectangle);
            Region region = new Region(gp);
            pictureBoxPhoto.Region = region;
            gp.Dispose();
            region.Dispose();
            timer1.Enabled = true;
        }
        int timer = 0;
        int timer2 = 20;
        int timer3 = 40;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer % 60 == 0)
            {
                Random random = new Random();
                int backImageIndex = random.Next(allJPG.Length);
                this.BackgroundImage = new Bitmap(allJPG[backImageIndex]); 
            }
            if (timer2 % 60 == 0)
            {
                Random random = new Random();
                int backImageIndex = random.Next(allJPG.Length);
                toolStrip1.BackgroundImage = Image.FromFile(allJPG[backImageIndex]);
                string[] fileName = allJPG[backImageIndex].Split('\\');
                if (fileName[fileName.Length-1] == "下載(21).jpg") toolStrip1.ForeColor = Color.White;
                else toolStrip1.ForeColor = Color.Black;
            }
            if (timer3 % 60 == 0)
            {
                Random random = new Random();
                int backImageIndex = random.Next(allJPG.Length);
                pictureBox1.Image = Image.FromFile(allJPG[backImageIndex]);
                string[] fileName = allJPG[backImageIndex].Split('\\');
                if (fileName[fileName.Length - 1] == "下載(21).jpg")
                {
                    label1.ForeColor = Color.White;
                    labelEngName.ForeColor = Color.White;
                }
                else 
                {
                    label1.ForeColor = Color.Black;
                    labelEngName.ForeColor = Color.Black;
                }
                
            }
            timer += 1;
            timer2 += 1;
            timer3 += 1;
        }

        private void linkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JacobLanIsMe");
        }

        private void linkLabelLinkedIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/%E7%B4%B9%E7%91%8B-%E8%97%8D-9b7547166/");
        }
    }
}
