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
    public partial class pharma_for_empl : Form
    {
        public static int id_u;
        public static int id_ses;
        public pharma_for_empl()
        {
            InitializeComponent();
        }

        private void firmsB_Click(object sender, EventArgs e)
        {
            firms f = new firms();
            f.ShowDialog();
        }

        private void pharm_Click(object sender, EventArgs e)
        {
            drugs d = new drugs();
            d.ShowDialog();
        }

        private void price_Click(object sender, EventArgs e)
        {
            price p = new price();
            p.ShowDialog();
        }

        private void orders_Click(object sender, EventArgs e)
        {
            order_drugs_for_empl od = new order_drugs_for_empl();
            od.ShowDialog();
        }

        //добавляем конец сессии при закрытии формы 
        private void form_closed(object sender, FormClosedEventArgs e)
        {
            WebRequest req = WebRequest.Create(String.Format("http://localhost/exit.php?id_session='{0}'", id_ses));
            WebResponse resp = req.GetResponse(); 
            enter en = new enter();
            en.Show();
          
        }

        private void change_info_Click(object sender, EventArgs e)
        {
            user_showinfo ei = new user_showinfo();
            ei.ShowDialog();
        }
    }
}
