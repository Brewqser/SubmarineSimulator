using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    public class Waste : IStorable
    {
        private string name;

        public Waste(string s)
        {
            name = s;
        }

        public double Amount { get; set; }

        public void HowMuchLeft()
        {
            Console.WriteLine(name + " waste stored: " + Amount);
        }
    }
}