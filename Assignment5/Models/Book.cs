using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class Book
    {
        //BookID as Primary Key
        [Key]
        public int BookID { get; set; }
        //Title
        [Required]
        public string Title { get; set; }
        //Author First, Last, Middle
        [Required]
        public string AuthorFirst { get; set; }
        [Required]
        public string AuthorLast { get; set; }
        public string AuthorMiddle { get; set; }
        //Publisher
        [Required]
        public string Publisher { get; set; }
        //ISBN
        [Required]
        [RegularExpression (@"^(?=(?:\D*\d){10}(?:(?:\D*\d){3})?$)[\d-]+$", ErrorMessage="ISBN format invalid")]
        public string ISBN { get; set; }
        //Category/Classification (split out)
        [Required]
        public string Category { get; set; }
        [Required]
        public string Classification { get; set; }
        //Price
        [Required]
        public double Price { get; set; }
    }
}
