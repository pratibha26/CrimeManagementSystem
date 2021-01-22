
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrimeManagementSystem.Models
{
    public class Victim
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Victim Name")]   
        [Required (ErrorMessage = "Enter minimum 1 charachter and maximum 500")]
        [StringLength(500, MinimumLength=1)]
        public String Name { get; set; }

        [Required]     
        [Display(Name = "Date Of Birth")]   
        [DataType(DataType.Date)]  
        [CustomValidation(typeof(Criminal), "DateToCurrentValidation")]
        public DateTime DateOfBirth { get; set; }
        
        [Phone]
        public String Phone { get; set; }
        [EmailAddress]
	    public string Email { get; set; }
        
        public string Address {get; set;}
        [Required]
        [RegularExpression(@"^[\d]{5}$")] // 5 digit zip code
        public string ZipCode{get; set; }
        
        [Display(Name = "Death Date")]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(Victim), "DeathDateValidation")]
        public DateTime? DeathDate { get; set; }
        
        public String Description { get; set; }
        
        [NotMapped]
        public int Age {
            get {
            int age = 0;  
            age = DateTime.Now.Year - DateOfBirth.Year;  
            if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)  
            age = age - 1;  
      
           return age;    
            }
        }
        [NotMapped]
        [Display(Name = "Stil Alive")]
        public bool IsDeceased
        {
            get
             {
                return DeathDate == null;
             }
        }
        
        public ICollection<Crime>  Crimes { get; set; }

        public static ValidationResult DeathDateValidation(DateTime? deathDate,ValidationContext context ) 
        {
            if(deathDate==null) {
                return ValidationResult.Success;
            }
            Victim instance = context.ObjectInstance as Victim;
            if (instance==null) {
                return ValidationResult.Success;
            }
            if (deathDate > instance.DateOfBirth){
                return ValidationResult.Success;
            }
            return new ValidationResult("Death date must be after date of birth");
        }


    }
}
            