using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CrimeManagementSystem.Models;

namespace CrimeManagementSystem.Pages.Crimes
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
        ViewData["CriminalId"] = new SelectList(_context.Criminals, "Id", "Name");
        ViewData["OfficerId"] = new SelectList(_context.Officers, "Id", "Name");
        ViewData["VictimId"] = new SelectList(_context.Victims, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Crime Crime { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Crimes.Add(Crime);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}