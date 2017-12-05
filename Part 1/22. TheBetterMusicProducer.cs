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
            int numberAlbumsEurope = int.Parse(Console.ReadLine());
            decimal priceAlbumEuro = decimal.Parse(Console.ReadLine())*1.94m;
            int numberAlbumsNorthAmerica = int.Parse(Console.ReadLine());
            decimal priceAlbumDollars = decimal.Parse(Console.ReadLine())*1.72m;
            int numberAlbumSouthAmerica = int.Parse(Console.ReadLine());
            decimal priceAlbumPesos = decimal.Parse(Console.ReadLine())/332.74m;
            int numberOfConcerts = int.Parse(Console.ReadLine());
            decimal profitFromAConcertInEuro = decimal.Parse(Console.ReadLine())*1.94m;

            decimal europe = numberAlbumsEurope*priceAlbumEuro;
            decimal nortAmerica = numberAlbumsNorthAmerica*priceAlbumDollars;
            decimal southAmerica = numberAlbumSouthAmerica*priceAlbumPesos;

            decimal allAlbumsSum = (europe + nortAmerica + southAmerica);
            allAlbumsSum *= 0.65m;
            allAlbumsSum *= 0.8m;

            decimal concertProfit = ((numberOfConcerts*profitFromAConcertInEuro));

            if (concertProfit > 100000)
            {
                concertProfit *= 0.85m;
            }

            if (allAlbumsSum > concertProfit)
            {
                Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.", allAlbumsSum);
            }
            else
            {
                Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", concertProfit);
            }
        
        }
    }
}
