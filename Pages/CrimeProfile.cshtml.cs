using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrimeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CrimeManagementSystem.Pages
{
   
    public class CrimeProfileModel : PageModel
    {
        private AppDbContext _context;
        
        public CrimeProfileModel(AppDbContext context){
            _context = context;
        }
        public Crime Crime { get; set; }

        public IActionResult OnGet(int? id)
        {
             if (id == null)
            {
                return NotFound();
            }
            Crime = _context.Crimes
                    .Include(y => y.Victim)
                    .Include(z => z.Officer)
                    .Include(x => x.Criminal)
                    .FirstOrDefault(est => est.Id == id);
            
            if(Crime == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}