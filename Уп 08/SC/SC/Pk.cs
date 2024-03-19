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
    public partial class Pk : Form
    {
        public Pk()
        {
            InitializeComponent();
        }

        private void компьютерыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.компьютерыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.microsoft_Access_База_данныхDataSet);

        }

        private void Pk_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_База_данныхDataSet.Компьютеры". При необходимости она может быть перемещена или удалена.
            this.компьютерыTableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Компьютеры);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int col = 0; col < компьютерыDataGridView.ColumnCount; col++)
                for (int row = 0; row < компьютерыDataGridView.RowCount - 1; row++)
                {
                    компьютерыDataGridView[col, row].Style.BackColor = Color.White;
                    if (компьютерыDataGridView[col, row].Value.ToString().IndexOf(textBox1.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                        компьютерыDataGridView[col, row].Style.BackColor = Color.Violet;
                }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.printDialog1.ShowDialog();
        }
    }
}
