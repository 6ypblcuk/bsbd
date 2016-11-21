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
    public partial class firms : Form
    {
        public static int id_drug;
        public static string role;
        private int current_firm;
        public firms()
        {
            InitializeComponent();
            Response();
            if (error == "success")
            {
                current_firm = 0;
                ShowList(current_firm);
                refresh();
                return;
            }
            else
                refresh();
        }

        [JsonObject(MemberSerialization.OptIn)]
        struct type_error
        {
            [JsonProperty("error")]
            public string error { get; set; }
        }

        [JsonObject(MemberSerialization.OptIn)]
        struct data_drugs
        {
            [JsonProperty("id_firm")]
            public int idfirm { get; set; }
            [JsonProperty("name_firm")]
            public string name_firm { get; set; }
            [JsonProperty("address")]
            public string address { get; set; }
            [JsonProperty("phone")]
            public string phone { get; set; }
            [JsonProperty("bank")]
            public string bank { get; set; }
            [JsonProperty("check_acc")]
            public string checkacc { get; set; }
            [JsonProperty("site")]
            public string site { get; set; }
        }

        private class data_firms
        {
            public int id_firm { get; set; }
            public string name_firm { get; set; }
            public string address { get; set; }
            public string phone { get; set; }
            public string bank { get; set; }
            public string check_acc { get; set; }
            public string site { get; set; }
        }
        List<data_firms> firm_list = new List<data_firms>();
        private void refresh()
        {
            if (role == "employee")
            {
                DeleteItemNavig.Enabled = true;
                SaveItemNavig.Enabled = true;
            }
            if (role == "user")
            {
                AddItemNavig.Enabled = false;
                SaveItemNavig.Enabled = false;
                DeleteItemNavig.Enabled = false;
            }
            
            if (firm_list.Count == 0)
            {
                PrevItemNavig.Enabled = false;
                FirstItemNavig.Enabled = false;
                NextItemNavig.Enabled = false;
                LastItemNavig.Enabled = false;
                DeleteItemNavig.Enabled = false;
                SaveItemNavig.Enabled = false;
            }
            else if (firm_list.Count - 1 == 0)
            {
                PrevItemNavig.Enabled = false;
                FirstItemNavig.Enabled = false;
                NextItemNavig.Enabled = false;
                LastItemNavig.Enabled = false;
                DeleteItemNavig.Enabled = false;
                SaveItemNavig.Enabled = false;
            }
            else
            {
                if (current_firm - 1 < 0)
                {
                    PrevItemNavig.Enabled = false;
                    FirstItemNavig.Enabled = false;
                    NextItemNavig.Enabled = true;
                    LastItemNavig.Enabled = true;
                }
                if (current_firm == firm_list.Count - 1)
                {
                    PrevItemNavig.Enabled = true;
                    FirstItemNavig.Enabled = true;
                    NextItemNavig.Enabled = false;
                    LastItemNavig.Enabled = false;
                }
            }
        }
        
        private string error;
        private void NextItem_Click(object sender, EventArgs e)
        {
            current_firm++;
            ShowList(current_firm);
            PrevItemNavig.Enabled = true;
            FirstItemNavig.Enabled = true;
            refresh();
        }

        private void PrevItem_Click(object sender, EventArgs e)
        {
            current_firm--;
            ShowList(current_firm);
            NextItemNavig.Enabled = true;
            LastItemNavig.Enabled = true;
            refresh();
        }

        private void LastItem_Click(object sender, EventArgs e)
        {
            current_firm = firm_list.Count - 1;
            ShowList(current_firm);
            refresh();
        }

        private void FirstItem_Click(object sender, EventArgs e)
        {
            current_firm = 0;
            ShowList(current_firm);
            refresh();
        }

        private void ShowList(int i)
        {
            IdFirmTB.Text = Convert.ToString(firm_list[i].id_firm);
            NameFirmTB.Text = firm_list[i].name_firm;
            AddressTB.Text = firm_list[i].address;
            PhoneTB.Text = firm_list[i].phone;
            BankTB.Text = firm_list[i].bank;
            ChTB.Text = firm_list[i].check_acc;
            SiteTB.Text = firm_list[i].site;
        }


        private void Response()
        {
            try
            {
                string s;
                if (id_drug > 0)
                    s = String.Format("http://localhost/firms.php?id_drug={0}", id_drug);
                else
                    s = String.Format("http://localhost/firms.php?id_drug={0}",0);
                WebRequest req = WebRequest.Create(s);
                WebResponse resp = req.GetResponse();
                Stream stream = resp.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                var responseString = sr.ReadToEnd();
                Newtonsoft.Json.Linq.JObject obj = Newtonsoft.Json.Linq.JObject.Parse(responseString);
                type_error[] objArr = JsonConvert.DeserializeObject<type_error[]>(obj["type"].ToString());
                foreach (type_error myJsonObj in objArr)
                    error = myJsonObj.error;
                firm_list.Clear();
                if (error != "null")
                {
                    data_drugs[] objdata = JsonConvert.DeserializeObject<data_drugs[]>(obj["data"].ToString());
                    foreach (data_drugs myJsonObj in objdata)
                    {
                        data_firms newFirm = new data_firms();
                        newFirm.id_firm = myJsonObj.idfirm;
                        newFirm.name_firm = myJsonObj.name_firm;
                        newFirm.address = myJsonObj.address;
                        newFirm.phone = myJsonObj.phone;
                        newFirm.check_acc = myJsonObj.checkacc;
                        newFirm.bank = myJsonObj.bank;
                        newFirm.site = myJsonObj.site;
                        firm_list.Add(newFirm);
                    }
                }
                else
                    return;
                BindingSource bs = new BindingSource();
                bs.DataSource = firm_list;
            }
            catch (Exception ex)
            {
                error = "error";
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }
       
        private void Search_firmB_Click(object sender, EventArgs e)
        {
            search_firm sf = new search_firm();
            sf.ShowDialog();
        }

        private void FirmSaveItemBindNav_Click(object sender, EventArgs e)
        {
            add_firm af = new add_firm();
            af.ShowDialog();
            Response();
            if (error == "success")
            {
                current_firm = 0;
                ShowList(current_firm);
                refresh();
                return;
            }
            else
                refresh();
        }

        private void DeleteItemNavig_Click(object sender, EventArgs e)
        {
            if (IdFirmTB.Text != null)
            {
                try
                {
                    string s = String.Format("http://localhost/firms_del.php?idfirm={0}&action={1}", IdFirmTB.Text, "Delfirm");
                    WebRequest req = WebRequest.Create(s);
                    WebResponse resp = req.GetResponse();
                    Stream stream = resp.GetResponseStream();
                    StreamReader sr = new StreamReader(stream);
                    var responseString = sr.ReadToEnd();
                    Newtonsoft.Json.Linq.JObject obj = Newtonsoft.Json.Linq.JObject.Parse(responseString);
                    type_error[] objArr = JsonConvert.DeserializeObject<type_error[]>(obj["type"].ToString());
                    foreach (type_error myJsonObj in objArr)
                        error = myJsonObj.error;
                }
                catch (Exception ex)
                {
                    error = "error";
                    MessageBox.Show(ex.Message);
                    Application.Exit();
                }
                if (current_firm == firm_list.Count - 1)
                {
                    firm_list.Remove(firm_list[current_firm]);
                    current_firm--;
                }
                else
                    firm_list.Remove(firm_list[current_firm]);

                if (firm_list.Count == 0)
                {
                    IdFirmTB.Text = "";
                    NameFirmTB.Text = "";
                    AddressTB.Text = "";
                    PhoneTB.Text = "";
                    BankTB.Text = "";
                    ChTB.Text = "";
                    SiteTB.Text = "";
                    refresh();
                }
                else
                    ShowList(current_firm);
            }
        }

    }
}
