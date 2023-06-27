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
    public partial class AddPath : Form
    {
        DataBase dataBase = new DataBase();
        int id;
        public AddPath()
        {
            InitializeComponent();
        }
        public AddPath(int idSended): this()
        {
            //InitializeComponent();
            id = idSended;
            var main = $"SELECT StartPoint, EndPoint, Distance FROM PathTable WHERE IdPath = {id}";
            var command = new SqlCommand(main, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            txtStartPoint.Text = reader[0].ToString();
            txtEndPoint.Text = reader[1].ToString();
            txtDistance.Text = reader[2].ToString();
            reader.Close();

            btnNext.Click -= saveClick;
            btnNext.Click += changeClick;

            Text = "Редактирование пути";
            label5.Text = "Редактирование пути";
            btnNext.Text = "Сохранить";
        }


        private void saveClick(object sender, EventArgs e)
        {           
            if (txtStartPoint.Text != "")
            {
                dataBase.openConnection();
                var addQuery = $"INSERT INTO PathTable (StartPoint, EndPoint, Distance) " +
                    $"VALUES (N'{txtStartPoint.Text}', N'{txtEndPoint.Text}', N'{txtDistance.Text}')";
                SqlCommand command = new SqlCommand(addQuery, dataBase.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataBase.closeConnection();
                this.Close();
            }
            else
            {
                MessageBox.Show("Запись не удалось создать! Будьте внимательны при заполнении полей!", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataBase.closeConnection();
            this.Close();
        }

        private void changeClick(object sender, EventArgs e)
        {
            if (txtStartPoint.Text != "")
            {
                dataBase.openConnection();
                var changequery = $"UPDATE PathTable SET StartPoint = '{txtStartPoint.Text}', EndPoint = '{txtEndPoint.Text}', " +
                    $"Distance = '{txtDistance.Text}'WHERE IdPath = {id}";
                var command = new SqlCommand(changequery, dataBase.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно отредактирована!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataBase.closeConnection();
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля! Будьте внимательны при заполнении полей!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
