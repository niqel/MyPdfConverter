using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyMicrosoftTranslate.AzureTranslator
{
    public class AzureTranslatorModel
    {
        public DetectedLanguaje detectedLanguaje { get; set; }
        public List<Translation> translations { get; set; }
    }

    public class Translation
    {
        public string text { get; set; }
        public string to { get; set; }
    }

    public class DetectedLanguaje
    { 
        public string languaje { get; set; }
        public double score { get; set; }
    }
}
