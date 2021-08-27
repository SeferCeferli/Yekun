using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final.Models
{
    public class Settings
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Logo { get; set; }
        [NotMapped]
        public IFormFile LogoFile { get; set; }
        [MaxLength(50), Required]
        public string Email1 { get; set; }
        [MaxLength(50), Required]
        public string Email2 { get; set; }
        [MaxLength(20), Required]
        public string Phone { get; set; }
        [MaxLength(500), Required]
        public string Adress { get; set; }
        [MaxLength(2000), Required]
        public string Info { get; set; }
    }
}
