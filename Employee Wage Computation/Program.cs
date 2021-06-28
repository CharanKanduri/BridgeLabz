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
            int employeePartTime = 2;
            int employeeStatus;
            int wagePerHour = 20;
            Random random = new Random();
            employeeStatus = random.Next(0, 3);

            switch (employeeStatus)
            {
                case 1:
                    Console.WriteLine("Employee Present");
                    Console.WriteLine("Total wage is: " + wagePerHour * 8);
                    break;
                case 0:
                    Console.WriteLine("Employee Absent");
                    break;
                case 2:
                    Console.WriteLine("Employee works part-time");
                    Console.WriteLine("Total wage is: " + wagePerHour * 4);
                    break;
            }


        }
    }
}
