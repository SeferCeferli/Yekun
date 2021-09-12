using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Final.Services.ViewModels
{
    public class VmLogin
    {
        [MaxLength(50),Required]
        public string Email { get; set; }
        [MaxLength(50), Required]
        public string Password { get; set; }
    }
}
