using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using zadanie03.Data;
using zadanie03.Models;

namespace zadanie03.Pages.Numbers
{
    public class EditModel : PageModel
    {
        private readonly zadanie03.Data.NumContext _context;

        public EditModel(zadanie03.Data.NumContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Num).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NumExists(Num.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool NumExists(int id)
        {
            return _context.Number.Any(e => e.Id == id);
        }
    }
}
