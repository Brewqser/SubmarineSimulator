using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    public class NavigationPanel : ITool
    {
        private int currentNumber;
        private List<Destination> ports;
        private List<int> travelDays;

        public NavigationPanel()
        {
            ports = new List<Destination>();
            travelDays = new List<int>();
            currentNumber = 0;
            TotalNumber = 0;
        }

        public int TotalNumber { get; set; }

        public void Conserve()
        {
            Console.WriteLine("Navigation panel ready");
        }

        public string NextDestination()
        {
            return ports[currentNumber].Name;
        }

        public int DaysToNextDestination()
        {
            return travelDays[currentNumber];
        }

        public void Arrived()
        {
            currentNumber++;
        }

        public void AddPort(string name, int days)
        {
            ports.Add(new Destination(name));
            travelDays.Add(days);
            TotalNumber++;
        }
    }
}