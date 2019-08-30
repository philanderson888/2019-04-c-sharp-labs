using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab_80_asp_core_web.Pages
{
    public class ListsModel : PageModel
    {
        public List<String> items = new List<string>();
        public void OnGet()
        {
            items.Add("first");
            items.Add("second");
            items.Add("FiFteenth");
            items.Add("fourth");
            items.Add("odd one out");
        }
    }
}