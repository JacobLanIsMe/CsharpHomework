using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_StructForm
{
    public partial class StructForm : Form
    {
        public StructForm()
        {
            InitializeComponent();
        }
        
        Student student;
        private void btnSaveContent_Click(object sender, EventArgs e)
        {
            
            student.Name = textBoxName.Text;
            student.ChineseScore = Convert.ToInt32(textBoxChinese.Text);
            student.EnglishScore = Convert.ToInt32(textBoxEnglish.Text);
            student.MathScore = Convert.ToInt32(textBoxMath.Text);
        }

        private void btnShowContent_Click(object sender, EventArgs e)
        {
            string result = $"姓名: {student.Name}\n國文: {student.ChineseScore}\n英文: {student.EnglishScore}\n數學: {student.MathScore}";
            labelScore.Text = result;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            int[] score = { student.ChineseScore, student.EnglishScore, student.MathScore };
            string[] subject = { "國文", "英文", "數學" };
            int maxScoreIndex = score.ToList().IndexOf(score.Max());
            int minScoreIndex = score.ToList().IndexOf(score.Min());
            labelMaxMinScore.Text = $"最高科目成績為: {subject[maxScoreIndex]}{score.Max()}分\n最低科目成績為: {subject[minScoreIndex]}{score.Min()}分";
        }
    }
    public struct Student
    {
        public string Name;
        public int ChineseScore, EnglishScore, MathScore;
        //public Student(string name, int chineseScore, int englishScore, int mathScore)
        //{
        //    Name = name;
        //    ChineseScore = chineseScore;
        //    EnglishScore = englishScore;
        //    MathScore = mathScore;
        //}
    }
}
