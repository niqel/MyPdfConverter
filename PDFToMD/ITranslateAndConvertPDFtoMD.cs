using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFToMD
{
    public interface ITranslateAndConvertPDFtoMD
    {
        List<string> Contenidos { get; }
        string UrlReadFIle { get; }
        string UrlWriteFile { get; }
        string NameFile { get; }

       
        void Resolve();
    }
}
