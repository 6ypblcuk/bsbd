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

        public static int id_user;
        public static string role;
       
        public order_drugs()
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
        public class data_ord
        {
            public int id_order {get;set;}
            public DateTime date_order { get; set; }
            public string card { get; set; }
            public decimal summ { get; set; }
            public string status { get; set; }
        }
        List<data_ord> orders = new List<data_ord>();
        public string error;

        public void Response()
        {
            if (role == "user")
                SaveItemNavig.Enabled = false;
            
            try
            {
                WebRequest req = WebRequest.Create(String.Format("http://localhost/order_drugs.php?action={0}&id_user={1}","order_drug", id_user));
                WebResponse resp = req.GetResponse();
                Stream stream = resp.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                var responseString = sr.ReadToEnd();
                Console.WriteLine("\n" + responseString);
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
                    return;
                
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

        }

        private void NextItemNavig_Click(object sender, EventArgs e)
        {

        }

        private void refreshBindingNavigator_Click(object sender, EventArgs e)
        {
            Response();
        }

    }
}
