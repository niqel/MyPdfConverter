using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFConverter
{
    public class Chapter
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public List<PointText> PointTexts { get; set; }

        public Chapter()
        {
            this.PointTexts = new List<PointText>();
        }
    }
}
