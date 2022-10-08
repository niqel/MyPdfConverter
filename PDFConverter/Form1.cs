using Google.Cloud.Translation.V2;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using PDFToMD;
using System.Linq;
using System.Text;

namespace PDFConverter
{
    public partial class Form1 : Form, IViewTranslateAndConvertPDFToMD
    {
        private List<string> contenidos;
        private string urlReadFIle;
        private string urlWriteFile;
        private string nameFile;

        public List<string> Contenidos 
        {
            get
            {
                return contenidos;
            }
            set 
            {
                contenidos = value;
            }
        }
        public string UrlReadFIle 
        {
            get
            { 
                return urlReadFIle;
            }
            set
            {
                urlReadFIle = lblUbicacionLeerEn.Text;
            }
        }
        public string UrlWriteFile 
        {
            get
            {
                return urlWriteFile;
            } 
            set
            {
                urlWriteFile = lblUbicacionGuardarEn.Text;
            }
        }
        public string NameFile 
        {
            get { return nameFile; }
            set
            {
                NameFile = txtNombreArchivo.Text;
            }
        }

        public Form1()
        {
            this.contenidos = new List<string>();
            InitializeComponent();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lblUbicacionLeerEn.Text = openFileDialog.FileName;
            }
        }

        private void btnGuardarEn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                lblUbicacionGuardarEn.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            CompleteSteps();
            //List<string> list = new List<string>();
            //List<string> pages = new List<string>();
            //var ruta = lblUbicacionLeerEn.Text;
            //var pdfDocument = new PdfDocument(new PdfReader(ruta));
            //StringBuilder stringBuilder = new StringBuilder();

            //for (int i = 1; i <= pdfDocument.GetNumberOfPages(); i++)
            //{
            //    var pagePDF = pdfDocument.GetPage(i);

            //    string pageText = PdfTextExtractor.GetTextFromPage(pagePDF);

            //    pages.Add(pageText);
            //}
            //pdfDocument.Close();

            ////string myFile = $"{lblUbicacionGuardarEn.Text}\\{txtNombreArchivo.Text}";
            //foreach (var page in pages)
            //{
            //    List<string> lines = page.Split(new[] { "\n" },
            //    StringSplitOptions.RemoveEmptyEntries).ToList();

            //    foreach (var line in lines)
            //    {
            //        stringBuilder.AppendLine(line);
            //        char[] caracteres = line.ToCharArray();
            //        bool SaltoLinea = false;

            //        for (int i = 0; i < caracteres.Length; i++)
            //        {
            //            if (caracteres[i] == '.')
            //            {
            //                SaltoLinea = true;
            //            }
            //            else
            //            {
            //                SaltoLinea = false;
            //            }
            //        }

            //        if (SaltoLinea == true)
            //        {
            //            stringBuilder.AppendLine();
            //        }
            //    }
            //}
            //string respuesta = stringBuilder.ToString();

            //pages.Clear();
            //stringBuilder.Clear();

            ////Limpiar espacio dobles entre palabras
            //List<string> linesArray = respuesta.Split("\n", StringSplitOptions.RemoveEmptyEntries).ToList();
            //respuesta = string.Empty;

            //foreach (string line in linesArray)
            //{
            //    char[] caracteres = line.ToCharArray();
            //    for (int i = 0; i < caracteres.Length; i++)
            //    {
            //        if (i == 0)
            //        {
            //            if (caracteres[i] == ' ')
            //            {
            //                //stringBuilder.Append(caracteres[i]);
            //            }
            //            else
            //            {
            //                stringBuilder.Append(caracteres[i]);
            //            }
            //        }
            //        else
            //        {
            //            if (caracteres[i] == ' ' && caracteres[i - 1] == ' ')
            //            {
            //            }
            //            else
            //            {
            //                stringBuilder.Append(caracteres[i]);
            //            }
            //        }
            //    }
            //}

            //respuesta = stringBuilder.ToString();
            //stringBuilder.Clear();
            //linesArray = new List<string>();

            //char[] delims = new[] { '\r', '\n' };
            //List<string> linesArray2 = respuesta.Split(delims, StringSplitOptions.None).ToList();

            ////List<string> linesArray2 = respuesta.Split(new[] { "\n" },
            ////    StringSplitOptions.RemoveEmptyEntries).ToList();

            //respuesta = String.Empty;
            //bool encontrado = false;

