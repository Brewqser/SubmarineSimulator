using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    public class Waste : IStorable
    {
        private int name;

        public Waste(string s)
        {
            throw new System.NotImplementedException();
        }

        public int Amount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void HowMuchLeft()
        {
            throw new NotImplementedException();
        }
    }
}