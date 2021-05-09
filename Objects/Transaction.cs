using System;

namespace TestSolution.Objects
{
    public class Transaction
    {
        private string _id = Guid.NewGuid().ToString();
        private string _message;
        private double _amount;

        /**
         * Constructor
         */
        public Transaction(string message, double amount)
        {
            Message = message;
            Amount = amount;
        }

        /**
         * Getters & Setters
         */
        
        public string Id
        {
            get => _id;
        }

        public string Message
        {
            get => _message;
            set => _message = value;
        }

        public double Amount
        {
            get => _amount;
            set => _amount = value;
        }
    }
}