using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August2017
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string input = Console.ReadLine();
            int result = 0;
            int count = 0;
            int totalMinutes = 0;
            int totalSeconds = 0;

            //Logic
            while (input != "Quit")
            {
                string[] command = input.Split(':');

                int minutes = int.Parse(command[0]);
                int seconds = int.Parse(command[1]);

                totalMinutes += minutes;
                totalSeconds += seconds;

                input = Console.ReadLine();
                count++;
            }
            result = totalMinutes * 60 + totalSeconds;
            double average = Math.Ceiling((double)result / count);
            if (average < 720)
            {
                Console.WriteLine("Gold Star");
                Console.WriteLine("Games - {0} \\ Average seconds - {1}", count, average);
            }
            else if (average >= 720 && average <= 1440)
            {
                Console.WriteLine("Silver Star");
                Console.WriteLine("Games - {0} \\ Average seconds - {1}", count, average);
            }
            else
            {
                Console.WriteLine("Bronze Star");
                Console.WriteLine("Games - {0} \\ Average seconds - {1}", count, average);
            }


        }
    }
}
