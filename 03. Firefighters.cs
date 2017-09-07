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
            int fireFighters = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int kids = 0;
            int adults = 0;
            int seniors = 0;

            while (command != "rain")
            {
                int countFirefighters = 0;
                if (countFirefighters < fireFighters)
                {


                    for (int i = 0; i < command.Length; i++)
                    {
                        if (countFirefighters >= fireFighters)
                        {
                            break;
                        }
                        char current = command[i];
                        if (current == 'K')
                        {
                            kids++;
                            countFirefighters++;

                        }
                    }
                    for (int i = 0; i < command.Length; i++)
                    {
                        if (countFirefighters >= fireFighters)
                        {
                            break;
                        }
                        char current = command[i];
                        if (current == 'A')
                        {
                            adults++;
                            countFirefighters++;

                        }
                    }
                    for (int i = 0; i < command.Length; i++)
                    {
                        if (countFirefighters >= fireFighters)
                        {
                            break;
                        }
                        char current = command[i];
                        if (current == 'S')
                        {
                            seniors++;
                            countFirefighters++;

                        }
                    }
                }
                command = Console.ReadLine();

            }
            Console.WriteLine("Kids: {0}", kids);
            Console.WriteLine("Adults: {0}", adults);
            Console.WriteLine("Seniors: {0}", seniors);


        }
    }
}
