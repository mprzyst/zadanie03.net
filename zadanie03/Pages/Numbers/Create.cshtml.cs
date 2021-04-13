using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using zadanie03.Data;
using zadanie03.Models;

namespace zadanie03.Pages.Numbers
{
    public class CreateModel : PageModel
    {
        private readonly zadanie03.Data.NumContext _context;

        public CreateModel(zadanie03.Data.NumContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Num Num { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Number.Add(Num);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
