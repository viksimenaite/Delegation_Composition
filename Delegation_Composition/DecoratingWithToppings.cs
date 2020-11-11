using System;
using System.Collections.Generic;
using System.Text;

namespace Delegation_Composition
{
    class DecoratingWithToppings : IDecorating
    {
        public double AddMarshmallows(FoodProduct product)
        {
            if (product.IntendedFor == EatingHabits.Vegan)
            {
                return 0;
  }
            else
            {
                return 1.2;
           }
        }

        public double AddSprinkles(FoodProduct product)
        {
            return 0.5;
        }
    }
}
