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
    public class ListaId
    {
        public string Cod { get; set; }
        public string Nome { get; set; }

    }


    class ClassIdiomas
    {
        private static readonly string subscriptionKey = "b38bee5190mshb800f582c906e34p1004efjsn1d9fef204f63";
        private static readonly string endpoint = "https://microsoft-translator-text.p.rapidapi.com/";
       

        //Inicia a Leitura do arquivo de idiomas em formato Json
        public static string Idiomas()
        {

            string route = "languages?api-version=3.0";
            var client = new HttpClient();
            var request = new HttpRequestMessage();

            request.Method = HttpMethod.Get;
            request.RequestUri = new Uri(endpoint + route);
            request.Headers.Add("accept-language", "pt");
            request.Headers.Add("x-rapidapi-key", subscriptionKey);
            request.Headers.Add("x-rapidapi-host", "microsoft-translator-text.p.rapidapi.com");


            HttpResponseMessage thing = client.SendAsync(request).Result;
            string actualResponse = thing.Content.ReadAsStringAsync().Result;

            var Saida = JsonConvert.DeserializeObject(actualResponse);

            string S = Saida.ToString();
            S = S.Replace("\"", "'");

            string json = @"" + S + "";

            return (json);

        }

        //Retorna somente o nome e codigo do idioma
        public static void SelecionaIdioma()
        {
            String Js = Idiomas(); /*Arquivo Json deserializado do metodo a cima*/

            //Cria Lista
            var lista = new List<ListaId>();
            lista.Clear();

            //Inicia a leitura do arquivo json 
            using (var reader = new JsonTextReader(new StringReader(Js)))
            {
                string id = string.Empty; /*id do idioma*/
                string nome = string.Empty; /*nome do idioma*/

                var i = 0;
                while (reader.Read())
                {
                    if (reader.TokenType == JsonToken.PropertyName)
                    {
                        switch (reader.Value.ToString())
                        {
                            case "translation": break;
                            case "transliteration": Finalizar(); return;
                            case "dictionary": return;
                            case "name": i++; break;
                            case "nativeName": i++; break;
                            case "dir": break;
                            default: id = reader.Value.ToString(); break;

                        }
                    }
                    if (reader.TokenType == JsonToken.String)
                    {

                        if (i == 1)
                        {

                            nome = reader.Value.ToString() + Environment.NewLine;
                            i = -1;
                            lista.Add(new ListaId()
                            {
                                Cod = id,
                                Nome = nome
                            });


                        }
                    }
                }
               
            }
            void Finalizar()
            {
                var Func = Program.form1.TextFunc.Text;
                if (lista.Count > 0)
                {

                   

                   
                    //Caso a função chamada seja Inicio (guardada em um campo oculto do formulario) executa abaixo
                    if (Func == "Inicio")
                    {
                        Program.form1.CboFrom.Items.Clear();
                        Program.form1.CboTo.Items.Clear();
                        foreach (var Value in lista)
                        {

                            string Valor = Value.Nome;
                            PreencheCombo(Valor);
                          
                        }
                        return;
                    }

                    //Caso a função chamada seja Detecta (guardada em um campo oculto do formulario) executa abaixo
                    if (Func == "Detecta")
                    {
                        foreach (var It in lista)
                        {
                          
                            if (Program.form1.TextIdiomaDetect.Text == It.Cod)
                            {
                                Program.form1.CboFrom.Text = "";
                                Program.form1.LblIdiFrom.Text = "Traduzindo do idioma: " + It.Nome;
                                Program.form1.CboFrom.SelectedText = It.Nome;
                               
                            }
                        }
                        return;
                    }
                                       
                    

                    //Função executada quando o idioma é selecionado no combo 2
                    if (Func == "SaidaOk")
                    {
                        foreach (var It in lista)
                        {
                            
                            if (Program.form1.CboTo.Text == It.Nome)
                            {


                                Program.form1.TextIdSaida.Text = It.Cod;
                                ClassTraduz.TraduzClic();

                            }
                        }
                        return;
                    }

                }
            }

        }

        //Preenche os Combos com os nomes dos idiomas
        internal static string PreencheCombo(string value)
        {
            Program.form1.CboFrom.Items.Add(value);
            Program.form1.CboTo.Items.Add(value);
            return value;

          

        }
    }
    
}