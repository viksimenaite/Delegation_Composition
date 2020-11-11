using System;
using System.Collections.Generic;
using System.Text;

namespace Delegation_Composition
{
    class HalfPriceDiscount : IDiscounts
    {
        public double CountExpirationDiscount(FoodProduct product)
        {
            if(DateTime.Now >= product.ExpiryDate)
            {
                return 0.5;
            }
            else
            {
                return 0;
            }
        }
    }
}
