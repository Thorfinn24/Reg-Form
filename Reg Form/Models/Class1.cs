using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI.WebControls;

namespace Reg_Form.Models
{
    public class Class1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        [RegularExpression("@",ErrorMessage ="You are missing an expression")]
        public string Email { get; set; }
 
        [Required(ErrorMessage = "Enter your phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Enter the age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Enter the password")]
        public string password {  get; set; }

        [Compare("Password",ErrorMessage = "They are not the same")]
        public string ConfirmPassword { get; set; }

    }
}