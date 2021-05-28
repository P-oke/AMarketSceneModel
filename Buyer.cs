using System;
namespace TeamDGroupProject
{

    public class Buyer
    {
        public string[] buyers;

        public Buyer()
        {
            this.buyers = new string[] { "Buyer 1", "Buyer 2" };
        }

        public void BuyersBuyingCommodities()
        {
            Console.WriteLine("For Any Buyers in the Market, Each one of them can carry out the following purchasing activities with the Sellers in the Market.\n");
            foreach (var buyer in buyers)
            {

                Console.WriteLine($"{buyer} can carry out the following Activities in the Market.\n");
                BuyASpecificCommodityFromASeller();
                BuyDifferentCommoditiesFromASeller();
                BuyASpecificCommodityFromDifferentSellers();
                BuyDifferentCommoditiesFromDifferentSellers();

            }

        }

        private void BuyASpecificCommodityFromASeller()
        {
            Console.WriteLine("The Buyer can purchase a specific Commodity From a Seller.");

            Commodities commodity = new Commodities();
            Seller seller = new Seller();

            seller.SellerSellingASpecificCommodity(commodity);
        }

        private void BuyDifferentCommoditiesFromASeller()
        {
            Console.WriteLine("The Buyer can purchase different Commodities From a Seller.");
            Commodities commodities = new Commodities();
            Seller seller = new Seller();

            seller.SellerSellingDifferentCommodities(commodities);
        }


        private void BuyASpecificCommodityFromDifferentSellers()
        {
            Console.WriteLine("The Buyer can purchase a specific Commodity From different Sellers.");
            Seller sellers = new Seller();
            Commodities commodity = new Commodities();

            Seller.SellersSellingASpecificCommodity(sellers, commodity);

        }

        private void BuyDifferentCommoditiesFromDifferentSellers()
        {
            Console.WriteLine("The Buyer can purchase different Commodities From different Sellers.");
            Seller sellers = new Seller();
            Commodities commodities = new Commodities();

            Seller.SellersSellingDifferentCommodities(sellers, commodities);
        }
    }

}