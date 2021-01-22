using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CrimeManagementSystem.Models;

namespace CrimeManagementSystem.Pages.Crimes
{
    public class EditModel : PageModel
    {
        private readonly CrimeManagementSystem.Models.AppDbContext _context;

        public EditModel(CrimeManagementSystem.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Crime Crime { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Crime = await _context.Crimes
                .Include(c => c.Criminal)
                .Include(c => c.Officer)
                .Include(c => c.Victim).FirstOrDefaultAsync(m => m.Id == id);

            if (Crime == null)
            {
                return NotFound();
            }
           ViewData["CriminalId"] = new SelectList(_context.Criminals, "Id", "Name");
           ViewData["OfficerId"] = new SelectList(_context.Officers, "Id", "Name");
           ViewData["VictimId"] = new SelectList(_context.Victims, "Id", "Name");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Crime).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CrimeExists(Crime.Id))
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

        private bool CrimeExists(int id)
        {
            return _context.Crimes.Any(e => e.Id == id);
        }
    }
}
