using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Final.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250),Required]
        public string Title { get; set; }
        [MaxLength(250)]
        public string MainImage { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [Column(TypeName ="ntext"),Required]
        public string Description1 { get; set; }
        [Column(TypeName = "ntext"), Required]
        public string Description2 { get; set; }
        [Column(TypeName = "ntext"), Required]
        public string Description3 { get; set; }
        [MaxLength(250), Required]
        public string Subtitle { get; set; }
        [MaxLength(250)]
        public string Image1 { get; set; }
        [NotMapped]
        public IFormFile Image1File { get; set; }
        [MaxLength(250)]
        public string Image2 { get; set; }
        [NotMapped]
        public IFormFile Image2File { get; set; }
        [MaxLength(250)]
        public string VideoImage { get; set; }
        [NotMapped]
        public IFormFile VideoImageFile { get; set; }
        [MaxLength(500),Required]
        public string Link { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ViewCount { get; set; }
        public List<NewsToTag> newsToTags { get; set; }
    }
}
