using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    public class ScientificProbe : ITool
    {
        public void Conserve()
        {
            Console.WriteLine("Scientific probe ready");
        }

        public void GatherData()
        {
            Console.WriteLine("Gathering data...");
        }
    }
}