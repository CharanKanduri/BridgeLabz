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
            int wagePerHour = 20;
            Random random = new Random();
            employeeStatus = random.Next(0, 2);

            if (employeeStatus == employeePresent)
            {
                Console.WriteLine("Employee Present");
                Console.WriteLine("Total wage is: "+ wagePerHour*8);
            }
            else 
            {
                Console.WriteLine("Employee Absent");
            }

        }
    }
}
