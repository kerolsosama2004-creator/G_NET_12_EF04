using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_EF04
{
    public class Manager
    {
        public int ManagerId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime HireDate { get; set; }

        public Branch Branch { get; set; }
    }
}
