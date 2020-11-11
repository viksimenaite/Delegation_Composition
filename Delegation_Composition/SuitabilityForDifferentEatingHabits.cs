using System;
using System.Collections.Generic;
using System.Text;

namespace Delegation_Composition
{
    class SuitabilityForDifferentEatingHabits : ISuitability
    {
        public bool IsSuitableForNonMeatEaters(FoodProduct product)
        {
            return product.IntendedFor == EatingHabits.Vegan || product.IntendedFor == EatingHabits.Vegetarian;
        }

        public bool IsSuitableForLactoseIntolerantPeople(FoodProduct product)
        {
            return !product.ContainsLactose;
        }
    }
}
