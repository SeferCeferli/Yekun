using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Final.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50),Required(ErrorMessage ="Adi Qeyd Etmelisiniz")]
        public string Name { get; set; }
        public List<News> News { get; set; }
    }
}
