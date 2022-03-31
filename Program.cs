using System;


namespace assignment_7
{

    public class Customer
    {
        public string CustomerId { get; set; }
        public string City { get; set; }
        public Customer(string cid, string city)
        {
            this.CustomerId = cid;
            this.City = city;
        }
        public override string ToString()
        {
            return CustomerId + "\t" + City;
        }
    }
    class Program
    {


        static void Main(string[] args)
        {

            List<Customer> customerlist = new List<Customer>();
            customerlist.Add(new Customer("ACSE1", "London"));
            customerlist.Add(new Customer("BCSE2", "Surat"));
            customerlist.Add(new Customer("ZUI8U", "London"));
            customerlist.Add(new Customer("IUI8Y", "Baroda"));
            customerlist.Add(new Customer("ACSE5", "Banglore"));
            customerlist.Add(new Customer("ACSE6", "Mumbai"));
            customerlist.Add(new Customer("FHT6E", "London"));
            customerlist.Add(new Customer("LOP0R", "Delhi"));
            customerlist.Add(new Customer("OIU7R", "London"));

            var custQuery1 =
                from customer in customerlist
                where customer.City == "London"
                select customer;
            Console.WriteLine("\nCustomers who live in London : ");

            foreach (Customer cust in custQuery1)
            {
                Console.WriteLine(cust);
            }

            var custQuery2 =
                   (from customer in customerlist
                    select customer).Count();
            Console.Write("\nTotal number of customers :  ");
            Console.Write(custQuery2 + "\n");

            var custQuery3 =
                     from customer in customerlist
                     where customer.CustomerId.Substring(0, 1) == "A"
                     select customer;
            Console.WriteLine("\nCustomers whose CID starts with 'A' : ");

            foreach (Customer cust in custQuery3)
            {
                Console.WriteLine(cust);
            }
            Console.WriteLine("\n");
        }
    }
}