using System;
using System.Collections.Generic;

namespace TestSolution.Objects
{
    public class Account
    {
        private int _id;
        private string _name;
        private string _type;
        private List<Transaction> _transactions = new List<Transaction>();
        private Customer _customer;
        private double _balance = 0.0;
        
        /*
         * Constructor 
         */
        public Account(Customer c, string type)
        {
            Random accNumber = new Random();
            int safeAccNumber = accNumber.Next(100000, 999999);
            Customer = c;
            Name = "Account #" +safeAccNumber;
            ID = safeAccNumber;
            Type = type;
        }

        /**
         * Getters & Setters
         */
        
        public int ID
        {
            get => _id;
            set => _id = value;
        }
        
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public List<Transaction> Transactions
        {
            get => _transactions;
        }

        public string Type
        {
            get => _type;
            set => _type = value;
        }
        
        public Customer Customer
        {
            get => _customer;
            set => _customer = value;
        }

        public double Balance
        {
            get => _balance;
            set => _balance = value;
        }

        /**
         * Methods
         */

        
        /*
         * Creates a transaction, and 
         */
        public Transaction CreateTransaction(string message, double amount)
        {
            Transaction transaction = new Transaction(message, amount);
            Transactions.Add(transaction);
            Balance = Balance + amount;
            return transaction;
        }
        
        /*
         * Creates a transfer and addeds the money to the other account.
         */
        public Transaction[] CreateTransfer(Account from, Account to, double amount)
        {
            Transaction fromTransaction = from.CreateTransaction("Money transfer to "+to.Name, -amount);
            Transaction toTransaction = to.CreateTransaction("Money transfer from "+from.Name, amount);
            
            Transaction[] transactions = {fromTransaction, toTransaction};
            return transactions;
        }
    }
}