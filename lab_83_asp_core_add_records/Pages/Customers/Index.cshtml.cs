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
    public class IndexModel : PageModel
    {
        private readonly lab_83_asp_core_add_records.Models.Northwind _context;

        public IndexModel(lab_83_asp_core_add_records.Models.Northwind context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customers.ToListAsync();
        }
    }
}
