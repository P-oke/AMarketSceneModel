using System;
namespace TeamDGroupProject
{

    public class Buyer
    {
        public void BuyASpecificCommodityFromASpecificSeller()
        {
            Console.WriteLine("A Market Scene Where we have Buyers buying A specific Commodity From a Specific Seller");

            Commodities commodity = new Commodities();
            Seller seller = new Seller();

            seller.SellerSellingASpecificCommodity(commodity);
        }

        public void BuyDifferentCommoditiesFromASpecificSeller()
        {
            Console.WriteLine("A Market Scene Where we have Buyers buying Different Commodities From a Specific Seller");
            Commodities commodities = new Commodities();
            Seller seller = new Seller();

            seller.SellerSellingDifferentCommodities(commodities);
        }


        public void BuyASpecificCommodityFromDifferentSellers()
        {
            Console.WriteLine("A Market Scene Where we have Buyers buying A specific Commodity From a Specific Seller");
            Seller sellers = new Seller();
            Commodities commodity = new Commodities();

            Seller.SellersSellingASpecificCommodity(sellers, commodity);

        }

        public void BuyDifferentCommoditiesFromDifferentSellers()
        {
            Console.WriteLine("A Market Scene Where we have Buyers buying different Commodities From different Seller");
            Seller sellers = new Seller();
            Commodities commodities = new Commodities();

            Seller.SellersSellingDifferentCommodities(sellers, commodities);

        }
    }

}