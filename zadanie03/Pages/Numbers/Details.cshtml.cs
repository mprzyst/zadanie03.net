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
    public class DetailsModel : PageModel
    {
        private readonly zadanie03.Data.NumContext _context;

        public DetailsModel(zadanie03.Data.NumContext context)
        {
            _context = context;
        }

        public Num Num { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Num = await _context.Number.FirstOrDefaultAsync(m => m.Id == id);

            if (Num == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
