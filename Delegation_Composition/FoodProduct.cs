using System;
using System.Collections.Generic;
using System.Text;

namespace Delegation_Composition
{
    class FoodProduct
    {
        private EatingHabits intendedFor;
        private DateTime expiryDate;
        private double baseKgPrice;
        private bool containsLactose;

        public FoodProduct(EatingHabits intendedFor, DateTime expiryDate, double baseKgPrice, bool containsLactose)
        {
            this.intendedFor = intendedFor;
            this.expiryDate = expiryDate;
            this.baseKgPrice = baseKgPrice;
            this.containsLactose = containsLactose;

        }

        public DateTime ExpiryDate { get => expiryDate; set => expiryDate = value; }
        public double BaseKgPrice { get => baseKgPrice; set => baseKgPrice = value; }
        public bool ContainsLactose { get => containsLactose; set => containsLactose = value; }
        internal EatingHabits IntendedFor { get => intendedFor; set => intendedFor = value; }
    }
}
