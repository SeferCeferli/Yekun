using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Final.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50),Required]
        public string Name { get; set; }
        [MaxLength(50), Required]
        public string Email { get; set; }
        [Column(TypeName ="ntext"),Required]
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
