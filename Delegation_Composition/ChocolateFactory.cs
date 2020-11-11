using System;
using System.Collections.Generic;
using System.Text;

namespace Delegation_Composition
{
    class ChocolateFactory: IDiscounts
    {
        private IDiscounts discountsRealisation;

        public ChocolateFactory(IDiscounts discountsRealisation)
        {
            this.discountsRealisation = discountsRealisation;
        }
        public double CountExpirationDiscount(FoodProduct product)
        {
            return discountsRealisation.CountExpirationDiscount(product);
        }

        public double CountPricePer200g(FoodProduct product)
        {
             return product.BaseKgPrice * 0.2;
        }
    }
}
