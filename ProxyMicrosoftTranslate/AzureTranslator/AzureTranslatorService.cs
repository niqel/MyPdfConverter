using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyMicrosoftTranslate.AzureTranslator
{
    public class AzureTranslatorService : IAzureTranslatorService
    {
        static string key = "646ec46d623e41f59d3532b7d8065ae2";
        static string EndPoint = "https://api.cognitive.microsofttranslator.com/translate?api-version=3.0";
        static string ConvertTo = "&to-es";

        public async Task<List<AzureTranslatorModel>> Execute(List<AzureTranslatorRequestBody> requestBody)
        {
            try
            {
                var body = requestBody;
                var requestBodyObject = JsonConvert.SerializeObject(body);
                DateTime
                using (var client = new HttpClient())
                {
                    using (var request = new HttpRequestMessage())
                    { 
                        request.Method = HttpMethod.Post;
                        request.RequestUri = new Uri($"{EndPoint}{ConvertTo}");
                        request.Content = new StringContent(requestBodyObject, Encoding.UTF8, "application/son");
                        request.Headers.Add("Ocp-Apim-Subscription-key", key);

                        var response = await client.SendAsync(request);

                        if (response.IsSuccessStatusCode)
                        {
                            var responseBody = await response.Content.ReadAsStringAsync();
                            var model = JsonConvert.DeserializeObject<List<AzureTranslatorModel>>(responseBody);
                        }
                        return new List<AzureTranslatorModel>();
                    }
                }
            }
            catch (Exception)
            {
                return new List<AzureTranslatorModel>();
            }
        }
    }
}
