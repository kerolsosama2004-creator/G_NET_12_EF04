using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_EF04
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
        public TransactionType TransactionType { get; set; }
        public string Description { get; set; }

        public string AccountNumber { get; set; }
        public Account Account { get; set; }
    }
}
