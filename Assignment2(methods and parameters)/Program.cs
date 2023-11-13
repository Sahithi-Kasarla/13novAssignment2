using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    internal class Program
    {
        static void CalculateSalaryForHR(int workingHours = 0, int numOfWorkingDays = 0)
        {
            int projectHandles = 1;
            int extras = 0;

            int salary = CalculateSalary(workingHours, numOfWorkingDays, projectHandles, extras);
            Console.WriteLine($"Monthly Salary for HR: {salary}");
        }
        static void CalculateSalaryForAdmin(int workingHours = 0, int numOfWorkingDays = 0, int projectHandles = 0)
        {
            int extras = 0;

            int salary = CalculateSalary(workingHours, numOfWorkingDays, projectHandles, extras);
            Console.WriteLine($"Monthly Salary for Admin: {salary}");
        }

        static void CalculateSalaryForSoftwareDeveloper(int workingHours = 0, int numOfWorkingDays = 0, int projectHandles = 0, int extras = 0)
        {
            int salary = CalculateSalary(workingHours, numOfWorkingDays, projectHandles, extras);
            Console.WriteLine($"Monthly Salary for Software Developer: {salary}");
        }

        static int CalculateSalary(int workingHours, int numOfWorkingDays, int projectHandles, int extras)
        {
            int salary = workingHours * numOfWorkingDays * 100 + projectHandles * 3000 + extras * 2000;
            return salary;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Salary Calculation System");

            Console.WriteLine("Choose Employee Type:");
            Console.WriteLine("1. HR");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Software Developer");


            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CalculateSalaryForHR();
                    break;
                case 2:
                    CalculateSalaryForAdmin();
                    break;
                case 3:
                    CalculateSalaryForSoftwareDeveloper();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            Console.ReadKey();
        }
    }
}