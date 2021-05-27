using System;

namespace TeamDGroupProject
{
    public class Commodities
    {
        public double priceOfFirstCommodity { get; private set; }
        public double priceOfSecondCommodity { get; private set; }
        public double priceOfThirdCommodity { get; private set; }


        public string aSpecificCommodity { get; private set; }//egg

        public string[] availableCommodities { get; private set; }// an array of different commodities.


        public Commodities()
        {
            this.aSpecificCommodity = "Rice";

            Random random = new Random();
            this.priceOfFirstCommodity = Math.Round(100 * random.NextDouble(), 2);
            this.priceOfSecondCommodity = Math.Round(100 * random.NextDouble(), 2);
            this.priceOfThirdCommodity = Math.Round(100 * random.NextDouble(), 2);

            this.availableCommodities = new string[] { aSpecificCommodity, "Beans", "Yam" };

        }

    }

}