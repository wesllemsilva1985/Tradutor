using System;
using System.Windows;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using RestSharp;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.Data;



namespace Tradutor_Ws___V2._1
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {

        class BlogSites
        {
            public string Name { get; set; }
            public string Language { get; set; }
        }

      

        public MainWindow()
        {
            InitializeComponent();
            
        }

        //Preenche o Combo Box com os idiomas da API
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var client = new RestClient("https://google-translate1.p.rapidapi.com/language/translate/v2/languages?target=pt");
            var request = new RestRequest(Method.GET);
            request.AddHeader("accept-encoding", "application/gzip");
            request.AddHeader("x-rapidapi-key", "b38bee5190mshb800f582c906e34p1004efjsn1d9fef204f63");
            request.AddHeader("x-rapidapi-host", "google-translate1.p.rapidapi.com");
            IRestResponse response = client.Execute(request);


            string Saida = (response.Content);
            Saida = Saida.Replace("\"", "'");
            Saida = Saida.Remove(0, 22);
            string[] words = Saida.Split('{',',','}');

            try
            {



                foreach (var word in words)
                {

                    int soma = Convert.ToInt32(TextConta1.Text);
                    soma = soma + 2;
                    string TotalLinha = soma.ToString();
                    TextConta1.Text = TotalLinha;

                    if (words[soma].Length > 0)
                    {

                        
                        
                        string json = @"{'language':'af', "+words[soma]+"}";
                        BlogSites bsObj = JsonConvert.DeserializeObject<BlogSites>(json);

                        CboFrom.Items.Insert(0, bsObj.Name);
                        CboTo.Items.Insert(0, bsObj.Name);

                       
                    }

                }

            }



            catch { }
        TextLang.Text=Saida;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            BlogSites bsObj = new BlogSites()
            {
                Name = "C-sharpcorner",
                Language = "Share Knowledge"
            };

            // Convert BlogSites object to JOSN string format  
            string jsonData = JsonConvert.SerializeObject(bsObj);

            TextFrom.Text = (jsonData);


          
        }

        //Identifica o idioma digitado na caixa de texto
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                var client = new RestClient("https://google-translate1.p.rapidapi.com/language/translate/v2/detect");
                var request = new RestRequest(Method.POST);
                request.AddHeader("content-type", "application/x-www-form-urlencoded");
                request.AddHeader("accept-encoding", "application/gzip");
                request.AddHeader("x-rapidapi-key", "b38bee5190mshb800f582c906e34p1004efjsn1d9fef204f63");
                request.AddHeader("x-rapidapi-host", "google-translate1.p.rapidapi.com");
                request.AddParameter("application/x-www-form-urlencoded", "q=" + TextFrom.Text + "", ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);

                string Saida = (response.Content);
                Saida = Saida.Replace("\"", "'");
                Saida = Saida.Remove(0, 24);
                string[] words = Saida.Split(',');

                string json = @"{" + words[1] + ",'name':'Afrikaans'}";
                BlogSites bsObj = JsonConvert.DeserializeObject<BlogSites>(json);

                int TextS = Convert.ToInt32(words[1].Length);

                MessageBox.Show(TextS.ToString());
                if (TextS == 15)
                {
                    TextSerial2.Text = bsObj.Language;
                }
            }
            catch { }
        
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            String header = "{'data':{'languages':[{'language':'af','name':'Afrikaans'},";
            MessageBox.Show(header.Remove(0, 22));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MsTrad frm2 = new MsTrad();
            frm2.Show();

            MainWindow frm1 = new MainWindow();
            frm1.Close();
        }
    }
}
