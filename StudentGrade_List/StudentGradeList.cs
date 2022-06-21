using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGrade_List
{
    public partial class StudentGradeList : Form
    {
        public StudentGradeList()
        {
            InitializeComponent();
        }

        List<Student> students = new List<Student>();

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            students.Add(new Student(textBoxName.Text, Convert.ToInt32(textBoxChinese.Text), Convert.ToInt32(textBoxEnglish.Text), Convert.ToInt32(textBoxMath.Text)));
            ShowScore();
        }

        private void ShowScore()
        {
            foreach (Student student in students)
            {
                int sumScore = student.Chinese + student.English + student.Math;
                double averageScore = sumScore / 3;
                averageScore = Math.Round(averageScore, 1, MidpointRounding.AwayFromZero);
                List<int> score = new List<int> { student.Chinese, student.English, student.Math };
                List<string> subject = new List<string> { "國文", "英文", "數學" };
                int maxScore = score.Max();
                int minScore = score.Min();
                int maxScoreIndex = score.IndexOf(maxScore);
                int minScoreIndex = score.IndexOf(minScore);
                string maxScoreSubject = subject[maxScoreIndex];
                string minScoreSubject = subject[minScoreIndex];
                labelScore.Text = $"{student.Name}{student.Chinese.ToString().PadLeft(6)}{student.English}{student.Math}{sumScore}{averageScore}{minScoreSubject}{minScore}{maxScoreSubject}{maxScore}";
            }
        }
    }
    public struct Student
    {
        public string Name;
        public int Chinese, English, Math;
        public Student(string name, int chinese, int english, int math)
        {
            Name = name;
            Chinese = chinese;
            English = english;
            Math = math;
        }
    }
}
