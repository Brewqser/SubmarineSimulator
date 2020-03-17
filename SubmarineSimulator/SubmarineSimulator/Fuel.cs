using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    public class Fuel : IStorable
    {
        public double Amount { get; set; }

        public void HowMuchLeft()
        {
            Console.WriteLine("Fuel supply: " + Amount);
        }
    }
}