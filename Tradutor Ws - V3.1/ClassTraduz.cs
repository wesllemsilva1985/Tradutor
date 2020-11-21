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
        private static readonly string subscriptionKey = "b38bee5190mshb800f582c906e34p1004efjsn1d9fef204f63";
        private static readonly string endpoint = "https://microsoft-translator-text.p.rapidapi.com/";
        private static readonly string location = "AWS - ap-southeast-1";
        
        // ie = idioma entrada (from), is = idioma saida (to), te = texto entrada (from)
        public static TradutorSaida TraduzClic(string ie, string is, string te)
        {
            FrmLoanding FrmL = new FrmLoanding();
            FrmL.Show();

            var route = "translate?to=" + is + "&api-version=3.0&from=" + ie + "&profanityAction=NoAction&textType=plain";

            var body = new object[] { new { Text = te } };
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

            return JsonConvert.DeserializeObject<TradutorSaida>(json);

            FrmL.Close();
        }
    }
}
