using System;
using System.Collections.Generic;
using System.Text;

namespace Delegation_Composition
{
    class CupcakeFactory
    {
        private int averageWeightInGrams = 100;
        double CountPricePerOne(FoodProduct product)
        {
            if (product.ContainsLactose)
            {
                return product.BaseKgPrice * averageWeightInGrams / 1000 + 1;
  }
            else
            {
                return product.BaseKgPrice * averageWeightInGrams / 1000 + 2;
          }
        }

        double SellRequiredAmount(FoodProduct product, int quantity)
        {
            if (quantity > 10)
            {
                return CountPricePerOne(product) * quantity * 0.9;
            }
            else
            {
                return CountPricePerOne(product) * quantity;
            }
        }
    }
}
