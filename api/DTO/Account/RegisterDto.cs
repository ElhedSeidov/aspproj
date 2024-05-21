using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.DTO.Account
{
    public class RegisterDto
    {
        [Required]
        public string? UserName {get;set;}

        [Required]
        [EmailAddress]
        public string? Email {get;set;}

        [Required]
        public string? Password{get;set;}

        [Required]
        [Compare("Password",ErrorMessage = "Password and Confirmation Password must match.")]

        public string ConfirmPassword {get;set;}


    }
}