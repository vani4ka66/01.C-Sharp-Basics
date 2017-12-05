using System;

class MusicOffers
{
    static void Main()
    {
        const decimal Euro = 1.94M;
        const decimal Dollar = 1.72M;
        const decimal Pesos = 332.74M;

        int euAlbumsCount = int.Parse(Console.ReadLine());
        decimal euAlbumPrice = decimal.Parse(Console.ReadLine());
        int naAlbumsCount = int.Parse(Console.ReadLine());
        decimal naAlbumPrice = decimal.Parse(Console.ReadLine());
        int saAlbumsCount = int.Parse(Console.ReadLine());
        decimal pesosAlbumPrice = decimal.Parse(Console.ReadLine());
        int concertsCount = int.Parse(Console.ReadLine());
        decimal eurConcertPrice = decimal.Parse(Console.ReadLine());

        decimal profitFromEurope = (euAlbumsCount * euAlbumPrice) * Euro;
        decimal profitFromNa = (naAlbumsCount * naAlbumPrice) * Dollar;
        decimal profitFromSa = (saAlbumsCount * pesosAlbumPrice) / Pesos;

        decimal albumsProfit = profitFromEurope + profitFromNa + profitFromSa;
        decimal producerTaxes = albumsProfit * 0.35M;
        albumsProfit = albumsProfit - producerTaxes;
        albumsProfit = albumsProfit - (albumsProfit * 0.20M);

        decimal concertProfit = (concertsCount * eurConcertPrice) * Euro;
        if (concertProfit > 100000M)
        {
            concertProfit = concertProfit - (concertProfit * 0.15M);
        }

        if (albumsProfit > concertProfit)
        {
            Console.WriteLine("Let’s record some songs! They'll bring us {0}lv.", 
                Math.Round(albumsProfit, 2));
        }
        else
        {
            Console.WriteLine("On the road again! We’ll see the world and earn {0}lv.", 
                Math.Round(concertProfit, 2));
        }

    }
}

