using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDiscountLibrary
{
    public class DiscountCalc
    {
        public int Discount(double price, int bookCount)
        {
            int totalDiscount = 0;
            int priceDiscount = 0;
            if (price < 0 || bookCount < 0)
            {
                return 1;
            }
            if (bookCount >= 3 && bookCount < 5)
            {
                totalDiscount = 5;
            }
            else if (bookCount >= 5 && bookCount < 10)
            {
                totalDiscount = 10;
            }
            else if (bookCount >= 10)
            {
                totalDiscount = 15;
            }

            if (price < 0)
            {
                return totalDiscount;
            }
            else
            {
                priceDiscount = (int)price / 500;
            }
            return totalDiscount + priceDiscount;
        }
    }
}
