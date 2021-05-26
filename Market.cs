using System;
namespace TeamDGroupProject
{
    public class Market
    {
        public string marketName;


        public void PrintMarketInfo()
        {
            Console.WriteLine($"Welcome to {marketName}\t{DateTime.Now}\n");

        }
    }
}

