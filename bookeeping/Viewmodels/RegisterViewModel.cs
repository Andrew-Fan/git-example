using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bookeeping.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string Name{ get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password{ get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmedPassword{ get; set; }

        [Required]
        [EmailAddress]
        public string Email{ get; set;}
    }
}