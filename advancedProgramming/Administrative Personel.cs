using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advancedProgramming
{
    class Administrative_Personel : personal
    {
        public bool hasAdmin;
        public bool hasadmin
        {
            get
            {
                return hasAdmin;
            }
            set
            {
                hasAdmin = value;
            }
        }
        public override string PersonelGroup()
        {
            return ("Administrative Personel");
        }
        public override double CalculateSalary(MartialStatue martialStatue, int numberOfChild, int step, int degree)
        {

            if (martialStatue == MartialStatue.Married) SalaryFactor += 1;
            if (numberOfChild == 1) SalaryFactor += 1;
            if (numberOfChild > 1) SalaryFactor = SalaryFactor + (numberOfChild * 0.75);
            if (hasadmin) SalaryFactor += 1.5;
            double Salary = (BaseSalary * SalaryFactor) + (5 * step) + (10 * degree);

            return Salary;


        }
    }
}
