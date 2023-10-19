using System;
using System.Globalization;
using Intermediario.Entities;
using Intermediario.Entities.Enums;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Department Name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter Worker data: ");
            Console.Write("\tWorker name: ");
            string name = Console.ReadLine();
            Console.Write("\tLevel (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("\tBase Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, department);

            Console.WriteLine();
            Console.Write("How many contracts to this worker? ");
            int numberContracts = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberContracts; i++)
            {
                Console.WriteLine($"Enter contract #{i+1} data: ");
                Console.Write("\tDate (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("\tValue per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("\tDuration (Hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine($"Income for {monthAndYear}: " + worker.Income(year, month));

        }
    }
}