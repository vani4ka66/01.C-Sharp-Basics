using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        int floors = int.Parse(Console.ReadLine());
        int flats = int.Parse(Console.ReadLine());
        DateTime time = DateTime.Parse(Console.ReadLine());

        double result = 0;

        if (time.Hour>=14 && time.Hour<=18)
        {
            result = ((2 * 100.53) + (2 * 125.9))*floors*flats;
        }
        else if (time.Hour >= 19 && time.Hour <= 23)
        {
            result = ((7 * 100.53) +( 6 * 125.9))*floors*flats;
        }
        else if (time.Hour >= 00 && time.Hour <= 8)
        {
            result = ((1 * 100.53) + (8 * 125.9))*floors*flats;
        }
        Console.WriteLine("{0} Watts", (int)result);
    }
}








