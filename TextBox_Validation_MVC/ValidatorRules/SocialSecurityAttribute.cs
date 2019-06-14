using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace TextBox_Validation_MVC.ValidatorRules
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class SocialSecurityAttribute : ValidationAttribute
    {
        public string SocialValue { get; set; }

        public override bool IsValid(object value)
        {
            if (value is null)
            {
                return false;
            }

            var noDashedSocial = value.ToString().Replace("-", "").Trim();

            return noDashedSocial.Length == 9 && Regex.IsMatch(noDashedSocial, @"^\d{9}$");
        }
    }
}