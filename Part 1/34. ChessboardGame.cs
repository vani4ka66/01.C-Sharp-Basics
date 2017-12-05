using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string title = Console.ReadLine();

            int blackResult = 0;
            int whiteResult = 0;

            for (int i = 0; i < title.Length; i++)
            {
                if (i >= n * n)
                {
                    break;
                }
                if (i % 2 == 0 && char.IsUpper(title[i]))
                {
                    whiteResult += title[i];
                }
                else if (i % 2 == 0 && char.IsLetterOrDigit(title[i]))
                {
                    blackResult += title[i];
                }
                else if (i % 2 != 0 && char.IsUpper(title[i]))
                {
                    blackResult += title[i];
                }
                else if (i % 2 != 0 && char.IsLetterOrDigit(title[i]))
                {
                    whiteResult += title[i];
                }
            }
            if (blackResult == whiteResult)
            {
                Console.WriteLine("Equal result: {0}", blackResult);
            }
            else
            {
                Console.WriteLine("The winner is: {0} team",
                    whiteResult > blackResult ? "white" : "black");

                Console.WriteLine("{0}", Math.Abs(whiteResult - blackResult));
            }


        }
    }
}
