using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab_43_entity
{
    class Program
    {

        static List<Customer> customerList;  // all 
        static Customer customer;            // one
        static Customer newCustomer;         // add new




























        static List<Customer> customers;


























        static Customer customerToUpdate;
        static Customer findOneCustomer;

        static void Main(string[] args)
        {

            // automatically clean up database connection when done
            using (var db = new NorthwindEntities())
            {
                var customers = db.Customers.ToList();

                foreach(var customer in customers)
                {
                    Console.WriteLine(customer.CustomerID);
                }

                foreach (var c in customers)
                {
                    Console.WriteLine($"ID is {c.CustomerID}, name is {c.ContactName}");
                }

                // update one customer
                //                all customers where  (just select the one with right id) . just choose first
                customerToUpdate = db.Customers.Where(cust => cust.CustomerID == "Phil1").FirstOrDefault();
                customerToUpdate.City = "PhilsCity";
                db.SaveChanges();




            }

            using (var db = new NorthwindEntities()) {
                findOneCustomer =
                    // select all customers in db.Customers
                    (from cust in db.Customers
                     // just choose this one only
                     where cust.CustomerID == "Phil1"
                     // select that one customer
                     select cust).FirstOrDefault();
                Console.WriteLine($"\n\nUpdated customer has new city = {findOneCustomer.City}");
            }

            try { // contact database
            }
            catch { // any errors
            }
            finally { // close database
            }










            // encapsulates database for easy cleanup afterwards
            using(var db = new NorthwindEntities())
            {
                // standard LINQ query
                customerList =
                    (from c in db.Customers
                     select c).ToList<Customer>();

                foreach(Customer c in customerList)
                {
                    Console.WriteLine($"ID : {c.CustomerID}, " +
                        $"Name : {c.ContactName}, City : {c.City}");
                }

                // select one customer and update
                customer = db.Customers.Where(cust => cust.CustomerID == "FRANK").FirstOrDefault();
                customer.City = "BERLIN";
                db.SaveChanges();

            }

            // check if the update has worked : query database from scratch again
            using (var db = new NorthwindEntities())
            {
                foreach (Customer c in db.Customers)
                {
                    Console.WriteLine($"ID : {c.CustomerID}, " +
                        $"Name : {c.ContactName}, City : {c.City}");
                }

                // LINQ LAMBDA QUERY
                customer = db.Customers.Where(cust => cust.CustomerID == "FRANK").FirstOrDefault();
                Console.WriteLine($"{customer.CustomerID}, {customer.ContactName},{customer.City}");

                // LINQ STANDARD
                customer =
                    (from cust in db.Customers
                     where cust.CustomerID == "FRANK"
                     select cust).FirstOrDefault();
                Console.WriteLine($"{customer.CustomerID}, {customer.ContactName},{customer.City}");
            }

            // insert new
            using (var db = new NorthwindEntities())
            {
                newCustomer = new Customer(){
                    CustomerID="Phil6",
                    ContactName ="Bob",
                    CompanyName="SpartaGlobal",
                    City="London"
                };
                db.Customers.Add(newCustomer);
                db.SaveChanges();
            }

            // query 
            using (var db = new NorthwindEntities())
            {
                customer = db.Customers.Where(cust => 
                    cust.CustomerID == "Phil6").FirstOrDefault();
                Console.WriteLine($"Creating new record : {customer.CustomerID}, " +
                    $"{customer.ContactName},{customer.City}");
                
            }

            // delete this new record
            using (var db = new NorthwindEntities())
            {
                // select customer
                customer = db.Customers.Where(cust =>
                    cust.CustomerID == "Phil6").FirstOrDefault();
                // delete customer
                db.Customers.Remove(customer);  // deleting local copy of this customer
                Console.WriteLine("deleting Phil6");
                db.SaveChanges();               // commiting deletion to the database
            }

            // query 
            using (var db = new NorthwindEntities())
            {
                customer = db.Customers.Where(cust =>
                    cust.CustomerID == "Phil6").FirstOrDefault();
                if (customer!=null)
                {
                    Console.WriteLine($"{customer.CustomerID}, " +
                        $"{customer.ContactName},{customer.City}");
                }
                else
                {
                    Console.WriteLine($"Customer Phil6 does not exist");
                }


            }








           
            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList();

                foreach(var customer in customers)
                {
                    // ListBox01.Items.Add(customer.ContactName);
                }

                // ListBox02.ItemsSource = db.Customers.ToList();
            }











































        }
    }
}
