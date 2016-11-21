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
    public partial class order_content : Form
    {
        [JsonObject(MemberSerialization.OptIn)]
        struct type_error
        {
            [JsonProperty("error")]
            public string error { get; set; }
        }

        [JsonObject(MemberSerialization.OptIn)]
        struct data_order_content
        {
            [JsonProperty("id_drug")]
            public int iddrug { get; set; }
            [JsonProperty("id_order")]
            public int idord { get; set; }
            [JsonProperty("counts")]
            public int counts { get; set; }
            [JsonProperty("summ")]
            public decimal summ { get; set; }
            [JsonProperty("name_firm")]
            public string name_firm { get; set; }
            [JsonProperty("name_drug")]
            public string name_drug { get; set; }

        }
        private class data_ord_content
        {
            public int id_drug { get; set; }
            public int id_order { get; set; }
            public int counts { get; set; }
            public decimal summ { get; set; }
            public string name_firm { get; set; }
            public string name_drug { get; set; }
        }
        List<data_ord_content> orders_content = new List<data_ord_content>();

        private string error;
        public static int index;
        public static int id_user;
        private int current_row;
        public order_content()
        {
            current_row = 0;
            InitializeComponent();
            Response();
        }

        private void refresh_button()
        {
            if (orders_content.Count - 1 < 1)
            {
                PrevItemNavig.Enabled = false;
                FirstItemNavig.Enabled = false;
                NextItemNavig.Enabled = false;
                LastItemNavig.Enabled = false;
                return;
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
                if (current_row == orders_content.Count - 1)
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
            datatableOrderContent.Rows[i].Selected = true;
            datatableOrderContent.CurrentCell = datatableOrderContent.Rows[i].Cells[0];
        }
        
        private void FirstItemNavig_Click(object sender, EventArgs e)
        {
            datatableOrderContent.Rows[current_row].Selected = false;
            current_row = 0;
            selected_cell(current_row);
            refresh_button();
        }

        private void PrevItemNavig_Click(object sender, EventArgs e)
        {
            NextItemNavig.Enabled = true;
            LastItemNavig.Enabled = true;
            datatableOrderContent.Rows[current_row].Selected = false;
            current_row--;
            selected_cell(current_row);
            refresh_button();
        }

        private void NextItemNavig_Click(object sender, EventArgs e)
        {
            PrevItemNavig.Enabled = true;
            FirstItemNavig.Enabled = true;
            datatableOrderContent.Rows[current_row].Selected = false;
            current_row++;
            selected_cell(current_row);
            refresh_button();
        }

        private void LastItem_Click(object sender, EventArgs e)
        {
            datatableOrderContent.Rows[current_row].Selected = false;
            current_row = orders_content.Count - 1;
            selected_cell(current_row);
            refresh_button();
        }

        private void Response()
        {
            try
            {
                WebRequest req = WebRequest.Create(String.Format("http://localhost/order_drugs.php?action={0}&id_order={1}","order_content", index));
                WebResponse resp = req.GetResponse();
                Stream stream = resp.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                var responseString = sr.ReadToEnd();
                Newtonsoft.Json.Linq.JObject obj = Newtonsoft.Json.Linq.JObject.Parse(responseString);
                type_error[] objArr = JsonConvert.DeserializeObject<type_error[]>(obj["type"].ToString());
                foreach (type_error myJsonObj in objArr)
                    error = myJsonObj.error;
                orders_content.Clear();
                if (error != "error")
                {
                    data_order_content[] objdata = JsonConvert.DeserializeObject<data_order_content[]>(obj["data"].ToString());
                    foreach (data_order_content myJsonObj in objdata)
                    {
                        data_ord_content newOrd = new data_ord_content();
                        newOrd.id_drug = myJsonObj.iddrug;
                        newOrd.id_order = myJsonObj.idord;
                        newOrd.counts = myJsonObj.counts;
                        newOrd.summ = myJsonObj.summ;
                        newOrd.name_firm = myJsonObj.name_firm;
                        newOrd.name_drug = myJsonObj.name_drug;
                        orders_content.Add(newOrd);
                    }
                }
                BindingSource bs = new BindingSource();
                bs.DataSource = orders_content;
                order_contentBindingNavigator.BindingSource = bs;
                datatableOrderContent.DataSource = orders_content;
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
            refresh_button();
        }

    }
}
