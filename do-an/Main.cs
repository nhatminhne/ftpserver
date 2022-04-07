using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_an
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void client_Click(object sender, EventArgs e)
        {
            new Client().Show();
        }

        private void server_Click(object sender, EventArgs e)
        {
            new Server().Show();
        }
    }
}
