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
    public partial class add_price : Form
    {
        public add_price()
        {
            InitializeComponent();
        }
        private bool check_textbox()
        {
            if (String.IsNullOrWhiteSpace(NameDrugTB.Text))
            {
                MessageBox.Show("Введите название препарата!");
                return false;
            }
            if (String.IsNullOrWhiteSpace(NameFirmTB.Text))
            {
                MessageBox.Show("Введите название фирмы!");
                return false;
            }
            Regex check = new Regex(@"^\d+$");
            Regex checkPrice = new Regex(@"[0-9],[0-9]{1}");
            if ((String.IsNullOrWhiteSpace(CountsTB.Text)) || !(check.Match(CountsTB.Text).Success))
            {
                MessageBox.Show("Некорректный ввод в поле количество!");
                return false;
            }
            else if (Convert.ToInt32(CountsTB.Text) < 1)
            {
                MessageBox.Show("Введите количество препарата больше нуля!");
                return false;
            }

            if (String.IsNullOrWhiteSpace(PriceTB.Text) || !(checkPrice.Match(PriceTB.Text).Success))
            {
                MessageBox.Show("Некорректный ввод в поле цена!(*,?)");
                return false;
            }
            else if (Convert.ToDecimal(CountsTB.Text) <= 0)
            {
                MessageBox.Show("Введите цену больше нуля!");
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
        private string error;

        private bool Response()
        {
            try
            {
                WebRequest req = WebRequest.Create(String.Format("http://localhost/add.php?name_drug={0}&name_firm={1}&counts={2}&price={3}&action={4}", NameDrugTB.Text, NameFirmTB.Text,Convert.ToInt32(CountsTB.Text), Convert.ToDecimal(PriceTB.Text),"price"));
                WebResponse resp = req.GetResponse();
                Stream stream = resp.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                var responseString = sr.ReadToEnd();
                Newtonsoft.Json.Linq.JObject obj = Newtonsoft.Json.Linq.JObject.Parse(responseString);
                type_error[] objArr = JsonConvert.DeserializeObject<type_error[]>(obj["type"].ToString());
                foreach (type_error myJsonObj in objArr)
                    error = myJsonObj.error;
                if (error == "error")
                {
                    MessageBox.Show("Такой препарат для фирмы-поставщика уже существует!");
                    return false;
                }
                if (error == "nope_drug")
                {
                    MessageBox.Show("Такого препарата не существует в БД!");
                    return false;
                }
                if (error == "nope_firm")
                {
                    MessageBox.Show("Такой фирмы не существует в БД!");
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void AddItemNavig_Click(object sender, EventArgs e)
        {
            if (check_textbox())
            {
                if (Response())
                {
                    MessageBox.Show("Успешно добавлено!");
                    NameDrugTB.Text = "";
                    NameFirmTB.Text = ""; CountsTB.Text = ""; PriceTB.Text = ""; 
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
