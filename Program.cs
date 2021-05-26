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

            Buyer buyer = new Buyer();
            buyer.BuyASpecificCommodityFromASpecificSeller();
            buyer.BuyDifferentCommoditiesFromASpecificSeller();
            buyer.BuyASpecificCommodityFromDifferentSellers();
            buyer.BuyDifferentCommoditiesFromDifferentSellers();

        }
    }
}