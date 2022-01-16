using System;
using System.Collections.Generic;
using System.Text;

namespace UseCaseThree
{
     class UseCase3
    {
        const int Is_Full_Time = 1;
        const int Emp_Rate_Per_Hour = 10;
        const int Is_Part_Time = 2;
        public void EmpWage3()
        {
            int empHrs = 0;
            int empWage = 0;
            Random randomNumber = new Random();
            int checkingNum = randomNumber.Next(0, 2);
            if (checkingNum == Is_Full_Time)
            {
                Console.WriteLine("Emp present FullTime");
                empHrs = 8;
            }
            else if (checkingNum ==Is_Part_Time)
            {
                empHrs = 4;
                Console.WriteLine("Emp present partTime");
            }
            else
            {
                Console.WriteLine("Emp is absent");
                empHrs = 0;

            }
            empWage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Emp Wage: " + empWage);
        }
        static void Main(string[] args)
        {
            UseCase3 use3 = new UseCase3();
            use3.EmpWage3();


        }
    }
   
}

