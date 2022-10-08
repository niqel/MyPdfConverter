using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFConverter
{
    public interface IViewTranslateAndConvertPDFToMD
    {
        List<string> Contenidos { get; set; }
        string UrlReadFIle { get; set; }
        string UrlWriteFile { get; set; }
        string NameFile { get; set; }

        void GetContenidostenidosFromPDF();
        void RemoveNotImportants();
        void EditParts();
        void EditChapters();
        void EditThemes();
        void TranslateToSpanish();
        void FormatterMD();
        void SaveDocument();
        void CompleteSteps();
    }
}
