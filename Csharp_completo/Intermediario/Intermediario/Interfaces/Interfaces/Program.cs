using System.Globalization;
using Interfaces.Entities;
using Interfaces.Services;

namespace Interfaces
{
    class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine().Trim());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine().Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Enter contract value: ");
            double contractValue = double.Parse(Console.ReadLine().Trim());
            Console.Write("Enter number of installments: ");
            int installmentsNumber = int.Parse(Console.ReadLine().Trim());

            Contract contract = new Contract(number, date, contractValue);
            ContractService contractService = new ContractService(new PayPalService());

            contractService.ProcessContract(contract, installmentsNumber);

            foreach (Installment installment in contract.installments)
            {
                Console.WriteLine(installment);
            }
        }

    }
}