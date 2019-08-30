using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lab_83_asp_core_add_records.Models;

namespace lab_83_asp_core_add_records.Pages.Customers
{
    public class DetailsModel : PageModel
    {
        private readonly lab_83_asp_core_add_records.Models.Northwind _context;

        public DetailsModel(lab_83_asp_core_add_records.Models.Northwind context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customers.FirstOrDefaultAsync(m => m.CustomerID == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
