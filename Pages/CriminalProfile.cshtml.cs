using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CrimeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace CrimeManagementSystem.Pages
{
    public class CriminalProfileModel : PageModel
    {
        private AppDbContext _context;

        public CriminalProfileModel(AppDbContext context){
             _context = context;
        }

        public Criminal Criminal { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Criminal = _context.Criminals.Include(est => est.Crimes).ThenInclude(y => y.Victim).Include(z=>z.Crimes).ThenInclude(x=>x.Officer).FirstOrDefault(est => est.Id == id);
            if(Criminal == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}