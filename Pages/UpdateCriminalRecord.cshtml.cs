using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrimeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CrimeManagementSystem.Pages
{
    public class UpdateCriminalRecordModel : PageModel
    {
        private readonly AppDbContext _context;

        public UpdateCriminalRecordModel(AppDbContext context){
            _context = context;
        }

        [BindProperty]
        public UpdateCriminalRecordForm UpdateCriminalRecordForm { get; set; }

        public Crime Crime { get; set; }
        public Criminal Criminal { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null){
                return NotFound();
            }
            Crime = _context.Crimes.Find(id);
            Criminal = _context.Criminals.Find(Crime.CriminalId);
            if (Crime == null)
            {
                return NotFound();
            }
            ViewData["CriminalId"] = new SelectList(_context.Criminals, "Id", "Name");           
            UpdateCriminalRecordForm = new UpdateCriminalRecordForm();
            UpdateCriminalRecordForm.CrimeId = Crime.Id;
            return Page();
        }

        public IActionResult OnPost(){
            Crime = _context.Crimes.Find(UpdateCriminalRecordForm.CrimeId);
            Console.WriteLine(Criminal);
            if (!ModelState.IsValid){
                return Page();
            }

            Crime.Description = UpdateCriminalRecordForm.Description;
            Crime.CrimeStatus = UpdateCriminalRecordForm.CrimeStatus;
            Crime.CriminalId = UpdateCriminalRecordForm.CriminalId;
            _context.SaveChanges();
            return RedirectToPage("/OfficerProfile", new  { id = Crime.OfficerId });
        }
    }
}