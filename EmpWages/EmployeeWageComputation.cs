using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWages
{
    class EmployeeComputation
    {
        public const int IS_FULL_TIME = 1, IS_PART_TIME = 2, WAGE_PER_HOUR = 20, FULL_WORKING_HOURS = 8, PART_TIME_HRS = 4, WORKING_DAYS = 20;
        int totalEmpWage, empHrs;
        public void MonthlyEmployeeWage()
        {
            Random random = new Random();

            for (int i = 0; i < WORKING_DAYS; i++)
            {
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        this.empHrs += FULL_WORKING_HOURS;
                        break;
                    case IS_PART_TIME:
                        this.empHrs += PART_TIME_HRS;
                        break;
                    default:
                        this.empHrs += 0;
                        break;
                }

            }
            this.totalEmpWage = this.empHrs * WAGE_PER_HOUR;
            Console.WriteLine(this.totalEmpWage);
        }

    }
}

