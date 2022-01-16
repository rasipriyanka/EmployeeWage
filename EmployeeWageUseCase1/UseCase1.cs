using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageUseCases
{
    public class UseCase1
    {
        public void EmpUse()
        {
            const int Is_Full_Time = 1;
            Random randomNumber = new Random();
            int checkingNum = randomNumber.Next(0, 2);
            if (checkingNum == Is_Full_Time)
            {
                Console.WriteLine("Emp is present");
            }
            else
            {
                Console.WriteLine("Emp is absent");

            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            UseCase1 use = new UseCase1();
            use.EmpUse();
        }


    }
}
