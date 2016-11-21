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

namespace Kursach
{
    public partial class user_showinfo : Form
    {
        public static int id_user;
        public user_showinfo()
        {
            InitializeComponent();
            Response();
        }
        [JsonObject(MemberSerialization.OptIn)]
        struct type_error
        {
            [JsonProperty("error")]
            public string error { get; set; }
        }
        [JsonObject(MemberSerialization.OptIn)]
        struct data_users
        {
            [JsonProperty("address")]
            public string address { get; set; }
            [JsonProperty("phone")]
            public string phone { get; set; }
            [JsonProperty("info")]
            public string info { get; set; }
            [JsonProperty("fullname")]
            public string fullname { get; set; }
            [JsonProperty("bday")]
            public string bday { get; set; }
            [JsonProperty("default_card")]
            public string default_card { get; set; }
        }

        private string error;

        private void button1_Click(object sender, EventArgs e)
        {
            user_editinfo ei = new user_editinfo();
            ei.ShowDialog();
        }

        private void Response()
        {
            try
            {
                WebRequest req = WebRequest.Create(String.Format("http://localhost/about_user.php?action={0}&iuser={1}", "view",id_user));
                WebResponse resp = req.GetResponse();
                Stream stream = resp.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                var responseString = sr.ReadToEnd();
                Newtonsoft.Json.Linq.JObject obj = Newtonsoft.Json.Linq.JObject.Parse(responseString);
                type_error[] objArr = JsonConvert.DeserializeObject<type_error[]>(obj["type"].ToString());
                foreach (type_error myJsonObj in objArr)
                    error = myJsonObj.error;
                if (error != "null")
                {
                    data_users[] objdata = JsonConvert.DeserializeObject<data_users[]>(obj["data"].ToString());
                    foreach (data_users myJsonObj in objdata)
                    {
                        fioTB.Text = myJsonObj.fullname;
                        addressTB.Text = myJsonObj.address;
                        phoneTB.Text = myJsonObj.phone;
                        infoTB.Text = myJsonObj.info;
                        bdayTB.Text = myJsonObj.bday.ToString();
                        if (myJsonObj.default_card == null)
                            dcTB.Text = "Нет банковской карты";
                        else
                            dcTB.Text = myJsonObj.default_card;
                    }
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                error = "error";
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
