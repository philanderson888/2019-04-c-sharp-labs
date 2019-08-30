using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace lab_61_raw_sql
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();

        static void Main(string[] args)
        {
            using (var connection = new SqlConnection(@"Data Source=localhost;
                    Initial Catalog=Northwind;Persist Security Info=True;
                    User ID=SA;Password=Passw0rd2018"))
            {
                connection.Open();
                Console.WriteLine(connection.State);

                // add new customer 

                var newCustomer = new Customer("Blog1","Company1","JoeBloggs1","");

                var newCustomer2 = new Customer()
                {
                    CustomerID = "Blog2",
                    CompanyName = "Company2",
                    ContactName = "JoeBloggs2"
                };

                string SQLInsert = "Insert into Customers (CustomerID,CompanyName,ContactName) values " +
                    $"('{newCustomer.CustomerID}','{newCustomer.CompanyName}','{newCustomer.ContactName}')";

                string SQLInsert2 = "Insert into Customers (CustomerID,CompanyName,ContactName) values " +
                    "('Blog5','JoeBloggs5','Company5')";

                Console.WriteLine(SQLInsert);
                Console.WriteLine(SQLInsert2);

                using (var command = new SqlCommand(SQLInsert, connection))
                {
                    int affected = command.ExecuteNonQuery();
                    Console.WriteLine("Insert : Number of records added : " + affected);
                }



                // update one customer

                string SQLUpdate = $"Update Customers Set City='Berlin' where CustomerID='{newCustomer.CustomerID}'";

                Console.WriteLine(SQLUpdate);

                using (var command = new SqlCommand(SQLUpdate, connection))
                {
                    int affected = command.ExecuteNonQuery();
                    Console.WriteLine("Update : Number of records added : " + affected);
                }

                // read customers 

                string SQLSelect = $"Select * from Customers where CustomerID='{newCustomer.CustomerID}'";

                using (var command = new SqlCommand(SQLSelect, connection))
                {
                    SqlDataReader sqlreader = command.ExecuteReader();

                    while (sqlreader.Read())
                    {
                        string CustomerID = sqlreader["CustomerID"].ToString();
                        string CompanyName = sqlreader["CompanyName"].ToString();
                        string ContactName = sqlreader["ContactName"].ToString();
                        string City = sqlreader["City"].ToString();

                        var c = new Customer(CustomerID, CompanyName, ContactName,City);


                      Console.WriteLine($"{c.CustomerID,-15} is {c.ContactName,-40} from {c.CompanyName} in {c.City}");
                        
                    }

                    sqlreader.Close();
                }


                // delete customer

                string SQLDelete = $"delete from customers where CustomerID='{newCustomer.CustomerID}'";
                using (var command = new SqlCommand(SQLDelete, connection)) {
                    int affected = command.ExecuteNonQuery();
                    Console.WriteLine($"Delete : there were {affected} records deleted");
                }



                // read customers

                string SQLSelect2 = "Select * from Customers";

                using (var command = new SqlCommand(SQLSelect2, connection))
                {
                    SqlDataReader sqlreader = command.ExecuteReader();

                    while (sqlreader.Read())
                    {
                        string CustomerID = sqlreader["CustomerID"].ToString();
                        string CompanyName = sqlreader["CompanyName"].ToString();
                        string ContactName = sqlreader["ContactName"].ToString();
                        string City = sqlreader["City"].ToString();

                        var customer = new Customer(CustomerID, CompanyName, ContactName, City);

                        customers.Add(customer);
                    }
                }



            }

            // now print out data

            foreach (var c in customers)
            {
                Console.WriteLine($"{c.CustomerID,-15} is {c.ContactName,-40} from {c.CompanyName} in {c.City}");
            }

            customers.ForEach(c => {
                Console.WriteLine($"{c.CustomerID,-15} is {c.ContactName,-40} from {c.CompanyName} in {c.City}");
            });






            // trainer tip :      command.ExecuteNonQuery();

            // uddate customer

            // delete customer

        }
    }

    internal class Customer
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string City { get; set; }

        public Customer(string CustomerID, string CompanyName, string ContactName, string City)
        {
            this.CustomerID = CustomerID;
            this.CompanyName = CompanyName;
            this.ContactName = ContactName;
            this.City = City;
        }

        // default constructor
        public Customer() { }

    }
}
