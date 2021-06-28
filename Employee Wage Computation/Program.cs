using System;

namespace Employee_Wage_Computation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO EMPLOYEE WAGE COMPUTATION");


            //U1: Check Employee is Present or Absent using Random

            int employeePresent = 1;
            int employeeAbsent = 0;
            int employeeStatus;
            Random random = new Random();
            employeeStatus = random.Next(0, 2);

            if (employeeStatus == employeePresent)
            {
                Console.WriteLine("Employee Present");
            }
            else 
            {
                Console.WriteLine("Employee Absent");
            }

        }
    }
}

