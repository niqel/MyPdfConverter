using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFConverter
{
    public class Book
    {
        public string Title { get; set; }   
        List<Part> Parts { get; set; }

        public Book()
        {
            this.Parts = new List<Part>();
        }
    }
}
