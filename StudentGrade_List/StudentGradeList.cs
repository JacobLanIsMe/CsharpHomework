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
        
        string scoreResult;
        int clickBtnSubjectScoreStatisticCount = 0;

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            students.Add(new Student(textBoxName.Text, Convert.ToInt32(textBoxChinese.Text), Convert.ToInt32(textBoxEnglish.Text), Convert.ToInt32(textBoxMath.Text)));
            ShowScore(students);
            if (students.Count > 0)
            {
                btnRemove.Enabled = true;
                labelScore.BorderStyle = BorderStyle.FixedSingle;
                btnSubjectScoreStatistic.Enabled = true;
            }
            AllTextBoxClear();
            if (clickBtnSubjectScoreStatisticCount > 0) btnSubjectScoreStatistic_Click(sender, e);
        }

        private void btnInsertStudent_Click(object sender, EventArgs e)
        {
            students.Insert(0, new Student(textBoxName.Text, Convert.ToInt32(textBoxChinese.Text), Convert.ToInt32(textBoxEnglish.Text), Convert.ToInt32(textBoxMath.Text)));
            ShowScore(students);
            if(students.Count > 0)
            {
                btnRemove.Enabled = true;
                labelScore.BorderStyle = BorderStyle.FixedSingle;
                btnSubjectScoreStatistic.Enabled = true;
            }
            AllTextBoxClear();
            if (clickBtnSubjectScoreStatisticCount > 0) btnSubjectScoreStatistic_Click(sender, e);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            students.RemoveAt(0);
            ShowScore(students);
            if (students.Count == 0)
            {
                btnRemove.Enabled = false;
                labelScore.BorderStyle = BorderStyle.None;
                labelStatistics.Text = "";
                clickBtnSubjectScoreStatisticCount = 0;
                btnSubjectScoreStatistic.Enabled = false;
            }
            else
            {
                btnSubjectScoreStatistic_Click(sender, e);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            students.Clear();
            ShowScore(students);
            if (students.Count == 0)
            {
                btnRemove.Enabled = false;
                labelScore.BorderStyle = BorderStyle.None;
                labelStatistics.Text = "";
                clickBtnSubjectScoreStatisticCount = 0;
                btnSubjectScoreStatistic.Enabled = false;
            }
            
        }
        private void btnSubjectScoreStatistic_Click(object sender, EventArgs e)
        {
            List<int> chineseStatistic = new List<int>();
            List<int> englishStatistic = new List<int>();
            List<int> mathStatistic = new List<int>();
            foreach (Student student in students)
            {
                chineseStatistic.Add(student.Chinese);
                englishStatistic.Add(student.English);
                mathStatistic.Add(student.Math);
            }
            string chineseTotalScore = chineseStatistic.Sum().ToString();
            string chineseAverage =Math.Round((chineseStatistic.Average()), 1, MidpointRounding.AwayFromZero).ToString();
            string chineseMaxScore = chineseStatistic.Max().ToString();
            string chineseMinScore = chineseStatistic.Min().ToString();
            string englishTotalScore = englishStatistic.Sum().ToString();
            string englishAverage = Math.Round((englishStatistic.Average()), 1, MidpointRounding.AwayFromZero).ToString();
            string englishMaxScore = englishStatistic.Max().ToString();
            string englishMinScore = englishStatistic.Min().ToString();
            string mathTotalScore = mathStatistic.Sum().ToString();
            string mathAverage = Math.Round(mathStatistic.Average(), 1, MidpointRounding.AwayFromZero).ToString();
            string mathMaxScore = mathStatistic.Max().ToString();
            string mathMinScore = mathStatistic.Min().ToString();
            string total = "總分".PadRight(9) + chineseTotalScore.PadLeft(5) + englishTotalScore.PadLeft(7) + mathTotalScore.PadLeft(7) + "\n";
            string average = "平均".PadRight(9) + chineseAverage.PadLeft(5) + englishAverage.PadLeft(7) + mathAverage.PadLeft(7) + "\n";
            string subjectMaxScore = "最高分".PadRight(8) + chineseMaxScore.PadLeft(5) + englishMaxScore.PadLeft(7) + mathMaxScore.PadLeft(7) + "\n";
            string subjectMinScore = "最低分".PadRight(8) + chineseMinScore.PadLeft(5) +englishMinScore.PadLeft(7) + mathMinScore.PadLeft(7) + "\n";
            labelStatistics.Text = total + average + subjectMaxScore + subjectMinScore;
            clickBtnSubjectScoreStatisticCount += 1;
        }

        private void btnSerchChineseRange_Click(object sender, EventArgs e)
        {
            List<Student> studentsInChineseRange = new List<Student>();
            foreach (Student student in students)
            {
                if (student.Chinese >= Convert.ToInt32(textBoxChineseSerchMin.Text) && student.Chinese <= Convert.ToInt32(textBoxChineseSerchMax.Text))
                {
                    studentsInChineseRange.Add(student);
                }
            }
            ShowScore(studentsInChineseRange);
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
