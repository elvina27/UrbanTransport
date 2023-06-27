using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UrbanTransport
{
    public partial class Authorization : Form
    {
        DataBase dataBase = new DataBase();
        public Authorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsAtho(txtLogin.Text, txtPassword.Text))
            {
                 PathMaks.DostupAdmin("Админ");
                 Route.DostupAdmin("Админ");

                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();

            }
            else MessageBox.Show("Такого аккаунта не существует!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public bool IsAtho(string login, string password)
        {
            dataBase.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string select = $"SELECT * FROM AuthorizationTable WHERE Login='{login}' AND Password='{password}' ";
            var command = new SqlCommand(select, dataBase.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
           
            dataBase.closeConnection();
            return table.Rows.Count == 1;
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            txtLogin.MaxLength = 50;
            txtPassword.MaxLength = 50;
        }
    }
}
