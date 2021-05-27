using System;
namespace TeamDGroupProject
{
    public class Market
    {
        public string marketName;


        public void PrintMarketInfo()
        {
            Console.WriteLine($"Welcome to {marketName} Buyers and Sellers, {DateTime.Now}\n");

        }

        public void MarketScene()
        {
            Buyer buyer = new Buyer();
            buyer.BuyersBuyingCommodities();

        }
    }

}