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
            string chinese = textBoxChinese.Text;
            string english = textBoxEnglish.Text;
            string math = textBoxMath.Text;
            List<int> score = new List<int> { Convert.ToInt32(chinese), Convert.ToInt32(english), Convert.ToInt32(math) };
            List<string> subject = new List<string> { "國文", "英文", "數學" };
            int maxScoreIndex = score.IndexOf(score.Max());
            int minScoreIndex = score.IndexOf(score.Min());
            string sumScore = score.Sum().ToString();
            string averageScore = (Math.Round(score.Average(), 1, MidpointRounding.AwayFromZero)).ToString();
            string maxSubjectScore = $"{subject[maxScoreIndex]}{score[maxScoreIndex]}";
            string minSubjectScore = $"{subject[minScoreIndex]}{score[minScoreIndex]}";
            students.Add(new Student(name, chinese, english, math, sumScore, averageScore, minSubjectScore, maxSubjectScore));
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
            List<int> score = new List<int> { chinese, english, math };
            List<string> subject = new List<string> { "國文", "英文", "數學" };
            int maxScoreIndex = score.IndexOf(score.Max());
            int minScoreIndex = score.IndexOf(score.Min());
            string sumScore = score.Sum().ToString();
            string averageScore = (Math.Round(score.Average(), 1, MidpointRounding.AwayFromZero)).ToString();
            string maxSubjectScore = $"{subject[maxScoreIndex]}{score[maxScoreIndex]}";
            string minSubjectScore = $"{subject[minScoreIndex]}{score[minScoreIndex]}";
            students.Add(new Student(name, chinese.ToString(), english.ToString(), math.ToString(), sumScore, averageScore, minSubjectScore, maxSubjectScore));
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
                List<int> score = new List<int> { chinese, english, math };
                List<string> subject = new List<string> { "國文", "英文", "數學" };
                int maxScoreIndex = score.IndexOf(score.Max());
                int minScoreIndex = score.IndexOf(score.Min());
                string sumScore = score.Sum().ToString();
                string averageScore = (Math.Round(score.Average(), 1, MidpointRounding.AwayFromZero)).ToString();
                string maxSubjectScore = $"{subject[maxScoreIndex]}{score[maxScoreIndex]}";
                string minSubjectScore = $"{subject[minScoreIndex]}{score[minScoreIndex]}";
                students.Add(new Student(name, chinese.ToString(), english.ToString(), math.ToString(), sumScore, averageScore, minSubjectScore, maxSubjectScore));
            }
            ShowTableResult();
            if (result != "")
            {
                btnStatistics.Enabled = true;
                labelScore.BorderStyle = BorderStyle.FixedSingle;
            }
        }
        void ShowTableResult()
        {
            foreach (Student student in students)
            {
                result += $"{student.Name.PadRight(4)}{student.Chinese.PadLeft(6)}{student.English.PadLeft(8)}{student.Math.PadLeft(8)}{student.SumScore.PadLeft(8)}{student.AverageScore.PadLeft(8)}{student.MinSubjectScore.PadLeft(6)}{student.MaxSubjectScore.PadLeft(6)}\n";
            }
            labelScore.Text = result;
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
            subjectStatisticResult = $"{total.PadRight(4)}{sumChinese.PadLeft(5)}{sumEnglish.PadLeft(8)}{sumMath.PadLeft(8)}\n{average.PadRight(4)}{averageChinese.PadLeft(5)}{averageEnglish.PadLeft(8)}{averageMath.PadLeft(8)}\n{highScore.PadRight(2)}{highChinese.PadLeft(5)}{highEnglish.PadLeft(8)}{highMath.PadLeft(8)}\n{lowScore.PadRight(2)}{lowChinese.PadLeft(5)}{lowEnglish.PadLeft(8)}{lowMath.PadLeft(8)}";
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
    public class Student
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
