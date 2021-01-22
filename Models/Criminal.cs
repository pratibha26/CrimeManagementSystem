using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrimeManagementSystem.Models
{
    public class Criminal
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Criminal Name")]       
        [Required (ErrorMessage = "Enter minimum 1 charachter and maximum 500")]
        [StringLength(500, MinimumLength=1)]
        public String Name { get; set; }
        
        [Required]     
        [Display(Name = "Date Of Birth")]   
        [DataType(DataType.Date)]  
        [CustomValidation(typeof(Criminal), "DateToCurrentValidation")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Lockup Location")] 
        public string LockupLocation {get; set;}
   
        [Display(Name = "Lockin Date")]   
        [DataType(DataType.Date)]  
        [CustomValidation(typeof(Criminal), "DateToCurrentValidation")]
        public DateTime LockinDate { get; set; }
        
        [Display(Name = "Lockout Date")]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(Criminal), "LockoutDateValidation")]
        public DateTime? LockoutDate { get; set; }

        [NotMapped]
        [Display (Name = "Convicted")]
        public bool IsConvicted {
        // TRUE/FALSE: True if lockin date is not null
            get { return LockinDate != null; }
        }
        [NotMapped]
        public bool InLockup {
        // TRUE/FALSE: False if lockout date is not null
            get { return LockoutDate == null && LockinDate != null; }
        }
        [NotMapped]
        public int Age 
        {  
            get {
            int age = 0;  
            age = DateTime.Now.Year - DateOfBirth.Year;  
            if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)  
            age = age - 1;  
            return age;  
            }  
        }
        public ICollection<Crime> Crimes { get; set; }
        public static ValidationResult LockoutDateValidation(DateTime? lockoutDate,ValidationContext context ) 
        {
            if(lockoutDate==null) {
                return ValidationResult.Success;
            }
            Criminal instance = context.ObjectInstance as Criminal;
            if (instance==null) {
                return ValidationResult.Success;
            }
            if (lockoutDate > instance.LockinDate){
                return ValidationResult.Success;
            }
            return new ValidationResult("Lock out date must be after Lock in date");
        }

        public static ValidationResult DateToCurrentValidation(DateTime? lockinDate,ValidationContext context ) 
        {
            if(lockinDate==null) {
                return ValidationResult.Success;
            }
            var today=DateTime.Today;
            if (lockinDate.Value.Date <= today){
                return ValidationResult.Success;
            }
            return new ValidationResult("Date should be today or in past, no future dates allowed");
        }

        // ADD PROPERTIES HERE
    }
}
            