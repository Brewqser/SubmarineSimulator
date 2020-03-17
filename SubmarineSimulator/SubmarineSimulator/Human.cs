using System;
using System.Collections.Generic;
using System.Text;

namespace SubmarineSimulator
{
    public abstract class Human
    {
        public static double MedianSalary = 100;
        private System.Random random;

        public Human(double s)
        {
            throw new System.NotImplementedException();
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