using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TextBox_Validation_MVC.ValidatorRules;

namespace TextBox_Validation_MVC.Models
{
    public class PersonModel
    {
        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(20)]
        [Display(Name = "Customer's first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(30)]
        [Display(Name = "Customer's first name")]
        public string LastName { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "{0} is required.")]
        [SocialSecurity(ErrorMessage = "Bad SSN")]
        //[InputMask("999-99-9999")]
        //[RegularExpression(@"^([0-9]{3})(\D*)([0-9]{2})(\D*)([0-9]{4})$", ErrorMessage = "Invalid Social Security Number")]
        public string Ssn { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Ssn}";
        }
    }
}