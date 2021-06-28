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
            int day = 1;
            int monthlyWage = 0;
            int maximumDays = 20;

            int wagePerHour = 20;
            Random random = new Random();
            employeeStatus = random.Next(0, 3);

            switch (employeeStatus)
            {
                case 1:
                    Console.WriteLine("Full time- Employee Present");
                    for (day = 1; day <=maximumDays; day++)
                    {
                        monthlyWage= monthlyWage +(wagePerHour*8);
                    }
                    Console.WriteLine("Total wage for month is:"+monthlyWage);

                    break;
                case 0:
                    Console.WriteLine("Employee Absent");
                    break;
                case 2:
                    Console.WriteLine("part time- Employee Present");
                    for (day = 1; day <= maximumDays; day++)
                    {
                        monthlyWage = monthlyWage + (wagePerHour * 4);
                    }
                    Console.WriteLine("Total wage for month is: " + monthlyWage);
                    break;
            }


        }
    }
}
