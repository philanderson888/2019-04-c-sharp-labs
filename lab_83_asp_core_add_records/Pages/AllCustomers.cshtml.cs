using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lab_83_asp_core_add_records.Models;
using Microsoft.EntityFrameworkCore;

namespace lab_83_asp_core_add_records.Pages
{
    public class AllCustomersModel : PageModel
    {
        private Northwind db;
        public List<Customer> customers;

        // Bind Property is required for the POSTING of data from FORM
        [BindProperty]
        public Customer customer { get; set; }

        // Constructor to instantiate this db
        // Instantiate Northwind just once : use for Get() and Post()
        public AllCustomersModel(Northwind injectedContext)
        {
            db = injectedContext;

        }

        public void OnGet()
        {
            customers = db.Customers.ToList();
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