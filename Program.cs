using System;

namespace TeamDGroupProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Market market = new Market();
            market.marketName = "Bariga Market";
            market.PrintMarketInfo();
            market.MarketScene();

        }
    }
}