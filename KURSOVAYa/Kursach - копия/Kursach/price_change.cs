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
    public partial class price_change : Form
    {
        private int current_price;
        public price_change()
        {
            current_price = 0;
            InitializeComponent();
            NameDrugTB.Text = "";
            NameFirmTB.Text = "";
            CountsTB.Text = "";
            Response("price_select");
            refresh();
            if (price_list.Count > 0)
                ShowList(current_price);
            
        }
        [JsonObject(MemberSerialization.OptIn)]
        struct type_error
        {
            [JsonProperty("error")]
            public string error { get; set; }
        }

        [JsonObject(MemberSerialization.OptIn)]
        struct data_price
        {
            [JsonProperty("name_drug")]
            public string name_drug { get; set; }
            [JsonProperty("name_firm")]
            public string name_firm { get; set; }
            [JsonProperty("counts")]
            public int counts { get; set; }
        }

        private class data_prices
        {
            public string name_drug { get; set; }
            public string name_firm { get; set; }
            public int counts { get; set; }
        }
        private void refresh()
        {
            if (price_list.Count - 1 < 1)
            {
                PrevItem.Enabled = false;
                FirstItem.Enabled = false;
                NextItem.Enabled = false;
                LastItem.Enabled = false;
            }
            else
            {
                if (current_price - 1 < 0)
                {
                    PrevItem.Enabled = false;
                    FirstItem.Enabled = false;
                    NextItem.Enabled = true;
                    LastItem.Enabled = true;
                }
                if (current_price == price_list.Count - 1)
                {
                    PrevItem.Enabled = true;
                    FirstItem.Enabled = true;
                    NextItem.Enabled = false;
                    LastItem.Enabled = false;
                }
            }

        }
        List<data_prices> price_list = new List<data_prices>();
        private string error;
        private void NextItem_Click(object sender, EventArgs e)
        {
            current_price++;
            ShowList(current_price);
            PrevItem.Enabled = true;
            FirstItem.Enabled = true;
            refresh();
        }

        private void PrevItem_Click(object sender, EventArgs e)
        {
            current_price--;
            ShowList(current_price);
            NextItem.Enabled = true;
            LastItem.Enabled = true;
            refresh();
        }

        private void LastItem_Click(object sender, EventArgs e)
        {
            current_price = price_list.Count - 1;
            ShowList(current_price);
            refresh();
        }

        private void FirstItem_Click(object sender, EventArgs e)
        {
            current_price = 0;
            ShowList(current_price);
            refresh();
        }

        private void ShowList(int i)
        {
            NameDrugTB.Text = price_list[i].name_drug;
            NameFirmTB.Text = price_list[i].name_firm;
            CountsTB.Text = Convert.ToString(price_list[i].counts);
        }

        private void Response(string action)
        {
            try
            {
                WebRequest req = WebRequest.Create(String.Format("http://localhost/price.php?action={0}&name_drug={1}&name_firm={2}&counts={3}", action,NameDrugTB.Text,NameFirmTB.Text,CountsTB.Text));
                WebResponse resp = req.GetResponse();
                Stream stream = resp.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                var responseString = sr.ReadToEnd();
                Newtonsoft.Json.Linq.JObject obj = Newtonsoft.Json.Linq.JObject.Parse(responseString);
                type_error[] objArr = JsonConvert.DeserializeObject<type_error[]>(obj["type"].ToString());
                foreach (type_error myJsonObj in objArr)
                    error = myJsonObj.error;
                price_list.Clear();
                if (error != "error")
                {
                    data_price[] objdata = JsonConvert.DeserializeObject<data_price[]>(obj["data"].ToString());
                    foreach (data_price myJsonObj in objdata)
                    {
                        data_prices newPrice = new data_prices();
                        newPrice.name_drug = myJsonObj.name_drug;
                        newPrice.name_firm = myJsonObj.name_firm;
                        newPrice.counts = myJsonObj.counts;
                        price_list.Add(newPrice);
                    }
                }
                else
                    return;
                BindingSource bs = new BindingSource();
                bs.DataSource = price_list;
            }
            catch (Exception ex)
            {
                error = "error";
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void refreshBindingNavigator_Click(object sender, EventArgs e)
        {
            Response("price_select");
            ShowList(current_price);
        }

        private void SaveItemNavig_Click(object sender, EventArgs e)
        {
            Regex check = new Regex(@"[0-9]");
            if (check.Match(CountsTB.Text).Success)
                Response("price_save");
            else
                MessageBox.Show("Количество должно быть числом!!!");
        }
       

    }
}
