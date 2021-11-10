using System;

namespace EmpWages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage Computation problem");
            EmployeeComputation employee = new EmployeeComputation();
            employee.MonthlyEmployeeWage();
            

        }
    }
}
