using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SC
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Components components = new Components();
            components.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pk pk = new Pk();
            pk.Show();
            this.Hide();
        }
    }
}
