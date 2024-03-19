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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void клиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.microsoft_Access_База_данныхDataSet);

        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_База_данныхDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Клиенты);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int col = 0; col < клиентыDataGridView.ColumnCount; col++)
                for (int row = 0; row < клиентыDataGridView.RowCount - 1; row++)
                {
                    клиентыDataGridView[col, row].Style.BackColor = Color.White;
                    if (клиентыDataGridView[col, row].Value.ToString().IndexOf(textBox1.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                        клиентыDataGridView[col, row].Style.BackColor = Color.Violet;
                }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.printDialog1.ShowDialog();
        }
    }
}
