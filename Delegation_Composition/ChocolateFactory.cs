using System;
using System.Collections.Generic;
using System.Text;

namespace Delegation_Composition
{
    class ChocolateFactory
    {
        double CountPricePer200g(FoodProduct product)
        {
             return product.BaseKgPrice * 0.2;
        }
    }
}
