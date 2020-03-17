using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    public class NuclearEngine : Engine
    {
        private Waste nuclearWaste;

        public NuclearEngine()
        {
            nuclearWaste = new Waste("Nuclear");
        }

        public override void OneDayOfTravel()
        {
            fuel.Amount -= 10;
            nuclearWaste.Amount += 1;
            CheckSupplies();
        }

        public override double Refill(double amount)
        {
            fuel.Amount += amount;
            double cost = 25.0 * amount + 10.0 * nuclearWaste.Amount;
            nuclearWaste.Amount = 0;
            return cost;
        }

        public override void CheckSupplies()
        {
            fuel.HowMuchLeft();
            nuclearWaste.HowMuchLeft();
        }
    }
}