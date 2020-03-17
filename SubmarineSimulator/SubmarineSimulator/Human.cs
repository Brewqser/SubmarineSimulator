using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    public abstract class Human
    {
        public static double MedianSalary = 100.0;
        private Random random;

        public Human(double s)
        {
            this.Salary = s;
            random = new Random((int)DateTime.Now.Ticks);
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
            return (int)(random.NextDouble() * 1000);
        }

        public double Eat()
        {
            return (int)(random.NextDouble() * 5);
        }
    }
}