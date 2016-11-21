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
    public partial class user_editinfo : Form
    {
        public static int id_user;
        public user_editinfo()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Response();
            if (error == "success")
            {
                MessageBox.Show("Введенные данные сохранены!");
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Такой пользователь уже существует.");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Response()
        {
            try
            {
                string s = String.Format("http://localhost/about_user.php?bday={0}&address={1}&phonenum={2}&info={3}&fullname={4}&id_user={5}&dc={6}&action={7}", bdayTB.Value.ToString(), addressTB.Text, phoneTB.Text, infoTB.Text, fioTB.Text, id_user, dcTB.Text,"edit");
                Console.WriteLine(s);
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
        }
    }
}
