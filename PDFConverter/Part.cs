using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFConverter
{
    public class Part
    {
        public string Name { get; set; }
        public string Content { get; set; }

        public List<Chapter> Chapters { get; set; }

        public Part()
        {
            this.Chapters = new List<Chapter>();    
        }
    }
}
