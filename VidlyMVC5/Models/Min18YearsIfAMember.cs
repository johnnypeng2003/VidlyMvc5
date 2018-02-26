using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using VidlyMVC5.Dtos;

namespace VidlyMVC5.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown ||
                customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if (customer.Birthdate == null)
                return new ValidationResult("出生日需要輸入");

            var age = DateTime.Now.Year - customer.Birthdate.Value.Year;

            return (age > 18)
                ? ValidationResult.Success
                : new ValidationResult("會員客戶：年齡需要大於18歲!");
        }
    }
}