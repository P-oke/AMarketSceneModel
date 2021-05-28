using System;
namespace TeamDGroupProject
{
    public class IssueBill
    {
        public static decimal BillForASpecificCommodity(Commodities commodity)
        {
            return Convert.ToDecimal(commodity.priceOfFirstCommodity);

        }

        public static decimal BillForSecondCommodity(Commodities commodity)
        {
            return Convert.ToDecimal(commodity.priceOfSecondCommodity);

        }

        public static decimal BillForThirdCommodity(Commodities commodity)
        {
            return Convert.ToDecimal(commodity.priceOfThirdCommodity);

        }


    }
}
