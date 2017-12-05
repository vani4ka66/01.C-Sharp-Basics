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
            int numberOfCabins = int.Parse(Console.ReadLine());
            string nextCommand = Console.ReadLine();
            int currentPosition = 0;
            long countSteps = 0;

            while (nextCommand != "Found a free one!")
            {
                int steps = int.Parse(nextCommand);
                int oldPosition = currentPosition;

                currentPosition = (currentPosition + steps) % numberOfCabins;

                int difference = (oldPosition - currentPosition);

                if (difference < 0)
                {
                    Console.WriteLine("Go {0} steps to the right, Ani.", Math.Abs(difference));
                    countSteps += Math.Abs(difference);
                }
                else if (difference > 0)
                {
                    Console.WriteLine("Go {0} steps to the left, Ani.", Math.Abs(difference));
                    countSteps += Math.Abs(difference);

                }
                else
                {
                    Console.WriteLine("Stay there, Ani.");
                    countSteps += difference;

                }

                nextCommand = Console.ReadLine();
            }
            Console.WriteLine("Moved a total of {0} steps.", (countSteps));

        }
    }
}
