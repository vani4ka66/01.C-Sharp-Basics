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
            int centerX = int.Parse(Console.ReadLine());
            int centerY = int.Parse(Console.ReadLine());
            int radius = int.Parse(Console.ReadLine());
            int numberOfPlanesApproaching = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPlanesApproaching; i++)
            {
                int planeX = int.Parse(Console.ReadLine());
                int planeY = int.Parse(Console.ReadLine());

                int isInCircle = ((planeX - centerX) * (planeX - centerX)) + (planeY - centerY) * (planeY - centerY);
                //isinCircle = (x-circleX)*(x-circleX))+ (y-circleY)*(y-circleY)<=radius*radius
                if (isInCircle <= (radius * radius))
                {
                    Console.WriteLine("You destroyed a plane at [{0},{1}]", planeX, planeY);
                }

            }
        }
    }
}
