using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Final.Models
{
    public class NewsToTag
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("News")]
        public int NewsId { get; set; }
        public News News { get; set; }
        [ForeignKey("Tags")]
        public int TagsId { get; set; }
        public Tags Tags { get; set; }
    }
}
