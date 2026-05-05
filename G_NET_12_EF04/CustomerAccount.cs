using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_EF04
{
    public class CustomerAccount
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public string AccountNumber { get; set; }
        public Account Account { get; set; }

        public DateTime OwnershipStartDate { get; set; }
        public OwnershipType OwnershipType { get; set; }
        public AccountStatus Status { get; set; }
    }
}
