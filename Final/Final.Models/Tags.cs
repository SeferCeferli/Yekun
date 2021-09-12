using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Final.Models
{
    public class Tags
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50),Required]
        public string Name { get; set; }
        public List<NewsToTag> newsToTags { get; set; }

    }
}
