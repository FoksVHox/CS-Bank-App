using System.Collections.Generic;

namespace TestSolution.Objects
{
    public class Customer
    {
        private string _name;
        private string _type;
        private List<Account> _accounts = new List<Account>();
        
        /**
         * Constructor
         */
        public Customer(string name, string type)
        {
            Name = name;
            Type = type;
        }

        /**
         * Getters & Setters
         */
        
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Type
        {
            get => _type;
            set => _type = value;
        }

        public List<Account> Accounts
        {
            get => _accounts;
        }
        
        /**
         * Methods
         */
        
        
        /*
         * Creates an account for a customer.
         */
        public Account createAccount(Customer cus, string type)
        {
            Account acc = new Account(cus, type);
            Accounts.Add(acc);
            return acc;
        }
    }
}