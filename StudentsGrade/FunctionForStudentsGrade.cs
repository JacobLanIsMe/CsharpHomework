using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsGrade
{
    public partial class StudentsGradeForm
    {
        private void CalAllScoreInfo(string name, int chinese, int english, int math)
        {
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
        private void ShowTableResult()
        {
            foreach (Student student in students)
            {
                result += $"{student.Name.PadRight(10)}{student.Chinese.PadLeft(5)}{student.English.PadLeft(7)}{student.Math.PadLeft(7)}{student.SumScore.PadLeft(7)}{student.AverageScore.PadLeft(7)}{student.MinSubjectScore.PadLeft(7)}{student.MaxSubjectScore.PadLeft(7)}\n";
            }
            labelScore.Text = result;
        }

    }

}
