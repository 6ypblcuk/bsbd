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
    

    public partial class pharma : Form
    {
        
        public static int id_u;
        public static int id_ses;
        public pharma()
        {
            InitializeComponent();
        }

        private void drugs_Click(object sender, EventArgs e)
        {
            drugs pt = new drugs();
            pt.ShowDialog();
        }
        private void orders_Click(object sender, EventArgs e)
        {
            order_drugs od = new order_drugs();
            od.ShowDialog();

        }
        private void price_Click(object sender, EventArgs e)
        {
            price dft = new price();
            dft.ShowDialog();
        }


        //добавляем конец сессии при закрытии формы 
        private void pharm_FormClosed(object sender, FormClosedEventArgs e)
        {
            WebRequest req = WebRequest.Create(String.Format("http://localhost/exit.php?id_session={0}", id_ses));
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


