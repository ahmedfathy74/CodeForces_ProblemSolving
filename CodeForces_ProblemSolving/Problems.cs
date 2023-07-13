using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeForces_ProblemSolving
{
    // This class will contain my extension methods.

    public static class Problems
    {
        // 520A --> Pangram Problem
        public static void Pangram()
        {
            var x = Console.ReadLine();
            var str1 = Console.ReadLine();
            int size = Convert.ToInt32(x);
            int Flag = 1;
            if (size < 26)
            {
                Flag = 0;
            }
            else
            {
                var alphabetSTR = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                var str = str1.ToUpper();
                for (int i = 0; i < alphabetSTR.Length; i++)
                {
                    if (!str.Contains(alphabetSTR[i]))
                    {
                        Flag = 0;
                        break;
                    }
                }
            }
            if (Flag == 1)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        //
    }
}
