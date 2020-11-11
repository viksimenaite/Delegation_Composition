using System;
using System.Collections.Generic;
using System.Text;

namespace Delegation_Composition
{
    class CakeFactory:ISuitability
    {
        private ISuitability suitabilityRealisation;

        public CakeFactory(ISuitability suitabilityRealisation)
        {
            this.suitabilityRealisation = suitabilityRealisation;
        }

        public bool IsSuitableForLactoseIntolerantPeople(FoodProduct product)
        {
            return suitabilityRealisation.IsSuitableForLactoseIntolerantPeople(product);
        }

        public bool IsSuitableForNonMeatEaters(FoodProduct product)
        {
            return suitabilityRealisation.IsSuitableForNonMeatEaters(product);
        }

        public double CountPrice(FoodProduct product)
        {
            if (product.IntendedFor == EatingHabits.Vegan)
            {
                return product.BaseKgPrice + 8;
             }
            else if (product.IntendedFor == EatingHabits.Vegetarian)
            {
                return product.BaseKgPrice + 6;
            }
            else if (!product.ContainsLactose)
            {
                return product.BaseKgPrice + 4;
            }
            else
            {
                return product.BaseKgPrice + 2;
            }
        }
    }
}
