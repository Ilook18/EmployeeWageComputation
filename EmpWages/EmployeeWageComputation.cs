using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWages
{
    class EmployeeComputation
    {
        public const int IS_FULL_TIME = 1, IS_PART_TIME = 2, WAGE_PER_HOUR = 20, FULL_WORKING_HOURS = 8, PART_TIME_HRS = 4;
        int totalEmpWage, empHrs;
        public void FULL_TIME_PART_TIME()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_FULL_TIME)
            {
                this.empHrs = FULL_WORKING_HOURS;

            }
            if (empCheck == IS_PART_TIME)
            {
                this.empHrs = PART_TIME_HRS;
            }

            else
            {
                this.empHrs = 0;
            }
            this.totalEmpWage = this.empHrs * WAGE_PER_HOUR;

        }

    }
}

