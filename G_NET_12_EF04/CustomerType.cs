using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_EF04
{
    public enum CustomerType
    {
        Individual,
        Business
    }

    public enum AccountType
    {
        Savings,
        Current,
        Business
    }

    public enum OwnershipType
    {
        Primary,
        CoHolder
    }

    public enum AccountStatus
    {
        Active,
        Closed
    }

    public enum TransactionType
    {
        Deposit,
        Withdrawal,
        Transfer,
        Payment
    }

}
