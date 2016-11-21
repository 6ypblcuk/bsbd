using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace Kursach
{
    public partial class add_firm : Form
    {
         public add_firm()
        {
            InitializeComponent();
        }

        public bool check_box()
        {
            Regex checkSpace = new Regex(@"[ ]+$");
            Regex check = new Regex(@"[0-9.]");
            Regex checkPhone = new Regex(@"[0-9.x)(-]");
            if (checkSpace.Match(phoneTB.Text).Success || checkSpace.Match(nameTB.Text).Success ||
                checkSpace.Match(addressTB.Text).Success || checkSpace.Match(checkTB.Text).Success ||
                checkSpace.Match(bankTB.Text).Success || checkSpace.Match(siteTB.Text).Success ||
                String.IsNullOrEmpty(bankTB.Text) || String.IsNullOrEmpty(nameTB.Text) || String.IsNullOrEmpty(phoneTB.Text) ||
                String.IsNullOrEmpty(addressTB.Text) || String.IsNullOrEmpty(checkTB.Text))
            {
                MessageBox.Show("Поля не могут быть пустыми или заканчиваться пробелом!");
                return false;
            }
            else if (!checkPhone.Match(phoneTB.Text).Success)
            {
                MessageBox.Show("Телефон указан неправильно!");
                return false;
            }
            else if (!check.Match(checkTB.Text).Success)
            {
                MessageBox.Show("Номер счета указан неправильно!");
                return false;
            }
            return true;
        }

        [JsonObject(MemberSerialization.OptIn)]
        struct type_error
        {
            [JsonProperty("error")]
            public string error { get; set; }
        }
        public string error;

        private void cancelTB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check_box())
            {
                Response();
                if (error == "success")
                {
                    MessageBox.Show("Фирма добавлена!");
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Ошибка!Введенные данные принадлежат другой фирме!");
                    return;
                }
            }
        }

        public void Response()
        {
            try
            {
                string s = String.Format("http://localhost/add.php?name={0}&address={1}&phone={2}&bank={3}&check={4}&site={5}&action={6}", nameTB.Text, addressTB.Text, phoneTB.Text, bankTB.Text, checkTB.Text, siteTB.Text,"firm");
                WebRequest req = WebRequest.Create(s);
                WebResponse resp = req.GetResponse();
                Stream stream = resp.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                var responseString = sr.ReadToEnd();
                Newtonsoft.Json.Linq.JObject obj = Newtonsoft.Json.Linq.JObject.Parse(responseString);
                type_error[] objArr = JsonConvert.DeserializeObject<type_error[]>(obj["type"].ToString());
                foreach (type_error myJsonObj in objArr)
                    error = myJsonObj.error;
            }
            catch (Exception ex)
            {
                error = "error";
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }
    }
}
