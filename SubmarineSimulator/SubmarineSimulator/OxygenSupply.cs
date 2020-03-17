using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    public class OxygenSupply : IStorable
    {
        public OxygenSupply(double capcity)
        {
            throw new System.NotImplementedException();
        }

        public double MaxCapacity
        {
            get => default;
            set
            {
            }
        }

        public double Amount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void HowMuchLeft()
        {
            throw new NotImplementedException();
        }
    }
}