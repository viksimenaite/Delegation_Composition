using System;
using System.Collections.Generic;
using System.Text;

namespace Delegation_Composition
{
    interface IDiscounts
    {
        Double CountExpirationDiscount(FoodProduct product);
    }
}
