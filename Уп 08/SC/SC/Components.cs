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
    public partial class Components : Form
    {
        public Components()
        {
            InitializeComponent();
        }

        private void комплектующиеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.комплектующиеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.microsoft_Access_База_данныхDataSet);

        }

        private void Components_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_База_данныхDataSet.Комплектующие". При необходимости она может быть перемещена или удалена.
            this.комплектующиеTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Комплектующие);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int col = 0; col < комплектующиеDataGridView.ColumnCount; col++)
                for (int row = 0; row < комплектующиеDataGridView.RowCount - 1; row++)
                {
                    комплектующиеDataGridView[col, row].Style.BackColor = Color.White;
                    if (комплектующиеDataGridView[col, row].Value.ToString().IndexOf(textBox1.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                        комплектующиеDataGridView[col, row].Style.BackColor = Color.Violet;
                }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.printDialog1.ShowDialog();
        }
    }
}
