using System;

namespace Employee_Wage_Computation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using Main Method only for Input calculation

            Console.WriteLine("Welcome to employee wage computation");

           
            Console.WriteLine("Enter Company Name");
            string companyName = Console.ReadLine();
            Console.WriteLine("Enter wage per hour");
            int wageperHour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter total number of days");
            int totalDays = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter maximum hours");
            int totalHour = Convert.ToInt32(Console.ReadLine());
            WageComputation (companyName,wageperHour,totalDays,totalHour);


            int employeePresent = 1;
            int employeeAbsent = 0;
            int employeeStatus;

        }
        public static void WageComputation(string companyName, int wageperHour, int totalDays, int totalHour)
        {
            int workingDays = 0, hours = 0, dailyWage = 0, totalWage = 0, workingHour = 0;

            //Creating object for Random class

            Random random = new Random();


            if (employeeStatus == employeePresent)
            {
                Console.WriteLine("Employee Present");
            }
            else 
            {
                Console.WriteLine("Employee Absent");
            }

            
            while (workingDays <= totalDays && hours <= totalHour)
            {
                
                int Attendance = random.Next(0, 3);
               
                switch (Attendance)
                {
                    case 1:   
                        hours = 8;
                        break;
                    case 2:
                      
                        hours = 4;
                        break;
                    default:
                         
                        break;


                }
                //Calculation
                dailyWage = hours * wageperHour;
                totalWage += dailyWage;
                workingHour += hours;
                if (Attendance != 0)
                {
                    workingDays++;
                }
            }
            //Print all Details
            Console.WriteLine("Company Name:" + companyName);
            Console.WriteLine("Working Hours :" + workingHour);
            Console.WriteLine("Employee Wage Per day :" + dailyWage);
            Console.WriteLine("Working days in a month :" + workingDays);
            Console.WriteLine("Employee Wage for 20 working days :" + totalWage);
            Console.WriteLine("\n");
        }
        
    }
}

