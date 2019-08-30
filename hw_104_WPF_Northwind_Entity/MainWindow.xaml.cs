using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace hw_104_WPF_Northwind_Entity
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Customer> customers;
        static List<Order> orders;
        static List<Order_Detail> orderDetails;
        static Customer customer;
        static Order order;
        static Order customerOrders;

        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }
        void Initialize()
        {
            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList();
                ListBoxCustomers.DisplayMemberPath = "ContactName";
                ListBoxCustomers.ItemsSource = customers;
            }
        }



        private void ListBoxCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxCustomerOrders.ItemsSource = null;
            using (var db = new NorthwindEntities())
            {
                customer = (Customer)ListBoxCustomers.SelectedItem;
                //  orders = db.Orders.Where(order=>order.CustomerID==customer.CustomerID).ToList<Order>();

                orders =
                    (from order in db.Orders
                     where order.CustomerID == customer.CustomerID
                     select order).ToList<Order>();
                ListBoxCustomerOrders.DisplayMemberPath = "OrderID";
                ListBoxCustomerOrders.ItemsSource = orders;

            }
        }

        private void ListBoxCustomerOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            order = (Order)ListBoxCustomerOrders.SelectedItem;
            ListBoxOrderDetails.ItemsSource = null;
            using (var db = new NorthwindEntities())
                orderDetails = db.Order_Details.Where(od => od.OrderID == order.OrderID).ToList();



            ListBoxCustomerOrders.DisplayMemberPath = "OrderID";
            ListBoxCustomerOrders.ItemsSource = orders;

        }



        private void ListBoxOrderDetails_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}