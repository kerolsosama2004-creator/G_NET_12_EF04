using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_EF04
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string BranchCode { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public int ManagerId { get; set; }
        public Manager Manager { get; set; }

        public ICollection<Account> Accounts { get; set; }
        
           
        }
}
