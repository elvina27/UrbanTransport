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
    public partial class AddRoute : Form
    {
        DataBase dataBase = new DataBase();
        int id;
        public AddRoute()
        {
            InitializeComponent();
        }
        //редактирование
        public AddRoute(int idSended) 
        {
            InitializeComponent();
            id = idSended;
            var select = $"SELECT NumRoute, NumPassengers, NumStops, NumCars, Path, KindTrans FROM RouteTable WHERE IdRoute = {id}";
            var command = new SqlCommand(select, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            txtNumRoute.Text = reader[0].ToString();
            txtNumPas.Text = reader[1].ToString();
            txtNumStops.Text = reader[2].ToString();
            txtNumCars.Text = reader[3].ToString();
            cmbPath.Text = reader[4].ToString();
            cmbKindTrans.Text = reader[5].ToString();

            reader.Close();
 
            btnSave.Click -= saveClick;
            btnSave.Click += changeClick;

            Text = "Редактирование маршрута";
            label3.Text = "Редактирование маршрута";
            btnSave.Text = "Сохранить";
        }
        private void AddRoute_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_UrbanTransportDataSet.TransportTable". При необходимости она может быть перемещена или удалена.
            this.transportTableTableAdapter.Fill(this.dB_UrbanTransportDataSet.TransportTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_UrbanTransportDataSet.PathTable". При необходимости она может быть перемещена или удалена.
            this.pathTableTableAdapter.Fill(this.dB_UrbanTransportDataSet.PathTable);
        }
        private void saveClick(object sender, EventArgs e)
        {
            if (txtNumPas.Text != "")
            {
                dataBase.openConnection();
                var addQuery = $"INSERT INTO RouteTable (NumRoute, NumPassengers, NumStops, NumCars, Path, KindTrans) " +
                    $"VALUES (N'{txtNumRoute.Text}', N'{txtNumPas.Text}', N'{txtNumStops.Text}', N'{txtNumCars.Text}', N'{cmbPath.Text}', N'{cmbKindTrans.Text}')";
                SqlCommand command = new SqlCommand(addQuery, dataBase.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataBase.closeConnection();
                this.Close();
            }
            else
            {
                MessageBox.Show("Запись не удалось создать! Будьте внимательны при заполнении полей!", "Ошибка!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void changeClick(object sender, EventArgs e)
        {
            if (txtNumPas.Text != "")
            {
                dataBase.openConnection();
                var changequery = $"UPDATE RouteTable SET NumRoute = '{txtNumRoute.Text}', NumPassengers = '{txtNumPas.Text}', " +
                    $"NumStops = '{txtNumStops.Text}', NumCars = '{txtNumCars.Text}', Path = '{cmbPath.Text}', KindTrans = '{cmbKindTrans.Text}' " +
                    $"WHERE IdRoute = {id}";
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
