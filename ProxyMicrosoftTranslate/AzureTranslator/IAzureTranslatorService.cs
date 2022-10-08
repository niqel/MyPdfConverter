using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyMicrosoftTranslate.AzureTranslator
{
    public interface IAzureTranslatorService
    {
        Task<List<AzureTranslatorModel>> Execute(List<AzureTranslatorRequestBody> requestBody);
    }
}
