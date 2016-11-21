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
    public partial class add_disease : Form
    {
        public add_disease()
        {
            InitializeComponent();
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
                WebRequest req = WebRequest.Create(String.Format("http://localhost/add.php?name_disease={0}&drugs={1}&id_dis={2}&action={3}",name_disTB.Text,drugsTB.Text,id_disTB.Text,"disease"));
                WebResponse resp = req.GetResponse();
                Stream stream = resp.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                var responseString = sr.ReadToEnd();
                Newtonsoft.Json.Linq.JObject obj = Newtonsoft.Json.Linq.JObject.Parse(responseString);
                type_error[] objArr = JsonConvert.DeserializeObject<type_error[]>(obj["type"].ToString());
                foreach (type_error myJsonObj in objArr)
                    error = myJsonObj.error;
                if (error == "error")
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                error = "error";
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void add_disease_Load(object sender, EventArgs e)
        {

        }

        private void add_dis_Click(object sender, EventArgs e)
        {
            if (name_disTB.Text != "" && drugsTB.Text != "" && id_disTB.Text!="")
            {
                if (Response())
                {
                    MessageBox.Show("Успешно добавлено!");
                    name_disTB.Text = "";
                    drugsTB.Text = "";
                    return;
                }
                else
                {
                    MessageBox.Show("Такой препарат уже существует!");
                    return;
                }
            }
            else
                MessageBox.Show("Заполните все поля!");
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
