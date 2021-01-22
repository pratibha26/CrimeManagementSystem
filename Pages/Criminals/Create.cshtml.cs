using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CrimeManagementSystem.Models;

namespace CrimeManagementSystem.Pages.Criminals
{
    public class CreateModel : PageModel
    {
        private readonly CrimeManagementSystem.Models.AppDbContext _context;

        public CreateModel(CrimeManagementSystem.Models.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Criminal Criminal { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Criminals.Add(Criminal);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}