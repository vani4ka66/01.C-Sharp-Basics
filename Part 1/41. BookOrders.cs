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
            int orderNumbers = int.Parse(Console.ReadLine());
            int bookOrdered = 0;
            decimal result = 0;
            int totalBookOrdered = 0;
            decimal total = 0;
            decimal discount = 0;

            for (int i = 0; i < orderNumbers; i++)
            {
                int packets = int.Parse(Console.ReadLine());
                int booksInPacket = int.Parse(Console.ReadLine());
                decimal pricePerBook = decimal.Parse(Console.ReadLine());

                bookOrdered = packets * booksInPacket;
                totalBookOrdered += bookOrdered;

                if (packets <= 19 && packets >= 10)
                {
                    discount = pricePerBook - (pricePerBook * (5 / 100m));
                }
                else if (packets <= 29 && packets >= 20)
                {
                    discount = pricePerBook - (pricePerBook * 6 / 100m);
                }
                else if (packets <= 39 && packets >= 30)
                {
                    discount = pricePerBook - (pricePerBook * 7 / 100);
                }
                else if (packets <= 49 && packets >= 40)
                {
                    discount = pricePerBook - (pricePerBook * 8 / 100);
                }
                else if (packets <= 59 && packets >= 50)
                {
                    discount = pricePerBook - (pricePerBook * 9 / 100);
                }
                else if (packets <= 69 && packets >= 60)
                {
                    discount = pricePerBook - (pricePerBook * 10 / 100);
                }
                else if (packets <= 79 && packets >= 70)
                {
                    discount = pricePerBook - (pricePerBook * 11 / 100);
                }
                else if (packets <= 89 && packets >= 80)
                {
                    discount = pricePerBook - (pricePerBook * 12 / 100);
                }
                else if (packets <= 99 && packets >= 90)
                {
                    discount = pricePerBook - (pricePerBook * 13 / 100);
                }
                else if (packets <= 109 && packets >= 100)
                {
                    discount = pricePerBook - (pricePerBook * 14 / 100);
                }
                else if (packets >= 110)
                {
                    discount = pricePerBook - (pricePerBook * (15 / 100m));
                }
                else if (packets < 10)
                {
                    discount = pricePerBook - 0;
                }

                result = packets * booksInPacket * discount;
                total += result;

            }
            Console.WriteLine(totalBookOrdered);
            Console.WriteLine("{0:F2}", total);


        }
    }
}
