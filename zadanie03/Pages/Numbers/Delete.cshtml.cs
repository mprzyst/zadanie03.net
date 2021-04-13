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
    public class DeleteModel : PageModel
    {
        private readonly zadanie03.Data.NumContext _context;

        public DeleteModel(zadanie03.Data.NumContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Num = await _context.Number.FindAsync(id);

            if (Num != null)
            {
                _context.Number.Remove(Num);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
