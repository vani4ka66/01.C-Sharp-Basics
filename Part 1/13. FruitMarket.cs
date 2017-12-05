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
            string dayOfWeek = Console.ReadLine();
            double quantity1 = double.Parse(Console.ReadLine());
            string product1 = Console.ReadLine();
            double quantity2 = double.Parse(Console.ReadLine());
            string product2 = Console.ReadLine();
            double quantity3 = double.Parse(Console.ReadLine());
            string product3 = Console.ReadLine();

            double price = 0;
            double banana = 1.8;
            double cucumber = 2.75;
            double tomato = 3.20;
            double orange = 1.6;
            double apple = 0.86;

            switch (dayOfWeek)
            {
                case "Friday":
                    banana -= banana * 0.10;
                    cucumber -= cucumber * 0.10;
                    tomato -= tomato * 0.10;
                    orange -= orange * 0.10;
                    apple -= apple * 0.10;
                    break;
                case "Sunday":
                    banana -= banana * 0.05;
                    cucumber -= cucumber * 0.05;
                    tomato -= tomato * 0.05;
                    orange -= orange * 0.05;
                    apple -= apple * 0.05;
                    break;
                case "Tuesday":
                    banana -= banana * 0.20;
                    orange -= orange * 0.20;
                    apple -= apple * 0.20;
                    break;
                case "Wednesday":
                    cucumber -= cucumber * 0.10;
                    tomato -= tomato * 0.10;
                    break;
                case "Thursday":
                    banana -= banana * 0.30;
                    break;
            }
            if (product1 == "banana")
            {
                banana *= quantity1;
                price += banana;
            }
            else if (product1 == "orange")
            {
                orange *= quantity1;
                price += orange;
            }
            else if (product1 == "apple")
            {
                apple *= quantity1;
                price += apple;
            }
            else if (product1 == "cucumber")
            {
                cucumber *= quantity1;
                price += cucumber;
            }
            else if (product1 == "tomato")
            {
                tomato *= quantity1;
                price += tomato;
            }

            double price2 = 0;

            if (product2 == "banana")
            {
                banana *= quantity2;
                price2 += banana;
            }
            else if (product2 == "orange")
            {
                orange *= quantity2;
                price2 += orange;
            }
            else if (product2 == "apple")
            {
                apple *= quantity2;
                price2 += apple;
            }
            else if (product2 == "cucumber")
            {
                cucumber *= quantity2;
                price2 += cucumber;
            }
            else if (product2 == "tomato")
            {
                tomato *= quantity2;
                price2 += tomato;
            }
            double price3 = 0;

            if (product3 == "banana")
            {
                banana *= quantity3;
                price3 += banana;
            }
            else if (product3 == "orange")
            {
                orange *= quantity3;
                price3 += orange;
            }
            else if (product3 == "apple")
            {
                apple *= quantity3;
                price3 += apple;
            }
            else if (product3 == "cucumber")
            {
                cucumber *= quantity3;
                price3 += cucumber;
            }
            else if (product3 == "tomato")
            {
                tomato *= quantity3;
                price3 += tomato;
            }

            Console.WriteLine("{0:F2}", price + price2 + price3);

        }
    }
}
