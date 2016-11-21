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
using System.Text.RegularExpressions;
namespace Kursach
{
    public partial class drugs : Form
    {
        public static int id_user;
        public static string role;
        private int current_drug;
        public drugs()
        {
            InitializeComponent();
            Response();
            ShowList(0);
            current_drug = 0;
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
            [JsonProperty("id_drug")]
            public int iddrug { get; set; }
            [JsonProperty("exp_date")]
            public int expdate { get; set; }
            [JsonProperty("name_drug")]
            public string name_drug { get; set; }
            [JsonProperty("active_sub")]
            public string actsub { get; set; }
            [JsonProperty("chem_name")]
            public string chemname { get; set; }
            [JsonProperty("pharm_group")]
            public string pharmgr { get; set; }
            [JsonProperty("sub_use")]
            public string subuse { get; set; }
            [JsonProperty("form")]
            public string form{ get; set; }
            [JsonProperty("note")]
            public string note { get; set; }
        }

        private class data_drug
        {
            public int id_drug { get; set; }
            public int exp_date { get; set; }
            public string name_drug { get; set; }
            public string active_sub { get; set; }
            public string chem_name { get; set; }
            public string pharm_group { get; set; }
            public string sub_use { get; set; }
            public string form { get; set; }
            public string note { get; set; }
        }
        private void refresh()
        {
            if (drug_list.Count == 0)
            {
                PrevItem.Enabled = false;
                FirstItem.Enabled = false;
                NextItem.Enabled = false;
                LastItem.Enabled = false;
                DeleteItemNavig.Enabled = false;
                SaveItemNavig.Enabled = false;
            }
            else if (drug_list.Count - 1 == 0)
            {
                PrevItem.Enabled = false;
                FirstItem.Enabled = false;
                NextItem.Enabled = false;
                LastItem.Enabled = false;
                DeleteItemNavig.Enabled = true;
                SaveItemNavig.Enabled = true;
            }
            else
            {
                if (current_drug - 1 < 0)
                {
                    PrevItem.Enabled = false;
                    FirstItem.Enabled = false;
                    NextItem.Enabled = true;
                    LastItem.Enabled = true;
                }
                if (current_drug == drug_list.Count - 1)
                {
                    PrevItem.Enabled = true;
                    FirstItem.Enabled = true;
                    NextItem.Enabled = false;
                    LastItem.Enabled = false;
                }
            }
        }
        List<data_drug> drug_list = new List<data_drug>();
        private string error;
        private void NextItem_Click(object sender, EventArgs e)
        {
            current_drug++;
            ShowList(current_drug);
            PrevItem.Enabled = true;
            FirstItem.Enabled = true;
            refresh();
        }

        private void PrevItem_Click(object sender, EventArgs e)
        {
            current_drug--;
            ShowList(current_drug);
            NextItem.Enabled = true;
            LastItem.Enabled = true;
            refresh();
        }

        private void LastItem_Click(object sender, EventArgs e)
        {
            current_drug = drug_list.Count-1;
            ShowList(current_drug);
            refresh();
        }

        private void FirstItem_Click(object sender, EventArgs e)
        {
            current_drug = 0;
            ShowList(current_drug);
            refresh();
        }

        private void ShowList(int i)
        {
            NDrugTB.Text = Convert.ToString(drug_list[i].id_drug);
            ExpDateTB.Text = Convert.ToString(drug_list[i].exp_date);
            DrugNameTB.Text = drug_list[i].name_drug;
            ActTB.Text = drug_list[i].active_sub; 
            ChemNameTB.Text = drug_list[i].chem_name; 
            PharmGrTB.Text = drug_list[i].pharm_group; 
            SubUseTB.Text = drug_list[i].sub_use; 
            FormTB.Text = drug_list[i].form;
            NoteTB.Text = drug_list[i].note; 
        }

