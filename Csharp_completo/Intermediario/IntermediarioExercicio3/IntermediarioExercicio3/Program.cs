using IntermediarioExercicio3.Entities;

namespace IntermediarioExercicio3
{
   class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many employees will get data readed?");
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter employee #{i+1} data:");
                Console.Write("Outsorced (y/n)? ");
                char outsorced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (outsorced == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());

                    Employee outsorcedEmployee = new OutsorcedEmployee(name, hours, valuePerHour, additionalCharge);
                    employees.Add(outsorcedEmployee);
                    continue;
                }

                Employee employee = new Employee(name, hours, valuePerHour);
                employees.Add(employee);
            }

            Console.WriteLine("PAYEMENTS:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}