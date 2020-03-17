using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Movie_Task.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int Mid { get; set; }
        [Required]
        public string Mname { get; set; }
        [Required]
        public string Location { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        public Theater Theater { get; set; }
    }
}