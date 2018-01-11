using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryApplication
{
    class Salary
    {
        public double employeeBasicSalary;

        public double medicalAllownceOnBasic;

        public double conveyanceOnBasic;

        public int numberOfIncrement = 0;

        public double TotalSalary()
        {
            double total = employeeBasicSalary + MedicalAmountOnBasic() + ConveyanceAmountOnBasic();

            return total;
        }

        public double MedicalAmountOnBasic()
        {
            double medicalAmount = employeeBasicSalary * (medicalAllownceOnBasic / 100);

            return medicalAmount;
        }

        public double ConveyanceAmountOnBasic()
        {

            double conveyanceAmount = employeeBasicSalary * (conveyanceOnBasic / 100);

            return conveyanceAmount;

        }

        public void IncrementOnBasic(double incrementValue)
        {

            employeeBasicSalary += employeeBasicSalary * (incrementValue / 100);

            numberOfIncrement++;
        }
    }
}
