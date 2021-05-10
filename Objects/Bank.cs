using System;
using System.Collections.Generic;

namespace TestSolution.Objects
{
    public class Bank
    {
        private string _name;
        private List<Customer> _customers = new List<Customer>();

        /**
         * Constructor
         */
        public Bank(string name)
        {
            Name = name;
        }

        /**
         * Getters & Setters
         */
        
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public List<Customer> Customers
        {
            get => _customers;
        }

        /**
         * Methods
         */
        
        /*
         * Creates a customer
         */
        public Customer CreateCustomer(string name, string type)
        {
            Customer cus = new Customer(name, type);
            Customers.Add(cus);
            return cus;
        }
    }
}