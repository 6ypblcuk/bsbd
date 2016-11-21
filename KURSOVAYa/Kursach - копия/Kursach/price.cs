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
using Newtonsoft.Json;
using System.IO;

namespace Kursach
{
    public partial class price : Form
    {
        public static int id_user;
        public static int id_order;
        public static string role;
        public static bool flag;
        public price()
        {
            InitializeComponent();
            if (role == "employee")
                groupBox2.Visible = true;
        }
        private bool check_textbox()
        {
            if (namefirmsCB.Text == "")
            {
                MessageBox.Show("Выберите название фирмы!!!");
                return false;
            }
            if (CountsTB.Text == "")
            {
                MessageBox.Show("Введите количество!!!");
                return false;
            }
            if (Convert.ToInt32(CountsTB.Text) < 1)
            {
                MessageBox.Show("Количество должно быть больше 0!!!");
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

        [JsonObject(MemberSerialization.OptIn)]
        struct data_drug
        {
            [JsonProperty("id_drug")]
            public int iddrug { get; set; }
            [JsonProperty("name_drug")]
            public string name_drug { get; set; }
            [JsonProperty("pharm_group")]
            public string pharmgr { get; set; }
            [JsonProperty("exp_date")]
            public int expdate { get; set; }
            [JsonProperty("form")]
            public string form { get; set; }

        }

        [JsonObject(MemberSerialization.OptIn)]
        struct data_firms
        {
            [JsonProperty("name_firm")]
            public string name_firm { get; set; }
        }

        [JsonObject(MemberSerialization.OptIn)]
        struct data_card
        {
            [JsonProperty("card")]
            public string default_card { get; set; }
        }

        [JsonObject(MemberSerialization.OptIn)]
        struct data_price
        {
            [JsonProperty("prcounts")]
            public decimal price { get; set; }
        }

        struct data_order
        {
            [JsonProperty("id_order")]
            public int id_order { get; set; }
        }


        public string error;

        public bool Response_price()
        {
            try
            {
                WebRequest req = WebRequest.Create(String.Format("http://localhost/price.php?action={0}&counts={1}&id_drug={2}&name_firm={3}", "price_count",CountsTB.Text, NDrugTB.Text, namefirmsCB.Text));
                WebResponse resp = req.GetResponse();
                Stream stream = resp.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                var responseString = sr.ReadToEnd();
                Newtonsoft.Json.Linq.JObject obj = Newtonsoft.Json.Linq.JObject.Parse(responseString);
                type_error[] objArr = JsonConvert.DeserializeObject<type_error[]>(obj["type"].ToString());
                foreach (type_error myJsonObj in objArr)
                    error = myJsonObj.error;
                if (error != "much")
                {
                    data_price[] objdata = JsonConvert.DeserializeObject<data_price[]>(obj["data"].ToString());
                    foreach (data_price myJsonObj in objdata)
                        PriceTB.Text = Convert.ToString(myJsonObj.price);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                error = "error";
                MessageBox.Show(ex.Message);
                return false;
            }
        }



        public bool Response_order(string card)
        {
            try
            {
                if (!flag)
                {
                    WebRequest req_order = WebRequest.Create(String.Format("http://localhost/price.php?action={0}&flag={1}&id_user={2}&summ={3}&card={4}", "order", "false",id_user,0,card));
                    WebResponse resp = req_order.GetResponse();
                    Stream stream = resp.GetResponseStream();
                    StreamReader sr = new StreamReader(stream);
                    var responseString = sr.ReadToEnd();
                    Console.WriteLine("\n" + responseString);
                    Newtonsoft.Json.Linq.JObject obj = Newtonsoft.Json.Linq.JObject.Parse(responseString);
                    type_error[] objArr = JsonConvert.DeserializeObject<type_error[]>(obj["type"].ToString());
                    foreach (type_error myJsonObj in objArr)
                        error = myJsonObj.error;
                    if (error != "error")
                    {
                        data_order[] objdata = JsonConvert.DeserializeObject<data_order[]>(obj["data"].ToString());
                        foreach (data_order myJsonObj in objdata)
                            id_order = myJsonObj.id_order;
                        return true;
                    }
                    return false;
                
                }
                else
                {
                    WebRequest req = WebRequest.Create(String.Format("http://localhost/price.php?action={0}&flag={1}&id_order={2}&name_drug={3}&id_drug={4}&counts={5}&summ={6}&name_firm={7}", "order", "true", id_order, DrugNameTB.Text,NDrugTB.Text,CountsTB.Text,PriceTB.Text, namefirmsCB.Text));
                    WebResponse resp = req.GetResponse();
                    Stream stream = resp.GetResponseStream();
                    StreamReader sr = new StreamReader(stream);
                    var responseString = sr.ReadToEnd();
                    Console.WriteLine("\n" + responseString);
                    Newtonsoft.Json.Linq.JObject obj = Newtonsoft.Json.Linq.JObject.Parse(responseString);
                    type_error[] objArr = JsonConvert.DeserializeObject<type_error[]>(obj["type"].ToString());
                    foreach (type_error myJsonObj in objArr)
                        error = myJsonObj.error;
                    if (error != "error")
                        return true;
                    return false;
                }
                
            }
            catch (Exception ex)
            {
                error = "error";
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public bool Response_card()
        {
            try
            {
                WebRequest req = WebRequest.Create(String.Format("http://localhost/price.php?action={0}&id_user={1}", "card",id_user));
                WebResponse resp = req.GetResponse();
                Stream stream = resp.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                var responseString = sr.ReadToEnd();
                Console.WriteLine("\n" + responseString);
                Newtonsoft.Json.Linq.JObject obj = Newtonsoft.Json.Linq.JObject.Parse(responseString);
                type_error[] objArr = JsonConvert.DeserializeObject<type_error[]>(obj["type"].ToString());
                foreach (type_error myJsonObj in objArr)
                    error = myJsonObj.error;
                if (error != "error")
                {
                    data_card[] objdata = JsonConvert.DeserializeObject<data_card[]>(obj["data"].ToString());
                    foreach (data_card myJsonObj in objdata)
                        CardTB.Text = myJsonObj.default_card;
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                error = "error";
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool Response_drug()
        {
            try
            {
                WebRequest req = WebRequest.Create(String.Format("http://localhost/price.php?action={0}&name_drug={1}", "search_drug",NameDrugGTB.Text));
                WebResponse resp = req.GetResponse();
                Stream stream = resp.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                var responseString = sr.ReadToEnd();
                Newtonsoft.Json.Linq.JObject obj = Newtonsoft.Json.Linq.JObject.Parse(responseString);
                type_error[] objArr = JsonConvert.DeserializeObject<type_error[]>(obj["type"].ToString());
                foreach (type_error myJsonObj in objArr)
                    error = myJsonObj.error;
                if (error != "error")
                {
                    data_drug[] objdata = JsonConvert.DeserializeObject<data_drug[]>(obj["data"].ToString());
                    foreach (data_drug myJsonObj in objdata)
                    {
                        NDrugTB.Text = Convert.ToString(myJsonObj.iddrug);
                        DrugNameTB.Text = myJsonObj.name_drug;
                        PharmGrTB.Text = myJsonObj.pharmgr;
                        ExpDateTB.Text = Convert.ToString(myJsonObj.expdate);
                        formTB.Text = myJsonObj.form;
                    }
                    data_firms[] objfirm = JsonConvert.DeserializeObject<data_firms[]>(obj["firm_name"].ToString());
                    namefirmsCB.Items.Clear();
                    foreach (data_firms myJsonObj in objfirm)
                        namefirmsCB.Items.Add(myJsonObj.name_firm);
                    return true;
                }
                else
                {
                    MessageBox.Show("Извините, пока нет сведений о фирме-поставщике для данного препарата");
                    return false;
                }
            }
            catch (Exception ex)
            {
                error = "error";
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void default_cardB_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                if (!Response_card())
                {
                    MessageBox.Show("Карта пользователя не указана! Введите свои данные!");
                    return;
                }
            }
        }

        private void ShowPriceB_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                this.CardTB.Enabled = false;
                default_cardB.Enabled = false;
            }
            CardTB.Text= "";
            CountsTB.Text = "";
            PriceTB.Text = "";
            if (NameDrugGTB.Text == "")
            {
                MessageBox.Show("Введите данные для поиска");
                return;
            }
            namefirmsCB.Items.Clear();
            if (!Response_drug())
            {
                NameDrugGTB.Text = "";
                NDrugTB.Text = "";
                DrugNameTB.Text = "";
                PharmGrTB.Text = "";
                ExpDateTB.Text = "";
                formTB.Text = "";
                getprice.Enabled = false;
                return;
            }
            else
                getprice.Enabled = true;
        }
         

        private void OrderB_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                if (CardTB.Text.StartsWith("*"))
                {
                    if (Response_order("default"))
                    {
                        flag = true;
                        Response_order("default");
                        this.CardTB.Enabled = false;
                        default_cardB.Enabled = false;
                    }
                    else
                        return;
                }
                else
                {
                    if (Response_order(CardTB.Text))
                    {
                        flag = true;
                        Response_order(CardTB.Text);
                        this.CardTB.Enabled = false;
                        default_cardB.Enabled = false;
                        
                    }
                    else
                        return;
                }
            }
            else
                Response_order("default");
            foreach (Form f in Application.OpenForms)
                if (f.Name == "order_drugs")
                    return;
            order_drugs od = new order_drugs();
            od.Show();
        }

      

       
        private void getprice_Click(object sender, EventArgs e)
        {
            if (check_textbox())
            {
                if (!Response_price())
                {
                    MessageBox.Show("Такого количества препаратов нет на складе!");
                    return;
                }
                if (role=="user")
                    OrderB.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            price_change pc = new price_change();
            pc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_price ap = new add_price();
            ap.ShowDialog();
        }
    }
}