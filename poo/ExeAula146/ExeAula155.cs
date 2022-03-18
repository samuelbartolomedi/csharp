using System;
using ExeAula146.Entities;
using ExeAula146.Entities.Exceptions;

namespace ExeAula146
{
    class ExeAula155
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number? ");
            int accountNumber = int.Parse(Console.ReadLine());
            Console.Write("Holder? ");
            String holder = Console.ReadLine();
            Console.Write("Initial balance? ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw limit? ");
            double withdrawLimit = double.Parse(Console.ReadLine());

            Account account = new Account(accountNumber, holder, balance, withdrawLimit);

            Console.WriteLine();
            Console.Write("Enter amount to withdraw: ");
            double amount = double.Parse(Console.ReadLine());
            try
            {
                account.Withdraw(amount);
                Console.WriteLine("New balance: " + account.Balance.ToString("F2"));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Can't complete withdraw: " + e.Message);
            }
        }
    }
}