        private void Response()
        {
            if (role == "user")
            {
                AddItemNavig.Enabled = false;
                SaveItemNavig.Enabled = false;
                DeleteItemNavig.Enabled = false;
            }
            try
            {
                WebRequest req = WebRequest.Create(String.Format("http://localhost/drugs.php?action={0}","select"));
                WebResponse resp = req.GetResponse();
                Stream stream = resp.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                var responseString = sr.ReadToEnd();
                Newtonsoft.Json.Linq.JObject obj = Newtonsoft.Json.Linq.JObject.Parse(responseString);
                type_error[] objArr = JsonConvert.DeserializeObject<type_error[]>(obj["type"].ToString());
                foreach (type_error myJsonObj in objArr)
                    error = myJsonObj.error;
                drug_list.Clear();
                if (error != "null")
                {
                    data_drugs[] objdata = JsonConvert.DeserializeObject<data_drugs[]>(obj["data"].ToString());
                    foreach (data_drugs myJsonObj in objdata)
                    {
                        data_drug newDrug = new data_drug();
                        newDrug.id_drug = myJsonObj.iddrug;
                        newDrug.name_drug = myJsonObj.name_drug;
                        newDrug.pharm_group = myJsonObj.pharmgr;
                        newDrug.form = myJsonObj.form;
                        newDrug.exp_date = myJsonObj.expdate;
                        newDrug.active_sub= myJsonObj.actsub;
                        newDrug.chem_name= myJsonObj.chemname;
                        newDrug.sub_use = myJsonObj.subuse;
                        newDrug.note = myJsonObj.note;
                        drug_list.Add(newDrug);
                    }
                }
                else
                    return;
                BindingSource bs = new BindingSource();
                bs.DataSource = drug_list;
            }
            catch (Exception ex)
            {
                error = "error";
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }
       

        private void SearchB_Click(object sender, EventArgs e)
        {
            search_drugs sd = new search_drugs();
            sd.ShowDialog();
        }


        private void firmslink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            firms.id_drug = current_drug + 1;
            firms fl = new firms();
            fl.Show();
        }

        private void subuselink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            drugs_subuse.name_drug = DrugNameTB.Text;
            drugs_subuse inf_u = new drugs_subuse();
            inf_u.ShowDialog();
        }

        private void compositionlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            drug_composition.id_drug = current_drug+1;
            drug_composition cl = new drug_composition();
            cl.Show();
        }

        private void AddItemNavig_Click(object sender, EventArgs e)
        {
            add_pills ap = new add_pills();
            ap.Show();
        }

        private void refreshBindingNavigator_Click(object sender, EventArgs e)
        {
            Response();
            current_drug = 0;
            refresh();
            ShowList(current_drug);
        }

        private void Response_Drug()
        {
            WebRequest req = WebRequest.Create(String.Format("http://localhost/drugs.php?action={0}&action1={1}&id_drug={2}&pharmgr={3}&subuse={4}&expdate={5}&form={6}", "save_change","change_main",NDrugTB.Text,PharmGrTB.Text,SubUseTB.Text,ExpDateTB.Text,FormTB.Text));
            WebResponse resp = req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            var responseString = sr.ReadToEnd();
            Newtonsoft.Json.Linq.JObject obj = Newtonsoft.Json.Linq.JObject.Parse(responseString);
            type_error[] objArr = JsonConvert.DeserializeObject<type_error[]>(obj["type"].ToString());
            foreach (type_error myJsonObj in objArr)
                error = myJsonObj.error;
            drug_list.Clear();
            if (error != "error")
                MessageBox.Show("Успешно изменено!");
            
        }
        private void SaveItemNavig_Click(object sender, EventArgs e)
        {
            Regex check = new Regex(@"[0-9]");
            if (check.Match(ExpDateTB.Text).Success)
            {
                if (Convert.ToInt32(ExpDateTB.Text) > 0)
                {
                    Response_Drug();
                    Response();
                    refresh();
                }
                else
                    MessageBox.Show("Срок хранения должен быть больше 0!");
            }
            else
                MessageBox.Show("Срок хранения введен ошибочно!");
        }

        private void DeleteItemNavig_Click(object sender, EventArgs e)
        {
            if (DrugNameTB.Text != null)
            {
                try
                {
                    string s = String.Format("http://localhost/drugs.php?nameDrug={0}&action={1}", DrugNameTB.Text, "DelDrug");
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
                if (current_drug == drug_list.Count - 1)
                {
                    drug_list.Remove(drug_list[current_drug]);
                    current_drug--;
                }
                else
                   drug_list.Remove(drug_list[current_drug]);
                refresh();
                if (drug_list.Count == 0)
                {
                    NDrugTB.Text = "";
                    ExpDateTB.Text = "";
                    DrugNameTB.Text = "";
                    ActTB.Text = "";
                    ChemNameTB.Text = "";
                    PharmGrTB.Text = "";
                    SubUseTB.Text = "";
                    FormTB.Text = "";
                    NoteTB.Text = "";
                    refresh();
                }
                else
                    ShowList(current_drug);
            }
        }

    }
}
