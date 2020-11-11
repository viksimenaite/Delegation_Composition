using System;
using System.Collections.Generic;
using System.Text;

namespace Delegation_Composition
{
    class CakeFactory
    {
        double CountPrice(FoodProduct product)
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
