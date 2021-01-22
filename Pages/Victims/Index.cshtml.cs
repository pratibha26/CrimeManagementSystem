using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrimeManagementSystem.Models;

namespace CrimeManagementSystem.Pages.Victims
{
    public class IndexModel : PageModel
    {
        private readonly CrimeManagementSystem.Models.AppDbContext _context;

        public IndexModel(CrimeManagementSystem.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Victim> Victim { get;set; }

        public async Task OnGetAsync()
        {
            Victim = await _context.Victims.ToListAsync();
        }
    }
}
