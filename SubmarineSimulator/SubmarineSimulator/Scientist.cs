using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    public class Scientist : Human
    {
        public Scientist(double s) : base (s)
        {

        }

        public ScientificProbe myProbe { get; set; }

        public void Work()
        {
            myProbe.GatherData();
        }
    }
}