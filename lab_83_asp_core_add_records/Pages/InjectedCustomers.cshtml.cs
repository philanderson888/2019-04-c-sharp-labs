using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lab_83_asp_core_add_records.Models;

namespace lab_83_asp_core_add_records.Pages
{
    public class InjectedCustomersModel : PageModel
    {

        private Northwind db;
        public List<Customer> customers;
        public int PageNumber;

        // Bind Property is required for the POSTING of data from FORM
        [BindProperty]
        public Customer customer { get; set; }

        // Constructor to instantiate this db
        // Instantiate Northwind just once : use for Get() and Post()
        public InjectedCustomersModel(Northwind injectedContext)
        {
            db = injectedContext;
            PageNumber = 0;
        }

        public void OnGet()
        {
            if (Request.Query.Count > 0)
            {
                PageNumber = Int32.Parse(Request.Query["PageNumber"]);
            }

            if (PageNumber <= 0)
            {
                PageNumber = 0;
            }
            customers = db.Customers.Skip(PageNumber*10).Take(10).ToList();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToPage("/AllCustomers");
            }
            return Page();
        }



    }
}