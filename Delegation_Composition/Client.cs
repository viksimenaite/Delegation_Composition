using System;
using System.Collections.Generic;
using System.Text;

namespace Delegation_Composition
{
    class Client
    {
        private EatingHabits eatingHabits;
        private bool toleratesLactose;

        public Client(EatingHabits eatingHabits, bool toleratesLactose )
        {
            this.eatingHabits = eatingHabits;
            this.toleratesLactose = toleratesLactose;

        }

        public bool ToleratesLactose { get => toleratesLactose; set => toleratesLactose = value; }
        internal EatingHabits EatingHabits { get => eatingHabits; set => eatingHabits = value; }
    }
}
