using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrimeManagementSystem.Models;

namespace CrimeManagementSystem.Pages.Criminals
{
    public class IndexModel : PageModel
    {
        private readonly CrimeManagementSystem.Models.AppDbContext _context;

        public IndexModel(CrimeManagementSystem.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Criminal> Criminal { get;set; }

        public async Task OnGetAsync()
        {
            Criminal = await _context.Criminals.ToListAsync();
        }
    }
}
