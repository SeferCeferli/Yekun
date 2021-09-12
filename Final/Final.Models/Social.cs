using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Final.Models
{
    public class Social
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50),Required]
        public string Name { get; set; }
        [MaxLength(500), Required]
        public string Link { get; set; }
        [MaxLength(50)]
        public string Icon { get; set; }
        [MaxLength(50)]
        public string Color { get; set; }
        [MaxLength(50)]
        public string Background { get; set; }
    }
}
