using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advancedProgramming
{
    public enum MartialStatue { Single = 0, Married = 1 }

    abstract class personal 
    {
        public double BaseSalary = 2000;
        public double SalaryFactor = 10;

        public abstract double CalculateSalary(MartialStatue martialStatue, int numberOfChild, int step, int degree);


        public virtual string PersonelGroup()
        {
            return ("Personel Type");
        }
     }
}
