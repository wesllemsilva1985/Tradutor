using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;

namespace Tradutor_Ws___V3._1
{
    public class TradutorSaida
    {
        public string text { get; set; }
        public string To { get; set; }
        public string language { get; set; }


    }
    class ClassDetectaIdioma
    {
        private static readonly string subscriptionKey = "b38bee5190mshb800f582c906e34p1004efjsn1d9fef204f63";
        private static readonly string endpoint = "https://microsoft-translator-text.p.rapidapi.com/";
        private static readonly string location = "AWS - ap-southeast-1";

        public static void DetectaIdioma()
        {
            
            string route = "Detect?api-version=3.0";
            string textToTranslate = Program.form1.TextFrom.Text; /*Recupera o texto inserido no campo a ser traduzido*/
            object[] body = new object[] { new { Text = textToTranslate } };
            var requestBody = JsonConvert.SerializeObject(body);
            var client = new HttpClient();
            var request = new HttpRequestMessage();

            request.Method = HttpMethod.Post;
            request.RequestUri = new Uri(endpoint + route);
            request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
            request.Headers.Add("x-rapidapi-key", subscriptionKey);
            request.Headers.Add("x-rapidapi-Region", location);


            HttpResponseMessage thing = client.SendAsync(request).Result;
            string actualResponse = thing.Content.ReadAsStringAsync().Result;

            var Saida = JsonConvert.DeserializeObject(actualResponse);
            string S = Saida.ToString();
            S = S.Remove(0, 10);
            S = S.Remove(S.Length - 7);
            S = S.Replace("\"", "'");


            string json = @"{" + S + "}";

            TradutorSaida tradu = JsonConvert.DeserializeObject<TradutorSaida>(json);
            string name = tradu.language;

            //Insere o codigo do DicIdioma detectado no campo oculto do formulario

            if (Program.form1.TextIdiomaDetect.Text != name)
            {
               
                Program.form1.TextIdiomaDetect.Text = name;
                Program.form1.TextFunc.Text = "Detecta";
                ClassIdiomas.SelecionaIdioma();
                return;
            }
            else
            {
                
                return;
            }
          
        }
    }
}
