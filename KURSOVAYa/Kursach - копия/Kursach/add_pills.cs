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
    public partial class add_pills : Form
    {
        public add_pills()
        {
            InitializeComponent();
        }

        private bool check_textbox()
        {
            Regex check = new Regex(@"[0-9]");
            if (String.IsNullOrWhiteSpace(DrugNameTB.Text))
            {
                MessageBox.Show("Введите название препарата!");
                return false;
            }
            if (String.IsNullOrWhiteSpace(ActTB.Text))
            {
                MessageBox.Show("Введите действующее вещество!");
                return false;
            }
            if (String.IsNullOrWhiteSpace(ChemNameTB.Text))
            {
                MessageBox.Show("Введите химическое название");
                return false;
            }
            if (String.IsNullOrWhiteSpace(PharmGrTB.Text))
            {
                MessageBox.Show("Введите фармакологическую группу");
                return false;
            }
            if (String.IsNullOrWhiteSpace(EDTB.Text))
            {
                MessageBox.Show("Введите срок хранения (в годах)!");
                return false;
            }
            else if (check.Match(EDTB.Text).Success)
            {
                MessageBox.Show("Срок хранения должен быть целым числом!");
                return false;
            }
            else if (Convert.ToInt32(EDTB.Text) == 0)
            {
                MessageBox.Show("Срок хранения не может быть 0!");
                return false;
            }
            if (String.IsNullOrWhiteSpace(FormTB.Text))
            {
                MessageBox.Show("Введите форму выпуска!");
                return false;
            }
            if (String.IsNullOrWhiteSpace(PharmocTB.Text))
            {
                MessageBox.Show("Введите фармакологию!");
                return false;
            }
            if (String.IsNullOrWhiteSpace(SubUseTB.Text))
            {
                MessageBox.Show("Введите показания к применению!");
                return false;
            }
            if (String.IsNullOrWhiteSpace(ContrTB.Text))
            {
                MessageBox.Show("Введите противопоказания!");
                return false;
            }
            if (String.IsNullOrWhiteSpace(DoseTB.Text))
            {
                MessageBox.Show("Введите дозировку");
                return false;
            }
            if (String.IsNullOrWhiteSpace(OverdoseTB.Text))
            {
                MessageBox.Show("Введите передозировку");
                return false;
            }
            if (String.IsNullOrWhiteSpace(SETB.Text))
            {
                MessageBox.Show("Введите побочные эффекты!");
                return false;
            }
            if (String.IsNullOrWhiteSpace(InterTB.Text))
            {
                MessageBox.Show("Введите взаимодействие с другими препаратами!");
                return false;
            }
            if (String.IsNullOrWhiteSpace(CompTB.Text))
            {
                MessageBox.Show("Введите состав препарата!");
                return false;
            }
            return true;

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
            [JsonProperty("composition")]
            public string comp { get; set; }
        }

        private string error;

        private bool Response()
        {
            try
            {
                WebRequest req = WebRequest.Create(String.Format("http://localhost/add.php?drug_name={0}&active_sub={1}&chem_name={2}&pharmgr={3}&pharmoc={4}&subuse={5}&contr={6}&seff={7}&overdose={8}&inter={9}&dose={10}&expdate={11}&comp={12}&form={13}&action={14}", DrugNameTB.Text, ActTB.Text, ChemNameTB.Text, PharmGrTB.Text, PharmocTB.Text, SubUseTB.Text, ContrTB.Text, SETB.Text, OverdoseTB.Text, InterTB.Text, DoseTB.Text, Convert.ToInt32(EDTB.Text), CompTB.Text, FormTB.Text,"pills"));
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
        private void AddItemNavig_Click(object sender, EventArgs e)
        {
            if (check_textbox())
            {
                if (Response())
                {
                    MessageBox.Show("Успешно добавлено!");
                    DrugNameTB.Text = "";
                    ActTB.Text = ""; ChemNameTB.Text = ""; PharmGrTB.Text = ""; EDTB.Text = ""; FormTB.Text = ""; PharmocTB.Text = "";
                    SubUseTB.Text = ""; ContrTB.Text = ""; DoseTB.Text = ""; OverdoseTB.Text = ""; SETB.Text = ""; InterTB.Text = "";
                    CompTB.Text = "";
                }
                else
                {
                    MessageBox.Show("Такой препарат существует!");
                    return;
                }
            }
        }

    }
}
