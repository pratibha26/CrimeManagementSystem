
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace CrimeManagementSystem.Models
{
    public class UpdateCriminalRecordForm {
        public int CrimeId { get; set; }

        [Display(Name="Crime Description")]
        public String Description { get; set; }

        [Display(Name = "Crime status")]
        public string CrimeStatus {get; set;}

        [Required]
        [Display(Name = "Criminal Name")]
        public int CriminalId { get; set; }
        public Criminal Criminal { get; set; }
    }
}