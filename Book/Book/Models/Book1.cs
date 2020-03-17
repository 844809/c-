using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Book.Models
{
    public class Book1
    {
        [Required]
        public int Bid { get; set; }
        [Required]
        public string Btitle { get; set; }
        [Required]
        public string Category { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        [Required]
        public string AuthorName { get; set; }
        [Required]
        public string Publisher { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime ReleaseDate { get; set; }
    }
}
