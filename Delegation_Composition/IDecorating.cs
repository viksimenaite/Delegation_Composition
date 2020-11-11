using System;
using System.Collections.Generic;
using System.Text;

namespace Delegation_Composition
{
    interface IDecorating
    {
        Double AddSprinkles(FoodProduct product);
        Double AddMarshmallows(FoodProduct product);
    }
}
