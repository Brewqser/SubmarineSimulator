using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    public class OxygenSupply : IStorable
    {
        public OxygenSupply(double capcity)
        {
            MaxCapacity = capcity;
        }

        public double MaxCapacity { get; set; }

        public double Amount { get; set; }

        public void HowMuchLeft()
        {
            Console.WriteLine("Oxygen supply: " + Amount);
        }
    }
}