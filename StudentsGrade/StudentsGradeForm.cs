using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsGrade
{
    public partial class StudentsGradeForm : Form
    {
        public StudentsGradeForm()
        {
            InitializeComponent();
        }
        
        
        List<Student> students = new List<Student>();
        public string result;
        public string subjectStatisticResult;
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            result = "";
            string name = textBoxName.Text;
            int chinese = Convert.ToInt32(textBoxChinese.Text);
            int english = Convert.ToInt32(textBoxEnglish.Text);
            int math = Convert.ToInt32(textBoxMath.Text);
            CalAllScoreInfo(name, chinese, english, math);
            ShowTableResult();
            if (result != "") 
            {
                btnStatistics.Enabled = true;
                labelScore.BorderStyle = BorderStyle.FixedSingle;
            }
            
        }

        private void btnRandomStudent_Click(object sender, EventArgs e)
        {
            result = "";
            string name = (students.Count()+1).ToString();
            Random random = new Random();
            int chinese = random.Next(101);
            int english = random.Next(101);
            int math = random.Next(101);
            CalAllScoreInfo(name, chinese, english, math);
            ShowTableResult();
            if (result != "")
            {
                btnStatistics.Enabled = true;
                labelScore.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void btnRandom20Student_Click(object sender, EventArgs e)
        {
            result = "";
            Random random = new Random();
            for (int i = 0; i <20; i++)
            {
                string name = (students.Count() + 1).ToString();
                int chinese = random.Next(101);
                int english = random.Next(101);
                int math = random.Next(101);
                CalAllScoreInfo(name, chinese, english, math);
            }
            ShowTableResult();
            if (result != "")
            {
                btnStatistics.Enabled = true;
                labelScore.BorderStyle = BorderStyle.FixedSingle;
            }
        }
        
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            btnAddStudent.Enabled = false;
            btnRandomStudent.Enabled = false;
            btnStatistics.Enabled = false;
            btnRandom20Student.Enabled = false;
            List<int> allChineseScore = new List<int>();
            List<int> allEnglishScore = new List<int>();
            List<int> allMathScore = new List<int>();
            foreach (Student student in students)
            {
                allChineseScore.Add(Convert.ToInt32(student.Chinese));
                allEnglishScore.Add(Convert.ToInt32(student.English));
                allMathScore.Add(Convert.ToInt32(student.Math));
            }
            string sumChinese = allChineseScore.Sum().ToString();
            string averageChinese = Math.Round(allChineseScore.Average(), 1, MidpointRounding.AwayFromZero).ToString();
            string highChinese = allChineseScore.Max().ToString();
            string lowChinese = allChineseScore.Min().ToString();
            string sumEnglish = allEnglishScore.Sum().ToString();
            string averageEnglish = Math.Round(allEnglishScore.Average(), 1, MidpointRounding.AwayFromZero).ToString();
            string highEnglish = allEnglishScore.Max().ToString();
            string lowEnglish = allEnglishScore.Min().ToString();
            string sumMath = allMathScore.Sum().ToString();
            string averageMath = Math.Round(allMathScore.Average(), 1, MidpointRounding.AwayFromZero).ToString();
            string highMath = allMathScore.Max().ToString();
            string lowMath = allMathScore.Min().ToString();
            string total = "總分";
            string average = "平均";
            string highScore = "最高分";
            string lowScore = "最低分";
            subjectStatisticResult = $"{total.PadRight(9)}{sumChinese.PadLeft(5)}{sumEnglish.PadLeft(7)}{sumMath.PadLeft(7)}\n{average.PadRight(9)}{averageChinese.PadLeft(5)}{averageEnglish.PadLeft(7)}{averageMath.PadLeft(7)}\n{highScore.PadRight(8)}{highChinese.PadLeft(5)}{highEnglish.PadLeft(7)}{highMath.PadLeft(7)}\n{lowScore.PadRight(8)}{lowChinese.PadLeft(5)}{lowEnglish.PadLeft(7)}{lowMath.PadLeft(7)}";
            labelStatistics.Text = subjectStatisticResult;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnAddStudent.Enabled = true;
            btnRandomStudent.Enabled = true;
            btnStatistics.Enabled = false;
            btnRandom20Student.Enabled = true;
            students.Clear();
            result = "";
            subjectStatisticResult = "";
            labelScore.Text = result;
            labelStatistics.Text = subjectStatisticResult;
            labelScore.BorderStyle = BorderStyle.None;
            
        }
    }
    public struct Student
    {
        public string Name, Chinese, English, Math, SumScore, AverageScore, MinSubjectScore, MaxSubjectScore;
        public Student(string name, string chinese, string english, string math, string sumScore, string averageScore, string minSubjectScore, string maxSubjectScore)
        {
            Name = name;
            Chinese = chinese;
            English = english;
            Math = math;
            SumScore = sumScore;
            AverageScore = averageScore;
            MinSubjectScore = minSubjectScore;
            MaxSubjectScore = maxSubjectScore;
        }
    }
    
}
