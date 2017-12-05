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
            double d = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());


            double downoadTime = (d / 2 / 60 / 60);
            double mall = (downoadTime * w);
            double numberOfMoviesDownloaded = d / 1500;
            double cinemaPrice = (numberOfMoviesDownloaded * p);

            if (mall > cinemaPrice)
            {
                Console.WriteLine("cinema -> {0:F2}lv", cinemaPrice);
            }
            else
            {
                Console.WriteLine("mall -> {0:F2}lv", mall);
            }


        }
    }
}
