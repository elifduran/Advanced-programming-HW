using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advancedProgramming
{

    class Academic_Personel: personal
    {
        public int Coefficient;
        public int coefficient
        {
            get
            {
                return Coefficient;
            }
            set
            {
                Coefficient = value;
            }
        }
        public override string PersonelGroup()
        {
            return ("Academic Personel");
        }
        public override double CalculateSalary(MartialStatue martialStatue, int numberOfChild, int step, int degree)
        {

            if (martialStatue == MartialStatue.Married) SalaryFactor += 1;
            if (numberOfChild == 1) SalaryFactor += 1;
            if (numberOfChild > 1) SalaryFactor = SalaryFactor + (numberOfChild * 0.75);
            if (coefficient > 0) SalaryFactor += coefficient * 0.65;
            double Salary = (BaseSalary * SalaryFactor) + (10 * step) + (15 * degree);

            return Salary;


        }
    }
}
