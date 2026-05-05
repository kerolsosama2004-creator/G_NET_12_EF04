namespace G_NET_12_EF04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region G_NET_12_EF04 Assignment

            //while (true)
            //{
            //    Console.Clear();
            //    Console.WriteLine("1) Add Customer");
            //    Console.WriteLine("2) Open Account");
            //    Console.WriteLine("3) Update Account Status");
            //    Console.WriteLine("4) Remove Account from Customer");
            //    Console.WriteLine("5) List Customers");
            //    Console.WriteLine("0) Exit");

            //    var choice = Console.ReadLine();

            //    switch (choice)
            //    {
            //        case "1": AddCustomer(); break;
            //        case "2": OpenAccount(); break;
            //        case "3": UpdateStatus(); break;
            //        case "4": RemoveAccount(); break;
            //        case "5": ListCustomers(); break;
            //        case "0": return;
            //        default:
            //            Console.WriteLine("Invalid choice!");
            //            break;
            //    }

            //    Console.WriteLine("Press any key...");
            //    Console.ReadKey();
            //}


            //void AddCustomer()
            //{
            //    using var db = new BankDbContext();

            //    Console.Write("Full Name: ");
            //    var name = Console.ReadLine();

            //    Console.Write("National ID: ");
            //    var nid = Console.ReadLine();

            //    var customer = new Customer
            //    {
            //        FullName = name,
            //        NationalId = nid,
            //        DateOfBirth = DateTime.Now,
            //        CustomerType = CustomerType.Individual
            //    };

            //    db.Customers.Add(customer);
            //    db.SaveChanges();

            //    Console.WriteLine($"Customer created ID = {customer.CustomerId}");
            //}


            #endregion
        }
    }
}