            //foreach (var linea in linesArray2)
            //{
            //    if (linea == "PART I Introduction" && encontrado == false)
            //    {
            //        list.Add(linea);
            //        encontrado = true;
            //    }
            //    else
            //    {
            //        if (encontrado == true)
            //        {
            //            list.Add(linea);
            //        }
            //    }
            //}

            //list.Remove("Index");

            //List<string> contents = new List<string>();

            //Book book = new Book();
            //book.Title = "Clean Architecture";

            //bool indexEncontrado = false;
            //foreach (var line in list)
            //{
            //    if (line == "PART I Introduction" && indexEncontrado == false)
            //    {
            //        contents.Add(line);
            //        indexEncontrado = true;
            //    }
            //    else
            //    {
            //        if (indexEncontrado == true)
            //        {
            //            if (line != "FOREWORD")
            //            {
            //                contents.Add(line);
            //            }
            //            else
            //            {
            //                indexEncontrado = false;
            //            }
            //        }
            //    }
            //}

            //foreach (var content in contents)
            //{
            //    var part = "PART ";
            //    var partIndex = content.Substring(0, 5);
            //    if (part == partIndex)
            //    {
            //        string namePart = content;
            //        string namePartSplit = content.Remove(0, 5);

            //        string[] chars = namePartSplit.Split(" ");

            //        for (int i = 0; i < list.Count(); i++)
            //        {
            //            if (i < list.Count() - 1)
            //            {
            //                var listi = list[i].ToUpper();
            //                var listiNext = list[i + 1].ToUpper();
            //                var sustitucionListI = chars[0].ToUpper();
            //                var sustitucionListIDos = chars[1].ToUpper();
            //                if (listi == sustitucionListI)
            //                {
            //                    if (listiNext.Contains(':'))
            //                    {
            //                        list[i] = namePart;
            //                        list[i + 1] = " ";
            //                        list.RemoveAt(i + 2);
            //                        i--;

            //                    }
            //                    list[i] = namePart;
            //                    list[i + 1] = " ";
            //                }
            //            }
            //        }
            //    }
            //    //- [PARTE I Introducción](#parte-i-introducción)
            //    //## **PARTE I Introducción**
            //}

            //foreach (var content in contents)
            //{
            //    var chapter = "Chapter ";

            //    if (content.Contains(chapter))
            //    {
            //        var chapterIndex = content.Substring(0, 8);
            //        if (chapter == chapterIndex)
            //        {
            //            string nameChapter = content;
            //            string nameChapterSplit = content.Remove(0, 8);

            //            string[] chars = nameChapterSplit.Split(" ");

