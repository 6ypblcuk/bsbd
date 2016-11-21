using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Data;
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
    public partial class enter : Form
    {
        private int id_session;
        private string role;
        private int id_user;

        public enter()
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
        struct data_user
        {
            [JsonProperty("id_user")]
            public int idu { get; set; }
            [JsonProperty("role")]
            public string role_u { get; set; }
            [JsonProperty("id_session")]
            public int ids { get; set; }
        }
        public string error;
        private void Response(string email, string password)
        {
            try
            {
                WebRequest req = WebRequest.Create(String.Format("http://localhost/login.php?email={0}&password={1}", email, password));
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
                    data_user[] objdata = JsonConvert.DeserializeObject<data_user[]>(obj["data"].ToString());
                    foreach (data_user myJsonObj in objdata)
                    {
                        id_user = myJsonObj.idu;
                        role = myJsonObj.role_u;
                        id_session = myJsonObj.ids;
                    }
                }
            }
            catch (Exception ex)
            {
                error = "error";
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }
       
        private bool flag = false;

        
        private void enterB_Click(object sender, EventArgs e)
        {
            string email = emailTB.Text;
            string pass = passTB.Text;
            Response(email, pass);
            if (error == "success")
            {
                    order_drugs.id_user = id_user;
                    order_drugs.role = role;
                    order_content.id_user = id_user;
                    price.role = role;
                    price.id_user = id_user;
                    disease.role = role;
                    drugs.role = role;
                    firms.role = role;
                    drug_composition.role = role;
                    drugs_subuse.role = role;
                    user_editinfo.id_user = id_user;
                    user_showinfo.id_user = id_user;
                    price.flag = false;
                    flag = true;
                    this.Close();
                    if (role == "employee")
                    {
                        pharma_for_empl.id_u = id_user;
                        pharma_for_empl.id_ses = id_session;
                        pharma_for_empl phe = new pharma_for_empl();
                        phe.Show();
                        flag = true;
                    }
                    else
                    {
                        pharma.id_u = id_user;
                        pharma.id_ses = id_session;
                        pharma phu = new pharma();
                        phu.Show();
                        flag = true;
                    }
               }
            else
            {
                MessageBox.Show("Данные введены неверно!");
                emailTB.Text = "";
                passTB.Text = "";
            }
        }

        private void registB_Click(object sender, EventArgs e)
        {
            regist reg_form = new regist();
            reg_form.ShowDialog();
            
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void enter_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!flag)
                Application.Exit();
        }

        
    }
}
