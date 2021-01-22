
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrimeManagementSystem.Models
{
    public class Officer
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name = "Officer Name")]   
        [Required (ErrorMessage = "Enter minimum 1 charachter and maximum 500")]
        [StringLength(500, MinimumLength=1)]
        public String Name { get; set; }

        [Display(Name = "Officer Designation")]   
        public string Designation { get; set; }
       
        [Required]     
        [Display(Name = "Date Of Birth")]   
        [DataType(DataType.Date)]  
        [CustomValidation(typeof(Criminal), "DateToCurrentValidation")]
        public DateTime DateOfBirth { get; set; }

        [Phone]
        public String Phone { get; set; }
        [EmailAddress]
	    public string Email { get; set; } 

        [Display(Name = "Current Posting Location")] 
        public string PostingLocation {get; set;}

        [Display(Name = "Registation Date")]   
        [DataType(DataType.Date)]  
        [CustomValidation(typeof(Criminal), "DateToCurrentValidation")]
        public DateTime RegistrationDate { get; set; }
        
        [Display(Name = "Retirement Date")]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(Officer), "RetirementDateValidation")]
        public DateTime? RetirementDate { get; set; }
        [Display(Name = "Cases Solved")]
        public int CaseSolved { get; set; }
        [Display(Name = "Cases Pending")]
        public int CasePending { get; set; }

              
        [NotMapped]
        [Display(Name = "Cases Worked")]
        public int CasesWorked
        {
            get
             {
                return CaseSolved + CasePending;
             }
        }
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
     
        public ICollection<Crime>  Crimes { get; set; }
 
       
        public static ValidationResult RetirementDateValidation(DateTime? retirementDate,ValidationContext context ) 
        {
            if(retirementDate==null) {
                return ValidationResult.Success;
            }
            Officer instance = context.ObjectInstance as Officer;
            if (instance==null) {
                return ValidationResult.Success;
            }
            if (retirementDate > instance.RegistrationDate){
                return ValidationResult.Success;
            }
            return new ValidationResult("Retirement date must be after Registration date");
        }


        // ADD PROPERTIES HERE
    }
}
            