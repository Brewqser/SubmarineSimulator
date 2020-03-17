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
            throw new System.NotImplementedException();
        }

        public int TotalNumber
        {
            get => default;
            set
            {
            }
        }

        public void Conserve()
        {
            throw new NotImplementedException();
        }

        public string NextDestination()
        {
            throw new System.NotImplementedException();
        }

        public int DaysToNextDestination()
        {
            throw new System.NotImplementedException();
        }

        public void Arrived()
        {
            throw new System.NotImplementedException();
        }

        public void AddPort(string name, int days)
        {
            throw new System.NotImplementedException();
        }
    }
}