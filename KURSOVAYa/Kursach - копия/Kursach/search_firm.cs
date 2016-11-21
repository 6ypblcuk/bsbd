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
    public partial class search_firm : Form
    {
        public search_firm()
        {
            InitializeComponent();
        }
        [JsonObject(MemberSerialization.OptIn)]
        struct type_error
        {
            [JsonProperty("error")]
            public string error { get; set; }
        }

        [JsonObject(MemberSerialization.OptIn)]
        struct data_order
        {
            [JsonProperty("id_firm")]
            public int idfirm { get; set; }
            [JsonProperty("name_firm")]
            public string namefirm { get; set; }
            [JsonProperty("phone")]
            public string phone { get; set; }
            [JsonProperty("address")]
            public string address { get; set; }
            [JsonProperty("site")]
            public string site { get; set; }

        }
       
        public string error;

        public void Response()
        {
            try
            {
                WebRequest req = WebRequest.Create(String.Format("http://localhost/search.php?search={0}&name={1}","firm", SearchFirmTB.Text));
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
                    data_order[] objdata = JsonConvert.DeserializeObject<data_order[]>(obj["data"].ToString());
                    foreach (data_order myJsonObj in objdata)
                    {
                        IdFirmTB.Text = Convert.ToString(myJsonObj.idfirm);
                        NameFirmTB.Text = myJsonObj.namefirm;
                        PhoneTB.Text = myJsonObj.phone;
                        AddressTB.Text = myJsonObj.address;
                        SiteTB.Text = myJsonObj.site;
                    }
                }
                else
                {
                    MessageBox.Show("Такой фирмы не существует!");
                    IdFirmTB.Text = "";
                    NameFirmTB.Text = "";
                    PhoneTB.Text = "";
                    AddressTB.Text = "";
                    SiteTB.Text = "";
                }


            }
            catch (Exception ex)
            {
                error = "error";
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }
       
        private void SearchFirmB_Click(object sender, EventArgs e)
        {
            Response();
        }
        
    }
}