using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using zadanie03.Data;
using zadanie03.Models;

namespace zadanie03.Pages.Numbers
{
    public class IndexModel : PageModel
    {
        private readonly zadanie03.Data.NumContext _context;

        public IndexModel(zadanie03.Data.NumContext context)
        {
            _context = context;
        }

        public IList<Num> Num { get;set; }

        public void  OnGet()
        {
            

            var NumQuery = from num in _context.Number orderby num.When descending select num ;
            Num = NumQuery.Take(10).ToList();
        }
    }
}
