using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    public abstract class Human
    {
        public static double MedianSalary = 100;
        private Random rnd = new Random((int) DateTime.Now.Ticks);

        public Human(double s)
        {
            this.Salary = s;
        }

        public double Salary
        {
            get => default;
            set
            {
            }
        }

        public int Breathe()
        {
            throw new System.NotImplementedException();
        }

        public double Eat()
        {
            throw new System.NotImplementedException();
        }
    }
}