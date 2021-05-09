using System;
using System.Collections.Generic;
using TestSolution.Objects;

namespace TestSolution
{
    class Program
    {
        private static List<Bank> Banks = new List<Bank>();
        
        static void Main()
        {
            Bank bank = createBank("TestCorp Banking");
            Customer cus = bank.createCustomer("Test", "Individual");
            Account acc = cus.createAccount(cus, "Pension");
            Transaction t = acc.createTransaction("test transaction", 20.78);
            
            
            Console.WriteLine("Bank name: "+bank.Name);
            Console.WriteLine("Customer type: "+cus.Type);
            Console.WriteLine("Customer name: "+cus.Name);
            Console.WriteLine("Account name: "+acc.Name);
            Console.WriteLine("Account ID: "+acc.ID);
            Console.WriteLine("Account Type: "+acc.Type);
            Console.WriteLine("Account Balance: "+acc.Balance);
            Console.WriteLine("Transaction message: "+t.Message);
            Console.WriteLine("Transaction Amount: "+t.Amount);
            Console.WriteLine("Transaction ID: " + t.Id);
            Transaction t1 = acc.createTransaction("test transaction", -40.83);
            Console.WriteLine("New Account Balance: "+acc.Balance);
        }

        /*
         * Creates a bank
         */
        static Bank createBank(string name)
        {
            Bank bank = new Bank(name);
            Banks.Add(bank);
            return bank;
        }
    }
}