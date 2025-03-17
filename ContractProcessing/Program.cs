using System.Globalization;
using ContractProcessing.Entities;
using ContractProcessing.Services;

namespace ContractProcessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");
            Console.Write("Number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int ins = int.Parse(Console.ReadLine());

            Contract contract = new Contract(n, date, totalValue);

            ContractService contractService = new ContractService(new PayPalService());
            Console.WriteLine("Installments: ");

            contractService.ProcessContract(contract, ins); 
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
