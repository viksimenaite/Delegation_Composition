using System;
using System.Collections.Generic;
using System.Text;

namespace Delegation_Composition
{
    interface ISuitability
    {
        bool IsSuitableForLactoseIntolerantPeople(FoodProduct product);
        bool IsSuitableForNonMeatEaters(FoodProduct product);
    }
}
