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
    public partial class drug_composition : Form
    {
        public static int id_drug;
        public static string role;

        [JsonObject(MemberSerialization.OptIn)]
        struct type_error
        {
            [JsonProperty("error")]
            public string error { get; set; }
        }

        [JsonObject(MemberSerialization.OptIn)]
        struct data_order
        {
            [JsonProperty("composition")]
            public string comp { get; set; }
        }

        private string error;

        private bool Response(string action,string info)
        {
            try
            {
                WebRequest req = WebRequest.Create(String.Format("http://localhost/drugs.php?action={0}&id_drug={1}&info={2}&action1={3}","composition",id_drug,info,action ));
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
                    if (action != "save")
                    {
                        data_order[] objdata = JsonConvert.DeserializeObject<data_order[]>(obj["data"].ToString());
                        foreach (data_order myJsonObj in objdata)
                            compTB.Text = myJsonObj.comp;
                    }
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
        public drug_composition()
        {
            InitializeComponent();
            if (role == "user")
                SaveItemNavig.Enabled = false;
            bool flag = Response("select","0");

        }

        private void SaveItemNavig_Click(object sender, EventArgs e)
        {
            if (compTB.Text == "")
            {
                MessageBox.Show("Введите состав!");
                return;
            }
            if (Response("save",compTB.Text))
                MessageBox.Show("Изменено!");
        }

    }
}