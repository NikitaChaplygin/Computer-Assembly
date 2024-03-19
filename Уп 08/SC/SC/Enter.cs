using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SC
{
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection connection;
            OleDbCommand command;
            OleDbDataReader reader;

            string login = textBox1.Text;
            string pass = textBox2.Text;

            string connectStr = $@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Z:\!Обмен\УП 01.01\отчеты\Чаплыгин\Уп 08\Microsoft Access База данных.accdb";

            string query = $"SELECT * FROM Пароль WHERE Логин = '{login}' AND Пароль = '{pass}'";

            connection = new OleDbConnection(connectStr);
            connection.Open();

            command = new OleDbCommand(query, connection);
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Добро пожаловать");
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
            connection.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
