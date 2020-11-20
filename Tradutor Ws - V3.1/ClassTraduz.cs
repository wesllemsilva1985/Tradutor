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
    public class ClassTraduz
    {
        public static TextIdiomaDetect { get; set; }
        public static TextIdSaida { get; set; }
        
        private static readonly string subscriptionKey = "b38bee5190mshb800f582c906e34p1004efjsn1d9fef204f63";
        private static readonly string endpoint = "https://microsoft-translator-text.p.rapidapi.com/";
        private static readonly string location = "AWS - ap-southeast-1";

        public static void TraduzClic(string ie, string is)
        {
            FrmLoanding FrmL = new FrmLoanding();
            FrmL.Show();

            var Ie = Program.form1.TextIdiomaDetect.Text; //Idioma de entrada
            var Is = Program.form1.TextIdSaida.Text; //Idioma de saida

            var route = "translate?to=" + Is + "&api-version=3.0&from=" + Ie + "&profanityAction=NoAction&textType=plain";

            var textToTranslate = Program.form1.TextFrom.Text;
            var body = new object[] { new { Text = textToTranslate } };
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
            S = S.Remove(0, 48);
            S = S.Remove(S.Length - 23);
            S = S.Replace("\"", "'");

            string json = @"{" + S + "}";

            TradutorSaida tradu = JsonConvert.DeserializeObject<TradutorSaida>(json);
            string name = tradu.text;

            Program.form1.TextTo.Text = name;

            FrmL.Close();
        }
    }
}
