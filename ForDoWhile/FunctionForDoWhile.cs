using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDoWhile
{
    public partial class btnClearResult
    {
        private string ShowArray(int[,] arr)
        {
            string result = "";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    result += " " + arr[i, j];
                }
                result += "\n";
            }
            return result;
        }
    }
}
