using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWages
{
    class EmployeeComputation
    {
        public const int is_Present = 1;
        public void EmployeeAttendence()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == is_Present)
                Console.WriteLine("employee present");
            else
                Console.WriteLine("employee Absent");

        }

    }
}

