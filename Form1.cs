using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://text-translator2.p.rapidapi.com/getLanguages"),
                Headers =
    {
        { "X-RapidAPI-Key", "9c1dd2b648msh68eee7e8e3df56ep161620jsn33b4360ec5c9" },
        { "X-RapidAPI-Host", "text-translator2.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                // textBox2.Text = (body);
                GetLanguage lang = JsonConvert.DeserializeObject<GetLanguage>(body);
                GetLanguage lang2 = JsonConvert.DeserializeObject<GetLanguage>(body);
                inputLanguage.DataSource = lang.Data.Languages;
                inputLanguage.ValueMember = "Code";
                inputLanguage.DisplayMember = "Name";
                targetLanguage.DataSource = lang2.Data.Languages;
                targetLanguage.ValueMember = "Code";
                targetLanguage.DisplayMember = "Name";
            }
        }

       
        private void button2_Click(object sender, EventArgs e)
        {

            string inputLang = inputLanguage.Text;
            inputLanguage.Text = targetLanguage.Text;
            targetLanguage.Text = inputLang;
            string tmp = inputText.Text;
            inputText.Text = targetText.Text;
            targetText.Text = tmp;
            inputText_TextChanged(null, null);

        }


        private void targetLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!String.IsNullOrWhiteSpace(inputText.Text))
            {
                inputText_TextChanged(null, null);

            }
        }

        private async void inputText_TextChanged(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrEmpty(inputText.Text))
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri("https://text-translator2.p.rapidapi.com/translate"),
                    Headers =
            {
                { "X-RapidAPI-Key", "9c1dd2b648msh68eee7e8e3df56ep161620jsn33b4360ec5c9" },
                { "X-RapidAPI-Host", "text-translator2.p.rapidapi.com" },
            },
                    Content = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                { "source_language", inputLanguage.SelectedValue.ToString() },
                { "target_language", targetLanguage.SelectedValue.ToString() },
                { "text", inputText.Text },
            }),
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    DataDTO data = JsonConvert.DeserializeObject<DataDTO>(body);
                    string translate = Regex.Replace(data.data.TranslatedText, @"\\u([\da-f]{4})", m => ((char)Convert.ToInt32(m.Groups[1].Value, 16)).ToString());


                    targetText.Text = translate;
                }
            }
            else
            {
                targetText.Clear();
            }
           
        }
    }
}
