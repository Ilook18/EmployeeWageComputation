using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWages
{
    class EmployeeComputation
    {
        public const int is_Present = 1, WAGE_PER_HOUR = 20, FULL_WORKING_HOURS = 8;
        int totalEmpWage;
        public void DailyEmployeeWage()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == is_Present)
            {
                this.totalEmpWage = FULL_WORKING_HOURS * WAGE_PER_HOUR;
                Console.WriteLine("employee present" + this.totalEmpWage);
            }

            else
                Console.WriteLine("employee Absent");

        }

    }
}

