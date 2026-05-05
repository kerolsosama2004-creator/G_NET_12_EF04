using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_EF04
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public AccountType AccountType { get; set; }
        public DateTime OpeningDate { get; set; }
        public decimal Balance { get; set; }

        public int BranchId { get; set; }
        public Branch Branch { get; set; }

        public ICollection<CustomerAccount> CustomerAccounts { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
