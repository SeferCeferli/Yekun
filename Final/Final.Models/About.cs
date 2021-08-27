using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Final.Models
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250), Required]
        public string Title { get; set; }
        [Column(TypeName="ntext"),Required]
        public string Text { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
