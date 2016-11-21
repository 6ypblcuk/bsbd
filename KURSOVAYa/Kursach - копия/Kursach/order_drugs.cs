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
    public partial class order_drugs : Form
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
            [JsonProperty("id_order")]
            public int idord { get; set; }
            [JsonProperty("date_order")]
            public DateTime dateord { get; set; }
            [JsonProperty("card")]
            public string card { get; set; }
            [JsonProperty("summ")]
            public decimal summord { get; set; }
            [JsonProperty("status")]
            public string status { get; set; }

        }
        private class data_ord
        {
            public int id_order { get; set; }
            public DateTime date_order { get; set; }
            public string card { get; set; }
            public decimal summ { get; set; }
            public string status { get; set; }
        }
        List<data_ord> orders = new List<data_ord>();
        public string error;
        public static int id_user;
        public static string role;
        private int current_row;
       
        public order_drugs()
        {
            current_row = 0;
            InitializeComponent();
            Response();
            refresh_button();
        }
        private void refresh_button()
        {
            if (orders.Count == 0)
            {
                PrevItemNavig.Enabled = false;
                FirstItemNavig.Enabled = false;
                NextItemNavig.Enabled = false;
                LastItemNavig.Enabled = false;
                DeleteItemNavig.Enabled = false;
                return;
            }
            if (orders.Count - 1 == 0)
            {
                PrevItemNavig.Enabled = false;
                FirstItemNavig.Enabled = false;
                NextItemNavig.Enabled = false;
                LastItemNavig.Enabled = false;
                DeleteItemNavig.Enabled = true;
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
                if (current_row == orders.Count - 1)
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
            datatableOrder.Rows[i].Selected = true;
            datatableOrder.CurrentCell = datatableOrder.Rows[i].Cells[0];
        }
        private void FirstItemNavig_Click(object sender, EventArgs e)
        {
            datatableOrder.Rows[current_row].Selected = false;
            current_row = 0;
            selected_cell(current_row);
            refresh_button();
        }

        private void PrevItemNavig_Click(object sender, EventArgs e)
        {
            NextItemNavig.Enabled = true;
            LastItemNavig.Enabled = true;
            datatableOrder.Rows[current_row].Selected = false;
            current_row--;
            selected_cell(current_row);
            refresh_button();
        }
        private void LastItemNavig_Click(object sender, EventArgs e)
        {
            datatableOrder.Rows[current_row].Selected = false;
            current_row = orders.Count-1;
            selected_cell(current_row);
            refresh_button();
        }
        private void NextItemNavig_Click(object sender, EventArgs e)
        {
            PrevItemNavig.Enabled = true;
            FirstItemNavig.Enabled = true;
            datatableOrder.Rows[current_row].Selected = false;
            current_row++;
            selected_cell(current_row);
            refresh_button();
        }

        private void Response()
        {
            try
            {
                WebRequest req = WebRequest.Create(String.Format("http://localhost/order_drugs.php?action={0}&id_user={1}","order_drug", id_user));
                WebResponse resp = req.GetResponse();
                Stream stream = resp.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                var responseString = sr.ReadToEnd();
                Newtonsoft.Json.Linq.JObject obj = Newtonsoft.Json.Linq.JObject.Parse(responseString);
                type_error[] objArr = JsonConvert.DeserializeObject<type_error[]>(obj["type"].ToString());
                foreach (type_error myJsonObj in objArr)
                    error = myJsonObj.error;
                orders.Clear();
                if (error != "null")
                {
                    data_order[] objdata = JsonConvert.DeserializeObject<data_order[]>(obj["data"].ToString());
                    foreach (data_order myJsonObj in objdata)
                    {
                        data_ord newOrd = new data_ord();
                        newOrd.id_order = myJsonObj.idord;
                        newOrd.card = myJsonObj.card;
                        newOrd.date_order = myJsonObj.dateord;
                        newOrd.summ = myJsonObj.summord;
                        newOrd.status = myJsonObj.status;
                        orders.Add(newOrd);
                    }
                }
                else
                {
                    OrderContentB.Enabled = false;
                    return;
                }
                BindingSource bs = new BindingSource();
                bs.DataSource = orders;
                order_firmBindingNavigator.BindingSource = bs;
                datatableOrder.DataSource = orders;
            }
            catch (Exception ex)
            {
                error = "error";
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }
       

        private void order_contentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void OrderContentB_Click(object sender, EventArgs e)
        {
            int j = datatableOrder.CurrentRow.Index;
            order_content.index = (int)datatableOrder["NOrder", j].Value;
            order_content oc = new order_content();
            oc.Show();
        }


        private void DeleteItemNavig_Click(object sender, EventArgs e)
        {
            if (datatableOrder.SelectedCells.Count > 0)
            {
                try
                {
                    Response();
                    int j = datatableOrder.CurrentRow.Index;
                    MessageBox.Show(Convert.ToString(j));
                    int index = (int)datatableOrder["NOrder", j].Value;
                    MessageBox.Show(Convert.ToString(j));
                    MessageBox.Show(Convert.ToString(datatableOrder["NOrder", j].Value));
                    string s = String.Format("http://localhost/order_drugs.php?idorder={0}&action={1}", index, "DelOrder");
                    WebRequest req = WebRequest.Create(s);
                    WebResponse resp = req.GetResponse();
                    orders.Remove(orders[current_row]);
                    datatableOrder.DataSource = orders.GetRange(0, orders.Count);
                    Stream stream = resp.GetResponseStream();
                    StreamReader sr = new StreamReader(stream);
                    var responseString = sr.ReadToEnd();
                    Newtonsoft.Json.Linq.JObject obj = Newtonsoft.Json.Linq.JObject.Parse(responseString);
                    type_error[] objArr = JsonConvert.DeserializeObject<type_error[]>(obj["type"].ToString());
                    foreach (type_error myJsonObj in objArr)
                        error = myJsonObj.error;
                    Response();
                }
                catch (Exception ex)
                {
                    error = "error";
                    MessageBox.Show(ex.Message);
                    Application.Exit();
                }

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
