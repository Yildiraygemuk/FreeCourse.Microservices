using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Web.Models
{
    public class SignInInputVm
    {
        [Display(Name ="Email Address")]
        public string Email { get; set; }
        [Display(Name ="Password")]
        public string Password { get; set; }
        [Display(Name ="Remember me")]
        public bool IsRemember { get; set; }
    }
}
