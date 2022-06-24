using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrade_List
{
    public partial class StudentGradeList
    {
        private void ShowScore(List<Student> students)
        {
            scoreResult = "";
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
                string maxScoreSubject = subject[maxScoreIndex] + maxScore;
                string minScoreSubject = subject[minScoreIndex] + minScore;
                scoreResult += $"{student.Name.PadRight(10)}{student.Chinese.ToString().PadLeft(5)}{student.English.ToString().PadLeft(7)}{student.Math.ToString().PadLeft(7)}{sumScore.ToString().PadLeft(7)}{averageScore.ToString().PadLeft(7)}{minScoreSubject.PadLeft(7)}{maxScoreSubject.PadLeft(7)}\n";
            }
            labelScore.Text = scoreResult;
        }
        private void AllTextBoxClear()
        {
            textBoxName.Text = "";
            textBoxChinese.Text = "";
            textBoxEnglish.Text = "";
            textBoxMath.Text = "";
        }
    }
}
