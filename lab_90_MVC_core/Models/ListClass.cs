using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_90_MVC_core.Models
{
    public class ListClass
    {
        public List<String> list { get; set; } = new List<string>();

        public ListClass()
        {
           // list = new List<string>();  either way is fine
        }
    }
} 
