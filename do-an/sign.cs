using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_an
{
    public partial class sign : Form
    {
        public sign()
        {
            InitializeComponent();
        }

        private void sign_up_Click(object sender, EventArgs e)
        {
            string user = user_text.Text;
            string pass = pass_text.Text;
            StreamReader sr = new StreamReader("//DESKTOP-3VE6VUN/server/login.txt");
            string data = sr.ReadToEnd();
            sr.Close();
            data += "\n" + user + "\n" + pass;
            StreamWriter sw = new StreamWriter("//DESKTOP-3VE6VUN/server/login.txt");
            sw.Write(data);
            sw.Close();
            MessageBox.Show("Đăng ký thành công");
            this.Close();
        }
    }
}
