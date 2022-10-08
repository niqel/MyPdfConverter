using Google.Cloud.Translation.V2;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using ProxyMicrosoftTranslate.AzureTranslator;

namespace PDFToMD
{
    public class TranslateAndConvertPDFtoMD : ITranslateAndConvertPDFtoMD
    {
        private List<string> contenidos;
        private string urlReadFIle;
        private string urlWriteFile;
        private string nameFile;

        public TranslateAndConvertPDFtoMD(string urlReadFIle, string urlWriteFile, string nameFile)
        {
            this.contenidos = new List<string>();
            this.urlReadFIle = urlReadFIle;
            this.urlWriteFile = urlWriteFile;
            this.nameFile = nameFile;
        }

        public List<string> Contenidos { get => contenidos; }
        public string UrlReadFIle { get => urlReadFIle; }
        public string UrlWriteFile { get => urlWriteFile; }
        public string NameFile { get => nameFile;  }

        public void Resolve()
        {
            //Step One: Get Contenidos from pdf
            this.GetContenidostenidosFromPDF();
            //Step two: Edit parts
            this.TranslateToSpanish();
            //this.EditParts();
            ////Step three: Edit chapters
            //this.EditChapters();
            ////Step four: Edit Themes
            //this.EditThemes();
            ////Step five: Remove Not Importants
            //this.RemoveNotImportants();
            ////Step six: Translate Spanish
            //this.TranslateToSpanish();
            ////Step seven: Format MD
            //this.FormatterMD();
            ////Save Document()
            //this.SaveDocument();
        }

        private void EditChapters()
        {
            throw new NotImplementedException();
        }

        private void EditParts()
        {
            throw new NotImplementedException();
        }

        private void EditThemes()
        {
            throw new NotImplementedException();
        }

        private void FormatterMD()
        {
            throw new NotImplementedException();
        }

        private void GetContenidostenidosFromPDF()
        {
            var pdfDocument = new PdfDocument(new PdfReader(urlReadFIle));
            
            for (int i = 1; i <= pdfDocument.GetNumberOfPages(); i++)
            {
                var pagePDF = pdfDocument.GetPage(i);

                string pageText = PdfTextExtractor.GetTextFromPage(pagePDF);

                this.contenidos.Add(pageText);
            }
            pdfDocument.Close();
        }

        private void RemoveNotImportants()
        {
            throw new NotImplementedException();
        }

        private void SaveDocument()
        {
            throw new NotImplementedException();
        }

        private async void TranslateToSpanish()
        {
            ProxyMicrosoftTranslate.AzureTranslator.AzureTranslatorService azureTranslate = new AzureTranslatorService();
            AzureTranslatorRequestBody requestBody = new AzureTranslatorRequestBody();
            requestBody.Text = "Hello World";
            AzureTranslatorRequestBody requestBody2 = new AzureTranslatorRequestBody();
            requestBody.Text = "How are you";

            List<AzureTranslatorRequestBody> lista = new List<AzureTranslatorRequestBody>() { requestBody, requestBody2 };

            var resp = await azureTranslate.Execute(lista);
        }
    }
}