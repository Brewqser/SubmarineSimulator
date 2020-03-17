using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    public class Fuel : IStorable
    {
        public int Amount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void HowMuchLeft()
        {
            throw new NotImplementedException();
        }
    }
}