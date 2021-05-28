using System;
namespace TeamDGroupProject
{
    public class Seller
    {

        public string[] sellersInTheMarket { get; private set; }


        public Seller()
        {
            this.sellersInTheMarket = new string[] { "Seller A", "Seller B", "Seller C" };
        }

        public void SellerSellingASpecificCommodity(Commodities commodity)
        {
            if (commodity.aSpecificCommodity != null)
            {
                decimal Bill = IssueBill.BillForASpecificCommodity(commodity);
                Console.WriteLine($"{sellersInTheMarket[0]} has sold {commodity.aSpecificCommodity} to you at N{Bill}\n");

            }
            else
            {
                Console.WriteLine($"{sellersInTheMarket[0]} does not have the specific commodity you want to buy.");
            }

        }

        public void SellerSellingDifferentCommodities(Commodities commodities)
        {
            decimal BillForRice = IssueBill.BillForASpecificCommodity(commodities);
            decimal BillForBeans = IssueBill.BillForSecondCommodity(commodities);
            decimal BillForYam = IssueBill.BillForThirdCommodity(commodities);

            foreach (var commodity in commodities.availableCommodities)
            {
                if (commodity == commodities.aSpecificCommodity && commodities.availableCommodities[1] == "Beans")
                {
                    Console.WriteLine($"{sellersInTheMarket[0]} has sold {commodities.aSpecificCommodity} to you at N{BillForRice} and {commodities.availableCommodities[1]} to you at N{BillForBeans}, Your Total Bill is: N{BillForRice + BillForBeans}");

                }
                else if (commodity == "Beans" && commodities.availableCommodities[2] == "Yam")
                {

                    Console.WriteLine($"{sellersInTheMarket[0]} has sold {commodities.availableCommodities[1]} to you at N{BillForBeans} and {commodities.availableCommodities[2]} to you at N{BillForRice}, Your Total Bill is: N{BillForBeans + BillForYam}");

                }
                else if (commodity == "Yam" && commodities.availableCommodities[0] == "Rice")
                {
                    Console.WriteLine($"{sellersInTheMarket[0]} has sold {commodities.availableCommodities[2]} to you at N{BillForYam} and {commodities.availableCommodities[0]} to you at N{BillForRice}, Your Total Bill is: N{BillForYam + BillForRice}");


                }
                else
                {
                    Console.WriteLine($"You have not bought any available commodities from {sellersInTheMarket[0]} in the Market");

                }

            }
            Console.WriteLine($"{sellersInTheMarket[0]} has sold {commodities.availableCommodities[0]} to you at N{BillForRice}, and {commodities.availableCommodities[1]} to you at N{BillForBeans}, and {commodities.availableCommodities[2]} to you at N{BillForYam} Your Total Bill is: N{BillForRice + BillForYam + BillForBeans}\n");

        }

        public static void SellersSellingASpecificCommodity(Seller sellers, Commodities commodity)
        {
            foreach (var seller in sellers.sellersInTheMarket)
            {
                if (seller == "Seller A")
                {
                    decimal Bill = IssueBill.BillForASpecificCommodity(commodity) + Convert.ToDecimal(.5);
                    Console.WriteLine($"{seller} has sold {commodity.aSpecificCommodity} to you at N{Bill}");

                }
                else if (seller == "Seller B")
                {
                    decimal Bill = IssueBill.BillForASpecificCommodity(commodity) + Convert.ToDecimal(.15);
                    Console.WriteLine($"{seller} has sold {commodity.aSpecificCommodity} to you at N{Bill}");

                }
                else if (seller == "Seller C")
                {
                    decimal Bill = IssueBill.BillForASpecificCommodity(commodity);
                    Console.WriteLine($"{seller} has sold {commodity.aSpecificCommodity} to you at N{Bill}\n");

                }
                else
                {
                    Console.WriteLine("You have not bought any commodity from Sellers of the specific commodity you want to buy in the Market");
                }
            }

        }

        public static void SellersSellingDifferentCommodities(Seller sellers, Commodities commodities)
        {

            decimal SellerARice = IssueBill.BillForASpecificCommodity(commodities);
            decimal SellerABeans = IssueBill.BillForSecondCommodity(commodities);
            decimal SellerAYam = IssueBill.BillForThirdCommodity(commodities);


            decimal SellerBRice = IssueBill.BillForASpecificCommodity(commodities) + Convert.ToDecimal(.4);
            decimal SellerBBeans = IssueBill.BillForSecondCommodity(commodities) + Convert.ToDecimal(.5);
            decimal SellerBYam = IssueBill.BillForThirdCommodity(commodities) + Convert.ToDecimal(.6);

            decimal SellerCRice = IssueBill.BillForASpecificCommodity(commodities) + Convert.ToDecimal(.7);
            decimal SellerCBeans = IssueBill.BillForSecondCommodity(commodities) + Convert.ToDecimal(.8);
            decimal SellerCYam = IssueBill.BillForThirdCommodity(commodities) + Convert.ToDecimal(.9);

            decimal[] ArrayOfTotalPrices = new decimal[] { SellerARice + SellerBBeans + SellerCYam, SellerABeans + SellerBYam + SellerCRice, SellerAYam + SellerBRice + SellerCBeans };


            Console.WriteLine($"{sellers.sellersInTheMarket[0]} has sold {commodities.availableCommodities[0]} to you at N{SellerARice}, and {sellers.sellersInTheMarket[1]} has sold {commodities.availableCommodities[1]} to you at N{SellerBBeans}, and {sellers.sellersInTheMarket[2]} has sold {commodities.availableCommodities[2]} to you at N{SellerCYam}, Your Total Bill is: N{ArrayOfTotalPrices[0]}");
            Console.WriteLine($"{sellers.sellersInTheMarket[0]} has sold {commodities.availableCommodities[1]} to you at N{SellerABeans}, and {sellers.sellersInTheMarket[1]} has sold {commodities.availableCommodities[2]} to you at N{SellerBYam}, and {sellers.sellersInTheMarket[2]} has sold {commodities.availableCommodities[0]} to you at N{SellerCRice}, Your Total Bill is: N{ArrayOfTotalPrices[1]}");
            Console.WriteLine($"{sellers.sellersInTheMarket[0]} has sold {commodities.availableCommodities[2]} to you at N{SellerAYam}, and {sellers.sellersInTheMarket[1]} has sold {commodities.availableCommodities[0]} to you at N{SellerBRice}, and {sellers.sellersInTheMarket[2]} has sold {commodities.availableCommodities[1]} to you at N{SellerCBeans}, Your Total Bill is: N{ArrayOfTotalPrices[2]}");

        }

    }
}
