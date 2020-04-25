using System.Globalization;
using System;
using ContaBancaria.Entity;
using ContaBancaria.Entity.Exceptions;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");
            Console.WriteLine("Numer oda Conta");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome do Proprietario: ");
            String prop = Console.ReadLine();
            Console.WriteLine("Entre com deposito inicial: ");
            double balace = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com limite inicial: ");
            double limite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account acc = new Account(number, prop, balace, limite);
            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                acc.withdraw(amount);
                Console.WriteLine("New balance: " + acc.balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}
