﻿using System;
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
            allJPG = Directory.GetFiles(@"../../../image", "*.jpg");
            Random random = new Random();
            int backImageIndex = random.Next(allJPG.Length);
            this.BackgroundImage = new Bitmap(allJPG[backImageIndex]);
            pictureBox1.Width = this.Size.Width;
            timer1.Enabled = true;
        }
        int timer = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer % 60 == 0)
            {
                Random random = new Random();
                int backImageIndex = random.Next(allJPG.Length);
                this.BackgroundImage = new Bitmap(allJPG[backImageIndex]);
            }
            timer += 1;
        }
    }
}
