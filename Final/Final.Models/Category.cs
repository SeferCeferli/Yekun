using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Final.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50),Required(ErrorMessage ="Adi Qeyd Etmelisiniz")]
        public string Name { get; set; }
        [MaxLength(250)]
        public string MainImage { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public List<News> News { get; set; }
    }
}
