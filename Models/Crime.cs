using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CrimeManagementSystem.Models
{
    public class Crime
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Type of Crime")]   
        public String CrimeType { get; set; }
        public String Description { get; set; }
        [Display(Name = "Crime Date")]   
        [DataType(DataType.Date)]  
        [CustomValidation(typeof(Criminal), "DateToCurrentValidation")]
        public DateTime CrimeDate { get; set; }

        [Required]
        [Display(Name = "Crime Location")] 
        public string CrimeLocation {get; set;}

        [Required]
        [Display(Name = "Crime status")] 
        public string CrimeStatus {get; set;}

        [Display(Name = "Crime Registration Date")]   
        [DataType(DataType.Date)]  
        [CustomValidation(typeof(Crime), "CrimeRegistrationDateValidation")]
        public DateTime CrimeRegistrationDate { get; set; }

        [Display(Name = "Has Evidence")]
        public bool HasEvidence { get; set; }

        [Required]
        public string Priority {get; set;}
        
        [Display(Name = "Victim Name")]   
       
        public int VictimId { get; set; }
        public Victim Victim { get; set; }
        [Display(Name = "Criminal Name")]
        public int CriminalId { get; set; }
        public Criminal Criminal { get; set; }
        [Display(Name = "Officer Name")]
        public int OfficerId { get; set; }
        public Officer Officer { get; set; }
     
        public static ValidationResult CrimeRegistrationDateValidation(DateTime? crimeRegistrationDate,ValidationContext context ) 
        {
            if(crimeRegistrationDate==null) {
                return ValidationResult.Success;
            }
            Crime instance = context.ObjectInstance as Crime;
            if (instance==null) {
                return ValidationResult.Success;
            }
            var today=DateTime.Today;
            if (crimeRegistrationDate >= instance.CrimeDate && crimeRegistrationDate<= today){
                return ValidationResult.Success;
            }
            return new ValidationResult("Crime Registratio date must be after or on the Crime date and should be before or on current date");
        }
        
        // ADD PROPERTIES HERE
    }
}
            