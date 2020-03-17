using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Book_Core.Models
{
    public class BookCategory
    {
        public List<Book> Books { get; set; }
        public SelectList Categories { get; set; }
        public string Bookcategory { get; set; }
        public string searchstr { get; set; }
        public SelectList Publishers { get; set; }
        public string Publisherssear { get; set; }
    }
}
