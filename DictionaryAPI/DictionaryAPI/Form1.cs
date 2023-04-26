using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DictionaryAPI
{
    public partial class FrmMain : Form
    {
        private readonly HttpClient _httpClient;
        List<Language> _list = new List<Language>()
        {
            new Language(){ Key = "en" },
            new Language(){ Key = "vi" },
        };
        public FrmMain()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            cbbLang.DataSource = _list;
            cbbLang.DisplayMember = "Key";
        }
        private void CheckRule()
        {
            if (cbbLang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập chọn ngôn ngữ!"); return;
            }
            if (rtxtValue.Text == "")
            {
                MessageBox.Show("Bạn phải nhập từ hoặc câu để tra cứu!");
                return;
            }

        }
        private async void btnLookup_ClickAsync(object sender, EventArgs e)
        {
            CheckRule();
            flpResult.Controls.Clear();
            // Lấy giá trị từ textbox và ngôn ngữ từ combobox
            string value = rtxtValue.Text;
            string lang = cbbLang.Text;

            // Thực hiện yêu cầu HTTP GET đến API Tracau
            string apiUrl = $"https://api.tracau.vn/WBBcwnwQpV89/s/{value}/{lang}";
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            // Đọc nội dung phản hồi và hiển thị kết quả lên textbox
            string responseContent = await response.Content.ReadAsStringAsync();
            // xóa bỏ các thẻ html
            string plainText = Regex.Replace(responseContent, "<.*?>", string.Empty);
            JObject json = JObject.Parse(responseContent);
            // Lấy giá trị trường "sentences"
            JArray sentences = (JArray)json["sentences"];
            foreach (JObject sentence in sentences)
            {
                //// Lấy giá trị của trường "_id"
                //string id = (string)sentence["_id"];

                //// Lấy giá trị của trường "fields"
                //JObject fields = (JObject)sentence["fields"];

                //// Lấy giá trị của trường "en"
                //string en = (string)fields["en"];

                //// Lấy giá trị của trường "vi"
                //string vi = (string)fields["vi"];

                //MessageBox.Show($"_id: {id}");
                //MessageBox.Show($"en: {en}");
                //MessageBox.Show($"vi: {vi}");
                string text = (string)sentence["fields"]["vi"];
                Label label = new Label();
                label.Text = text;
                label.ForeColor = Color.Red;
                flpResult.Controls.Add(label); // thêm Label vào flp
            }
        }
    }
}
