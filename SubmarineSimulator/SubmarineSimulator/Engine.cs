using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    public abstract class Engine
    {
        protected Fuel fuel;

        public Engine()
        {
            fuel = new Fuel();
        }

        public virtual void CheckSupplies()
        {
            fuel.HowMuchLeft();
        }

        public abstract void OneDayOfTravel();

        public abstract double Refill(double amount);
    }
}