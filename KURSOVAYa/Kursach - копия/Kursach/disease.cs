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
    public partial class disease : Form
    {

        [JsonObject(MemberSerialization.OptIn)]
        struct type_error
        {
            [JsonProperty("error")]
            public string error { get; set; }
        }

        [JsonObject(MemberSerialization.OptIn)]
        struct data_order
        {
            [JsonProperty("id_dis")]
            public string id_dis { get; set; }
            [JsonProperty("name_dis")]
            public string name_dis { get; set; }
            [JsonProperty("drug")]
            public string drug_type { get; set; }
        }
        private class data_disease
        {
            public string id_dis { get; set; }
            public string name_dis { get; set; }
            public string drug_type { get; set; }
        }

        List<data_disease> diseases = new List<data_disease>();
        private string error;
        private int current_row;
        public static string role;

        public disease()
        {
            InitializeComponent();
            current_row = 0;
            Response();
            refresh_button();
           
        }
        private void refresh_button()
        {
            if (role == "user")
            {
                AddItemNavig.Enabled = false;
                DeleteItemNavig.Enabled = false;
            }
            if (diseases.Count - 1 == 0)
            {
                PrevItemNavig.Enabled = false;
                FirstItemNavig.Enabled = false;
                NextItemNavig.Enabled = false;
                LastItemNavig.Enabled = false;
            }
            else
            {
                if (current_row == 0)
                {
                    PrevItemNavig.Enabled = false;
                    FirstItemNavig.Enabled = false;
                    NextItemNavig.Enabled = true;
                    LastItemNavig.Enabled = true;
                }
                if (current_row == diseases.Count - 1)
                {
                    PrevItemNavig.Enabled = true;
                    FirstItemNavig.Enabled = true;
                    NextItemNavig.Enabled = false;
                    LastItemNavig.Enabled = false;
                }
            }
        }
        private void selected_cell(int i)
        {
            datatableDisease.Rows[i].Selected = true;
            datatableDisease.CurrentCell = datatableDisease.Rows[i].Cells[0];
        }
        private void FirstItemNavig_Click(object sender, EventArgs e)
        {
            datatableDisease.Rows[current_row].Selected = false;
            current_row = 0;
            selected_cell(current_row);
        }

        private void PrevItemNavig_Click(object sender, EventArgs e)
        {
            NextItemNavig.Enabled = true;
            LastItemNavig.Enabled = true;
            datatableDisease.Rows[current_row].Selected = false;
            current_row--;
            selected_cell(current_row);
            refresh_button();
        }
        private void LastItemNavig_Click(object sender, EventArgs e)
        {
            datatableDisease.Rows[current_row].Selected = false;
            current_row = diseases.Count - 1;
            selected_cell(current_row);
            refresh_button();
        }
        private void NextItemNavig_Click(object sender, EventArgs e)
        {
            PrevItemNavig.Enabled = true;
            FirstItemNavig.Enabled = true;
            datatableDisease.Rows[current_row].Selected = false;
            current_row++;
            selected_cell(current_row);
            refresh_button();
        }

        private void Response()
        {
            try
            {
                WebRequest req = WebRequest.Create(String.Format("http://localhost/disease.php"));
                WebResponse resp = req.GetResponse();
                Stream stream = resp.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                var responseString = sr.ReadToEnd();
                Newtonsoft.Json.Linq.JObject obj = Newtonsoft.Json.Linq.JObject.Parse(responseString);
                type_error[] objArr = JsonConvert.DeserializeObject<type_error[]>(obj["type"].ToString());
                foreach (type_error myJsonObj in objArr)
                    error = myJsonObj.error;
                diseases.Clear();
                if (error != "error")
                {
                    data_order[] objdata = JsonConvert.DeserializeObject<data_order[]>(obj["data"].ToString());
                    foreach (data_order myJsonObj in objdata)
                    {
                        data_disease newDis = new data_disease();
                        newDis.id_dis = myJsonObj.id_dis;
                        newDis.name_dis = myJsonObj.name_dis;
                        newDis.drug_type = myJsonObj.drug_type;
                        diseases.Add(newDis);
                    }
                }
                BindingSource bs = new BindingSource();
                bs.DataSource = diseases;
                diseaseBindingNavigator.BindingSource = bs;
                datatableDisease.DataSource = diseases;
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
            Response();
            current_row = 0;
            selected_cell(current_row);
            refresh_button();
        }

        private void AddItemNavig_Click(object sender, EventArgs e)
        {
            add_disease ad = new add_disease();
            ad.ShowDialog();
        }
       

    }

}
