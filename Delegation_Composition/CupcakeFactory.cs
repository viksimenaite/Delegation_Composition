using System;
using System.Collections.Generic;
using System.Text;

namespace Delegation_Composition
{
    class CupcakeFactory: IDecorating, ISuitability
    {
        private IDecorating decoratingRealisation;
        private ISuitability suitabilityRealisation;

        public CupcakeFactory(IDecorating decoratingRealisation, ISuitability suitabilityRealisation)
        {
            this.decoratingRealisation = decoratingRealisation;
            this.suitabilityRealisation = suitabilityRealisation;
        }

        private int averageWeightInGrams = 100;

        public double AddMarshmallows(FoodProduct product)
        {
            return decoratingRealisation.AddMarshmallows(product);
        }

        public double AddSprinkles(FoodProduct product)
        {
            return decoratingRealisation.AddSprinkles(product);
        }

        public bool IsSuitableForLactoseIntolerantPeople(FoodProduct product)
        {
            return suitabilityRealisation.IsSuitableForLactoseIntolerantPeople(product);
        }

        public bool IsSuitableForNonMeatEaters(FoodProduct product)
        {
            return suitabilityRealisation.IsSuitableForNonMeatEaters(product);
        }
        public double CountPricePerOne(FoodProduct product)
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

        public double SellRequiredAmount(FoodProduct product, int quantity)
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
