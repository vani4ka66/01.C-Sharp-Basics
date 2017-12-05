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
            int sets = int.Parse(Console.ReadLine());
            int numbers = int.Parse(Console.ReadLine());
            string oddEven = Console.ReadLine();
            int count1 = 0;
            int max = int.MinValue;
            int currentSET = 0;
            string currentSet = "";

            for (int i = 1; i <= sets; i++)
            {
                count1 = 0;

                for (int j = 0; j < numbers; j++)
                {
                    int current = int.Parse(Console.ReadLine());
                    if (oddEven == "odd")
                    {
                        if (current % 2 != 0)
                        {
                            count1++;
                            if (max < count1)
                            {
                                max = count1;
                                currentSET = i;

                            }
                        }

                    }

                    else
                    {
                        if (current % 2 == 0)
                        {
                            count1++;
                            if (max < count1)
                            {
                                max = count1;
                                currentSET = i;
                            }
                        }
                    }
                }
            }
            switch (currentSET)
            {
                case 1:
                    currentSet = "First";
                    break;
                case 2:
                    currentSet = "Second";
                    break;
                case 3:
                    currentSet = "Third";
                    break;
                case 4:
                    currentSet = "Fourth";
                    break;
                case 5:
                    currentSet = "Fifth";
                    break;
                case 6:
                    currentSet = "Sixth";
                    break;
                case 7:
                    currentSet = "Seventh";
                    break;
                case 8:
                    currentSet = "Eighth";
                    break;
                case 9:
                    currentSet = "Ninth";
                    break;
                case 10:
                    currentSet = "Tenth";
                    break;

            }
            if (count1 == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("{0} set has the most {1} numbers: {2}",
                    currentSet, oddEven, max);
            }

        }
    }
}
