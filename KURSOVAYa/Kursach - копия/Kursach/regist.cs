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
using Newtonsoft.Json;
using System.IO;
using System.Text.RegularExpressions;
namespace Kursach
{
    public partial class regist : Form
    {

        public regist()
        {
            InitializeComponent();
        }
        
        private void cancelTB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool check_box()
        {
            Regex checkPhone = new Regex(@"[0-9.x)(-]");
            Regex checkSpace = new Regex(@"[ ]+");
            Regex checkEmail = new Regex(@"^[-a-zA-Z0-9][-.a-zA-Z0-9]*@[-a-zA-Z0-9]+\.
    (com|edu|info|gov|int|mil|net|org|biz|name|museum|coop|aero|pro|tv|ru|[a-zA-Z]{2})$", RegexOptions.IgnorePatternWhitespace);
            //сделайте нормальную проверку на вводимые данные :D
            if (String.IsNullOrWhiteSpace(emailTB.Text))
            {
                MessageBox.Show("E-mail не может быть пустым!");
                return false;
            }
            if (!checkEmail.Match(emailTB.Text).Success)
            {
                MessageBox.Show("E-mail введен неправильно!");
                return false;
            }
            if (checkSpace.Match(emailTB.Text).Success)
            {
                MessageBox.Show("В поле E-mail присутствую недопустимые символы!");
                return false;
            }
            if (String.IsNullOrWhiteSpace(passTB.Text))
            {
                MessageBox.Show("Пароль не может быть пустым!");
                return false;
            }
            if (checkSpace.Match(passTB.Text).Success)
            {
                MessageBox.Show("В поле пароль присутствую недопустимые символы!");
                return false;
            }
            if (passTB.Text.Length < 7)
            {
                MessageBox.Show("Пароль слишком короткий!");
                return false;
            }
            if (passTB.Text != checkpassTB.Text)
            {
                MessageBox.Show("Пароль должны совпадать!");
                return false;
            }
            if (String.IsNullOrWhiteSpace(fioTB.Text))
            {
                MessageBox.Show("Поле ФИО не заполнено!");
                return false;
            }
            if (String.IsNullOrWhiteSpace(addressTB.Text))
            {
                MessageBox.Show("Поле адрес не заполнено!");
                return false;
            }
            if (!checkPhone.Match(phoneTB.Text).Success)
            {
                MessageBox.Show("Телефон указан неправильно!");
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
        public string error;

        public void Response()
        {
            try
            {
                string s = String.Format("http://localhost/add.php?email={0}&password={1}&bday={2}&address={3}&phonenum={4}&info={5}&workplace={6}&fullname={7}&action={8}", emailTB.Text, passTB.Text, bdayTB.Value.ToString(), addressTB.Text, phoneTB.Text, noteTB.Text, jobTB.Text, fioTB.Text,"regist");
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
        private void regB_Click(object sender, EventArgs e)
        {
            if (check_box())
            {
                Response();
                if (error == "success")
                {
                    MessageBox.Show("Успешно зарегистрировано!");
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Ошибка!Такой пользователь уже существует.");
                    return;
                }
            }
        }
    }
}
