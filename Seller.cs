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
                decimal result = IssueBill.Bill(commodity);
                Console.WriteLine($"{sellersInTheMarket[0]} has sold {commodity.aSpecificCommodity} to you at N{result}\n");

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
                    decimal result = IssueBill.Bill(commodities);
                    Console.WriteLine($"{sellersInTheMarket[0]} has sold {commodities.aSpecificCommodity} to you at N{result}");

                }
                else if (commodity == "Beans")
                {
                    decimal result = IssueBill.Bill(commodities);
                    Console.WriteLine($"{sellersInTheMarket[0]} has sold {commodity} to you at N{result}");

                }
                else if (commodity == "Yam")
                {
                    decimal result = IssueBill.Bill(commodities);
                    Console.WriteLine($"{sellersInTheMarket[0]} has sold {commodity} to you at N{result}\n");

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
                    decimal result = IssueBill.Bill(commodity);
                    Console.WriteLine($"{seller} has sold {commodity.aSpecificCommodity} to you at N{result}");

                }
                else if (seller == "Seller B")
                {
                    decimal result = IssueBill.Bill(commodity);
                    Console.WriteLine($"{seller} has sold {commodity.aSpecificCommodity} to you at N{result}");

                }
                else if (seller == "Seller C")
                {
                    decimal result = IssueBill.Bill(commodity);
                    Console.WriteLine($"{seller} has sold {commodity.aSpecificCommodity} to you at N{result}\n");

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
                    decimal result = IssueBill.Bill(commodities);
                    Console.WriteLine($"{sellers.sellersInTheMarket[i]} has sold {commodities.aSpecificCommodity} to you at N{result}");
                    Console.WriteLine($"{sellers.sellersInTheMarket[i]} has sold {commodities.availableCommodities[1]} to you at N{result}");
                    Console.WriteLine($"{sellers.sellersInTheMarket[i]} has sold {commodities.availableCommodities[2]} to you at N{result}");
                }
                else if (commodities.availableCommodities[i] == "Beans")
                {
                    decimal result = IssueBill.Bill(commodities);
                    Console.WriteLine($"{sellers.sellersInTheMarket[i]} has sold {commodities.availableCommodities[i]} to you at N{result}");
                    Console.WriteLine($"{sellers.sellersInTheMarket[i]} has sold {commodities.availableCommodities[0]} to you at N{result}");
                    Console.WriteLine($"{sellers.sellersInTheMarket[i]} has sold {commodities.availableCommodities[2]} to you at N{result}");

                }
                else if (commodities.availableCommodities[i] == "Yam")
                {
                    decimal result = IssueBill.Bill(commodities);
                    Console.WriteLine($"{sellers.sellersInTheMarket[i]} has sold {commodities.availableCommodities[i]} to you at N{result}");
                    Console.WriteLine($"{sellers.sellersInTheMarket[i]} has sold {commodities.availableCommodities[0]} to you at N{result}");
                    Console.WriteLine($"{sellers.sellersInTheMarket[i]} has sold {commodities.availableCommodities[1]} to you at N{result}");

                }
                else
                {
                    Console.WriteLine("You have not bought any commodities from any sellers available in the Market.");
                }

            }


        }


    }
}

// if (commodity.aSpecificCommodity != null)
// {
//     decimal result = IssueBill.Bill(commodity);
//     Console.WriteLine(result);

// }
// else if (sellers.sellerCommodities.availableCommodities != null)
// {
//     decimal result = IssueBill.BillForSellersSellingSpecificCommodity(sellers);
//     Console.WriteLine(result);
// }
// else
// {
//     //seller does not have the commodity.
// }
// }

// for (int i = 0; i < sellers.Length; i++)
// {
//     if (sellers[i].sellerCommodities.aSpecificCommodity != null)
//     {
//         // this seller does not have the specific commodity.  
//     }
//     else
//     {
//         //calculate the price
//     }

// }