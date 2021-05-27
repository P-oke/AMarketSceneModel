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

            foreach (var commodity in commodities.availableCommodities)
            {
                if (commodity == commodities.aSpecificCommodity)
                {
                    decimal Bill = IssueBill.BillForASpecificCommodity(commodities);
                    Console.WriteLine($"{sellersInTheMarket[0]} has sold {commodities.aSpecificCommodity} to you at N{ Bill}");

                }
                else if (commodity == "Beans")
                {
                    decimal Bill = IssueBill.BillForSecondCommodity(commodities);
                    Console.WriteLine($"{sellersInTheMarket[0]} has sold {commodity} to you at N{ Bill}");

                }
                else if (commodity == "Yam")
                {
                    decimal Bill = IssueBill.BillForThirdCommodity(commodities);
                    Console.WriteLine($"{sellersInTheMarket[0]} has sold {commodity} to you at N{Bill}\n");

                }
                else
                {
                    Console.WriteLine($"You do not want to buy any other Commodities from {sellersInTheMarket[0]}");
                }
            }

        }

        public static void SellersSellingASpecificCommodity(Seller sellers, Commodities commodity)
        {
            foreach (var seller in sellers.sellersInTheMarket)
            {
                if (seller == "Seller A")
                {
                    decimal Bill = IssueBill.BillForASpecificCommodity(commodity);
                    Console.WriteLine($"{seller} has sold {commodity.aSpecificCommodity} to you at N{Bill}");

                }
                else if (seller == "Seller B")
                {
                    decimal Bill = IssueBill.BillForASpecificCommodity(commodity);
                    Console.WriteLine($"{seller} has sold {commodity.aSpecificCommodity} to you at N{Bill}");

                }
                else if (seller == "Seller C")
                {
                    decimal Bill = IssueBill.BillForASpecificCommodity(commodity);
                    Console.WriteLine($"{seller} has sold {commodity.aSpecificCommodity} to you at N {Bill}\n");

                }
                else
                {
                    Console.WriteLine("You have not bought any commodity from Sellers of the specific commodity you want to buy in the Market");
                }
            }

        }

        public static void SellersSellingDifferentCommodities(Seller sellers, Commodities commodities)
        {
            for (int i = 0; i < sellers.sellersInTheMarket.Length; i++)
            {
                if (commodities.aSpecificCommodity == commodities.availableCommodities[i])
                {
                    decimal aSpecificCommodityBill = IssueBill.BillForASpecificCommodity(commodities);
                    decimal secondCommodityBill = IssueBill.BillForSecondCommodity(commodities);
                    decimal thirdCommodityBill = IssueBill.BillForThirdCommodity(commodities);

                    Console.WriteLine($"{sellers.sellersInTheMarket[i]} has sold {commodities.aSpecificCommodity} to you at N{aSpecificCommodityBill}");
                    Console.WriteLine($"{sellers.sellersInTheMarket[i]} has sold {commodities.availableCommodities[1]} to you at N{secondCommodityBill}");
                    Console.WriteLine($"{sellers.sellersInTheMarket[i]} has sold {commodities.availableCommodities[2]} to you at N{thirdCommodityBill}");
                }
                else if (commodities.availableCommodities[i] == "Beans")
                {
                    decimal aSpecificCommodityBill = IssueBill.BillForASpecificCommodity(commodities);
                    decimal secondCommodityBill = IssueBill.BillForSecondCommodity(commodities);
                    decimal thirdCommodityBill = IssueBill.BillForThirdCommodity(commodities);

                    Console.WriteLine($"{sellers.sellersInTheMarket[i]} has sold {commodities.availableCommodities[i]} to you at N{secondCommodityBill}");
                    Console.WriteLine($"{sellers.sellersInTheMarket[i]} has sold {commodities.availableCommodities[0]} to you at N{aSpecificCommodityBill}");
                    Console.WriteLine($"{sellers.sellersInTheMarket[i]} has sold {commodities.availableCommodities[2]} to you at N{thirdCommodityBill}");

                }
                else if (commodities.availableCommodities[i] == "Yam")
                {
                    decimal aSpecificCommodityBill = IssueBill.BillForASpecificCommodity(commodities);
                    decimal secondCommodityBill = IssueBill.BillForSecondCommodity(commodities);
                    decimal thirdCommodityBill = IssueBill.BillForThirdCommodity(commodities);

                    Console.WriteLine($"{sellers.sellersInTheMarket[i]} has sold {commodities.availableCommodities[i]} to you at N{thirdCommodityBill}");
                    Console.WriteLine($"{sellers.sellersInTheMarket[i]} has sold {commodities.availableCommodities[0]} to you at N{aSpecificCommodityBill}");
                    Console.WriteLine($"{sellers.sellersInTheMarket[i]} has sold {commodities.availableCommodities[1]} to you at N{secondCommodityBill}\n");

                }
                else
                {
                    Console.WriteLine("You have not bought any commodities from any sellers available in the Market.");
                }

            }

        }

    }
}
