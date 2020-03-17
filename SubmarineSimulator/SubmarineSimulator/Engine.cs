using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    public abstract class Engine
    {
        private Fuel fuel;

        public Engine()
        {
            throw new System.NotImplementedException();
        }

        public void CheckSupplies()
        {
            throw new System.NotImplementedException();
        }

        public abstract void OneDayOfTravel();

        public abstract double Refill(double amount);
    }
}