            //            for (int i = 0; i < list.Count(); i++)
            //            {
            //                if (i < list.Count() - 1)
            //                {
            //                    var listi = list[i].ToUpper();
            //                    var listiNext = list[i + 1].ToUpper();
            //                    var sustitucionListI = chars[0].ToUpper();
            //                    var sustitucionListIDos = chars[1].ToUpper();
            //                    if (listi == sustitucionListI)
            //                    {
            //                        var pro = listi.Remove(0, 1);
            //                        if (pro.Contains("[a - z]"))
            //                        {
            //                        }
            //                        else
            //                        {
            //                            list[i] = nameChapter;
            //                            list[i + 1] = " ";
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}

            //bool encontrado2 = false;
            //bool PrimerBorrado = true;

            //for (int i = 0; i < list.Count(); i++)
            //{

            //    if (list[i] == "FOREWORD" && encontrado2 == false)
            //    {
            //        list[i] = "";
            //        encontrado2 = true;
            //    }

            //    if (encontrado2 == true)
            //    {
            //        if (list[i] != "PART I Introduction" && PrimerBorrado == true && encontrado2 == true)
            //        {
            //            list.RemoveAt(i + 1);
            //            i--;
            //            PrimerBorrado = false;
            //        }
            //        else
            //        {
            //            if (list[i] != "PART I Introduction" && encontrado2 == true)
            //            {
            //                list.RemoveAt(i);
            //                i--;
            //            }
            //            else
            //            {
            //                encontrado2 = false;
            //            }
            //        }
            //    }
            //}

            //bool indexEncontrado2 = false;
            //for (int i = 0; i < list.Count(); i++)
            //{
            //    if (list[i] == "INDEX" && indexEncontrado2 == false)
            //    {
            //        list[i] = "";
            //        indexEncontrado2 = true;
            //    }

            //    if (indexEncontrado2 == true)
            //    {
            //        list.RemoveAt(i);
            //        i--;
            //    }
            //}
            //bool index3 = false;
            //for (int i = 0; i < list.Count(); i++)
            //{
            //    if (index3 == false && list[i] == "Appendix A Architecture Archaeology")
            //    {
            //        list.Insert(i + 1, "");
            //        index3 = true;
            //        i++;
            //    }
            //}

            //contents.Clear();

            //bool BookCLeanArchitectureEncontrado = false;
            //List<string> BookCLeanArchitecture = new List<string>();
            //for (int i = 0; i < list.Count(); i++)
            //{

            //    if (list[i] != "Appendix A Architecture Archaeology" && BookCLeanArchitectureEncontrado == false)
            //    {
            //        contents.Add(list[i]);
            //        list.RemoveAt(i);
            //        i--;
            //    }
            //    else
            //    {
            //        BookCLeanArchitectureEncontrado = true;
            //    }
            //}

            //for (int i = 0; i < contents.Count(); i++)
            //{
            //    if (contents[i].Contains("Chapter") || contents[i].Contains("Part"))
            //    {
            //    }
            //    else
            //    {
            //        contents[i] = contents[i].ToUpper();
            //    }
            //}

            //this.Write(list);
            //MessageBox.Show("Terminado");
        }

        private void Write(List<string> strings)
        {
            strings.Insert(0, "Clean Architecture");
            strings.Insert(1, "");

            using (StreamWriter sw = new StreamWriter(lblUbicacionGuardarEn.Text + "/archivo.txt"))
            {
                foreach (string s in strings)
                {
                    sw.WriteLine(s);
                }
            }
        }

        private void Translate(List<string> strings)
        {
            
        }

        private List<string> OrdarLista(List<string> contenidos, List<string> indices)
        {
            StringBuilder parrafos = new StringBuilder();
            List<string> listaOrdenada = new List<string>();
            bool indexEncontrado = false;

            for (int i = 0; i < indices.Count(); i++)
            {
                var indice = indices[i];
                if (i < indice.Count())
                {
                    var secondIndex = indice[i + 1];
                    for (int j = 0; i < contenidos.Count(); j++)
                    {
                        var contenido = contenidos[j];
                        
                        if (indice == contenido && indexEncontrado == false)
                        {
                            parrafos.Append(j.ToString());
                            indexEncontrado = true;
                        }
                        else
                        {
                            if (indexEncontrado == true)
                            {
                                if (contenido == "")
                                {
                                    parrafos.AppendLine();
                                    listaOrdenada.Add(parrafos.ToString());
                                    parrafos.Clear();
                                    indexEncontrado = false;
                                    
                                }
                                else
                                { 
                                    parrafos.Append(contenido);
                                }
                            }
                        }
                    }
                }

            }
            return listaOrdenada;
        }

        public void GetContenidostenidosFromPDF()
        {
            var pdfDocument = new PdfDocument(new PdfReader(urlReadFIle));
            for (int i = 1; i <= pdfDocument.GetNumberOfPages(); i++)
            {
                var pagePDF = pdfDocument.GetPage(i);

                string pageText = PdfTextExtractor.GetTextFromPage(pagePDF);

                Contenidos.Add(pageText);
            }
            pdfDocument.Close();
        }

        public void RemoveNotImportants()
        {
            throw new NotImplementedException();
        }

        public void EditParts()
        {
            throw new NotImplementedException();
        }

        public void EditChapters()
        {
            throw new NotImplementedException();
        }

        public void EditThemes()
        {
            throw new NotImplementedException();
        }

        public void TranslateToSpanish()
        {
            throw new NotImplementedException();
        }

        public void FormatterMD()
        {
            throw new NotImplementedException();
        }

        public void SaveDocument()
        {
            throw new NotImplementedException();
        }

        public void CompleteSteps()
        {
            GetContenidostenidosFromPDF();
        }

        private void btnAbrirUbicacion_Click(object sender, EventArgs e)
        {
            TranslateAndConvertPDFtoMD translateAndConvertPDFtoMD = new TranslateAndConvertPDFtoMD
                (lblUbicacionLeerEn.Text, lblUbicacionGuardarEn.Text, txtNombreArchivo.Text);

            translateAndConvertPDFtoMD.Resolve();
        }
    }
}