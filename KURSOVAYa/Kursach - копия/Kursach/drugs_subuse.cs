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
    public partial class drugs_subuse : Form
    {
        private int current_drug;
        public static string name_drug;
        public static string role;
        public drugs_subuse()
        {
            current_drug = 0;
            InitializeComponent();
            Response("subuse_drug");
            ShowList(current_drug);
        }

        [JsonObject(MemberSerialization.OptIn)]
        struct type_error
        {
            [JsonProperty("error")]
            public string error { get; set; }
        }
        [JsonObject(MemberSerialization.OptIn)]
        struct data_diseases
        {
            [JsonProperty("name_dis")]
            public string name_dis { get; set; }
        }
        [JsonObject(MemberSerialization.OptIn)]
        struct data_drugs
        {
            [JsonProperty("id_drug")]
            public int iddrug { get; set; }
            [JsonProperty("side_eff")]
            public string side_eff { get; set; }
            [JsonProperty("name_drug")]
            public string name_drug { get; set; }
            [JsonProperty("pharmac")]
            public string pharmac { get; set; }
            [JsonProperty("contrain")]
            public string contrain { get; set; }
            [JsonProperty("pharm_group")]
            public string pharmgr { get; set; }
            [JsonProperty("sub_use")]
            public string subuse { get; set; }
            [JsonProperty("dose")]
            public string dose { get; set; }
            [JsonProperty("overdose")]
            public string overdose { get; set; }
            [JsonProperty("inter")]
            public string inter { get; set; }
        }

        private class data_drug
        {
            public int id_drug { get; set; }
            public string name_drug { get; set; }
            public string side_eff { get; set; }
            public string pharmac { get; set; }
            public string pharm_group { get; set; }
            public string sub_use { get; set; }
            public string contrain { get; set; }
            public string dose { get; set; }
            public string overdose { get; set; }
            public string inter { get; set; }
        }
        private void refresh()
        {
            if (drug_list.Count == 0)
            {
                PrevItem.Enabled = false;
                FirstItem.Enabled = false;
                NextItem.Enabled = false;
                LastItem.Enabled = false;
                SaveItemNavig.Enabled = false;
            }
            else if (drug_list.Count - 1 == 0)
            {
                PrevItem.Enabled = false;
                FirstItem.Enabled = false;
                NextItem.Enabled = false;
                LastItem.Enabled = false;
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
            current_drug = drug_list.Count - 1;
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
            PharmTB.Text = drug_list[i].pharmac;
            Drug_nameTB.Text = drug_list[i].name_drug;
            ContrainTB.Text = drug_list[i].contrain;
            SideEffTB.Text = drug_list[i].side_eff;
            PharmGrTB.Text = drug_list[i].pharm_group;
            SubTB.Text = drug_list[i].sub_use;
            DoseTB.Text = drug_list[i].dose;
            OverdoseTB.Text = drug_list[i].overdose;
            InterTB.Text = drug_list[i].inter;
        }


        private void Response(string action)
        {
            if (role == "user")
                SaveItemNavig.Enabled = false;
            try
            {
                string s = "";
                if (action == "subuse_drug")
                {
                    PrevItem.Enabled = false;
                    NextItem.Enabled = false;
                    LastItem.Enabled = false;
                    FirstItem.Enabled = false;
                    s = String.Format("http://localhost/drugs.php?action={0}&name_drug={1}", action, name_drug);
                }
                if (action == "disease_drug")
                    s = String.Format("http://localhost/drugs.php?action={0}&name_disease={1}", action, Dis_nameTB.Text);
                
                WebRequest req = WebRequest.Create(s);
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
                {
                    data_drugs[] objdata = JsonConvert.DeserializeObject<data_drugs[]>(obj["data"].ToString());
                    foreach (data_drugs myJsonObj in objdata)
                    {
                        data_drug newDrug = new data_drug();
                        newDrug.id_drug = myJsonObj.iddrug;
                        newDrug.name_drug = myJsonObj.name_drug;
                        newDrug.pharm_group = myJsonObj.pharmgr;
                        newDrug.dose = myJsonObj.dose;
                        newDrug.overdose = myJsonObj.overdose;
                        newDrug.side_eff = myJsonObj.side_eff;
                        newDrug.pharmac = myJsonObj.pharmac;
                        newDrug.sub_use = myJsonObj.subuse;
                        newDrug.inter = myJsonObj.inter;
                        newDrug.contrain = myJsonObj.contrain;
                        drug_list.Add(newDrug);
                    }
                    if (action == "subuse_drug")
                    {
                        data_diseases[] objdis = JsonConvert.DeserializeObject<data_diseases[]>(obj["disease"].ToString());
                        Dis_nameTB.Text = "";
                        foreach (data_diseases myJsonObj in objdis)
                            Dis_nameTB.Text = Dis_nameTB.Text + "/" + myJsonObj.name_dis;
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
       

        private void OutSubTB_Click(object sender, EventArgs e)
        {
            Regex checkingPass = new Regex(@"([!#$%&'.,\\=?^`{}|~])+");
            if (!(checkingPass.Match(Dis_nameTB.Text).Success))
            {
                Response("disease_drug");
                if (error != "error")
                {
                    PrevItem.Enabled = true;
                    NextItem.Enabled = true;
                    LastItem.Enabled = true;
                    FirstItem.Enabled = true;
                    current_drug = 0;
                    refresh();
                    ShowList(current_drug);
                }
                else
                {
                    MessageBox.Show("Такого заболевания не существует!");
                    return;
                }
            }
            else
                MessageBox.Show("В поле заболевание не могут присутствовать запятые!");
            
        }

        private void Response_Drug()
        {
            Console.WriteLine(SideEffTB.Text);
            WebRequest req = WebRequest.Create(String.Format("http://localhost/drugs.php?action={0}&action1={1}&id_drug={2}&subuse={3}&side_eff={4}&pharmoc={5}&contr={6}&dose={7}&overdose={8}&inter={9}", "save_change", "change_info", NDrugTB.Text, SubTB.Text,SideEffTB.Text,PharmTB.Text,ContrainTB.Text,DoseTB.Text,OverdoseTB.Text,InterTB.Text));
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
        private void Enter_DisBut_Click(object sender, EventArgs e)
        {
            disease dt = new disease();
            dt.Show();
        }

        private void SaveItemNavig_Click(object sender, EventArgs e)
        {
            Response_Drug();
            Response("subuse_drug");
            refresh();
            ShowList(current_drug);
        }


       
    }
}
