using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Final.Models
{
    public class CustomUser:IdentityUser
    {
        [MaxLength (50), Required]
        public string Name { get; set; }
        [MaxLength(50), Required]
        public string SurName   { get; set; }
        [MaxLength(500), Required]
        public string Adress { get; set; }
    }
}
