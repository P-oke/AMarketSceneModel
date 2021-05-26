using System;

namespace TeamDGroupProject
{
    public class Commodities
    {
        public double priceOfCommodity { get; private set; }

        public string aSpecificCommodity { get; private set; }//egg

        public string[] availableCommodities { get; private set; }// an array of different commodities.


        public Commodities()
        {
            this.aSpecificCommodity = "Rice";

            Random random = new Random();
            this.priceOfCommodity = Math.Round(100 * random.NextDouble(), 2);

            this.availableCommodities = new string[] { aSpecificCommodity, "Beans", "Yam" };
        }

    }

}