using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseFlow.Entity
{
    public class Transaction
    {
        #region Fields

        private int transactionId;
        private int userId;
        private int categoryId;
        private decimal amount;
        private DateTime transactionDate;
        private string description;

        #endregion

        #region Constructors

        //public Transaction()
        //{
        //}

        public Transaction(int transactionId, int userId, int categoryId, decimal amount, DateTime transactionDate, string description)
        {
            TransactionId = transactionId;
            UserId = userId;
            CategoryId = categoryId;
            Amount = amount;
            TransactionDate = transactionDate;
            Description = description;
        }

        #endregion

        #region Properties

        public int TransactionId { get => transactionId; set => transactionId = value; }
        public int UserId { get => userId; set => userId = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }
        public decimal Amount { get => amount; set => amount = value; }
        public DateTime TransactionDate { get => transactionDate; set => transactionDate = value; }
        public string Description { get => description; set => description = value; }

        #endregion
    }
}
