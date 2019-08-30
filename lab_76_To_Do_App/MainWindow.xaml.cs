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

namespace lab_76_To_Do_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Customer> customers;
        static List<String> cities = new List<String>();
        static Customer customer = new Customer();
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
                ListBox01.ItemsSource = customers;
                ListBox01.DisplayMemberPath = "ContactName";
                foreach(var c in customers)
                {
                    if (c.City != null)
                    {
                        cities.Add(c.City);
                    }

                }
                ComboBox02.ItemsSource = cities.Distinct().OrderBy(c=>c);
            //    ListView01.ItemsSource = customers;
            //    ListViewItem01.Content = "ContactName";
            //    ListView01.DisplayMemberPath = "ContactName";
            }
        }


        private void ComboBox02_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TextBox01.Text = "hi";
        }

        private void ListBox01_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TextBox01.Text = "there";
        }
    }
}
