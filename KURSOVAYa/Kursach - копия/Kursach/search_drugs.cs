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
    public partial class search_drugs : Form
    {


        public search_drugs()
        {
            InitializeComponent();
        }
        struct type_error
        {
            [JsonProperty("error")]
            public string error { get; set; }
        }

        [JsonObject(MemberSerialization.OptIn)]
        struct data_order
        {
            [JsonProperty("id_drug")]
            public int iddrug { get; set; }
            [JsonProperty("name_drug")]
            public string namedrug { get; set; }
            [JsonProperty("pharm_group")]
            public string pharmgr { get; set; }
            [JsonProperty("form")]
            public string form { get; set; }

        }

        public string error;

        public void Response()
        {
            try
            {
                WebRequest req = WebRequest.Create(String.Format("http://localhost/search.php?search={0}&name={1}", "drug",SearchDrTB.Text));
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
                        NDrugTB.Text = Convert.ToString(myJsonObj.iddrug);
                        NameDrugTB.Text = myJsonObj.namedrug;
                        PharmGrTB.Text = myJsonObj.pharmgr;
                        FormDrTB.Text = myJsonObj.form;
                    }
                }
                else
                {
                    MessageBox.Show("Такого препарата не существует!");
                    NDrugTB.Text = "";
                    NameDrugTB.Text = "";
                    PharmGrTB.Text = "";
                    FormDrTB.Text = "";
                }

            }
            catch (Exception ex)
            {
                error = "error";
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }
        private void SearchDrugB_Click(object sender, EventArgs e)
        {
            Response();
        }

        

      
    }
}
