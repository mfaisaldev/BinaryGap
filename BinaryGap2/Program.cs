using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGap2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Solution.solution(6);
        }
    }
    public static class Solution
    {
        public static int solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if(N<1)
            {
                return 0;
            }
            string binary = Convert.ToString(N, 2);
            List<string> arrayLength = new List<string>();
            string[] arrayST = binary.Split('1');
            int gap = 0;
            foreach (var val in arrayST)
            {
                if(val.Length>0)
                {
                    arrayLength.Add(val.Length.ToString());
                }
            }
            if(arrayST[arrayST.Length - 1] != "")
            {
                arrayLength[arrayLength.Count-1]="0";
            }
            arrayLength = arrayLength.OrderByDescending(a => a).ToList();

            try
            { 
                if (arrayLength[0] != null && arrayST.Length>2)
                {
                    return Convert.ToInt16(arrayLength[0]);
                }
                else
                {
                    return 0;

                }
            }
            catch(ArgumentOutOfRangeException ex1)
            {
                return 0;
            }
            catch(NullReferenceException ex2)
            {
                return 0;
            }
            catch(IndexOutOfRangeException ex1)
            {
                return 0;
            }
        }
    }
}
