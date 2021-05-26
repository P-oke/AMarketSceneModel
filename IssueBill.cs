using System;
namespace TeamDGroupProject
{
    public class IssueBill
    {
        public static decimal Bill(Commodities commodity)
        {
            // return decimal.Parse(sellingprice.sellerCommodityPrice);
            return Convert.ToDecimal(commodity.priceOfCommodity);

        }

    }
}



























// public static decimal BillForSellerSellingDifferentCommodities(Commodities commodities)
// {
//     decimal total = 0;
//     // totalPrice = 0;
//     foreach (var item in commodities.availableCommodities)
//     {
//         total += Convert.ToDecimal(commodities.priceOfCommodity);


//     }

//     return total;


// }

// public static decimal Bill(Seller sellers)
// {
//     return Convert.ToDecimal(sellers.sellerCommodityPrice.priceOfCommodity);

// }

// public static decimal BillForSellersSellingSpecificCommodity(Seller sellers)
// {
//     decimal total = 0;
//     // totalPrice = 0;
//     foreach (var item in sellers.sellersIntheMarket)
//     {
//         total += Convert.ToDecimal(sellers.sellerCommodityPrice.priceOfCommodity);


//     }

//     return total;





//     // decimal totalPrice = 0;
//     // for (int i = 0; i < sellers.Length; i++)
//     // {
//     //     if (sellers[i].sellerCommodities.aSpecificCommodity != null)
//     //     {
//     //         totalPrice = Convert.ToDecimal(sellers[i].sellerCommodityPrice.aSpecificCommodity);

//     //     }

//     // }
//     // return totalPrice;

// }

// public static decimal BillSellersSellingDifferentCommodities(Seller[] sellers)
// {
//     decimal firstTotal = 0, secondTotal = 0, grandTotal = 0;
//     for (int i = 0; i < sellers.Length; i++)
//     {
//         if (sellers[i].sellerCommodities.aSpecificCommodity != null)
//         {
//             firstTotal = Convert.ToDecimal(sellers[i].sellerCommodityPrice);

//         }

//         if (sellers[i].sellerCommodities.availableCommodities != null)
//         {
//             secondTotal = Convert.ToDecimal(sellers[i].sellerCommodityPrice);
//         }

//     }
//     return grandTotal;

// }
