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
    public partial class Route : Form
    {
        DataBase dataBase = new DataBase();
        public Route()
        {
            InitializeComponent();
        }
        private static string dostup;
        public static void DostupAdmin(string admin)
        {
            dostup = admin;
        }
        private void Route_Load(object sender, EventArgs e)
        {
            this.routeTableTableAdapter.Fill(this.dB_UrbanTransportDataSet.RouteTable);
            if (dostup == "Админ")
            {
                groupBoxRoute.Visible = true;
            }
        }
        private void RefreshDataGrid(DataGridView dataGrid)
        {
            this.routeTableTableAdapter.Fill(this.dB_UrbanTransportDataSet.RouteTable);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Hide();
            AddRoute addRoute = new AddRoute();
            addRoute.FormClosed += formClosed;
            addRoute.Show();
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            int index = dataGridViewRoute.CurrentCell.RowIndex;
            var id = Convert.ToInt32(dataGridViewRoute.Rows[index].Cells[0].Value);
            Hide();
            AddRoute addRoute = new AddRoute(id);
            addRoute.FormClosed += formClosed;
            addRoute.Show();
        }
        void formClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            RefreshDataGrid(dataGridViewRoute);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                int index = dataGridViewRoute.CurrentCell.RowIndex;
                if (index != -1)
                {
                    dataGridViewRoute.Rows.RemoveAt(index);
                    tableAdapterManager1.UpdateAll(dB_UrbanTransportDataSet); //в пределах приложения (запускать через Debug чуть что)

                   /* dataBase.openConnection();
                    var id = Convert.ToInt32(dataGridViewRoute.Rows[index].Cells[0].Value);
                    var deleteQyary = $"DELETE FROM RouteTable WHERE IdRoute = {id}";
                    var command = new SqlCommand(deleteQyary, dataBase.getConnection());
                    command.ExecuteNonQuery();
                    dataBase.closeConnection();
                    RefreshDataGrid(dataGridViewRoute);*/
                }
            }
        }
        private void btnSortV_Click(object sender, EventArgs e)
        {
            dataGridViewRoute.Sort(dataGridViewRoute.Columns[1], ListSortDirection.Ascending);          
        }
        private void btnSortU_Click(object sender, EventArgs e)
        {
            dataGridViewRoute.Sort(dataGridViewRoute.Columns[1], ListSortDirection.Descending);
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            routeTableBindingSource.Filter = $"NumRoute = '{cmbFilter.Text}'";
        }
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            routeTableBindingSource.Filter = "";
            RefreshDataGrid(dataGridViewRoute);
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;

            workbook = application.Workbooks.Add();
            application.Columns.ColumnWidth = 40;

            worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
            worksheet.Name = "Маршруты";

            for (int j = 0; j < dataGridViewRoute.Columns.Count; j++)
            {
                application.Cells[1, j + 1] = dataGridViewRoute.Columns[j].HeaderText;
            }
            for (int i = 0; i < dataGridViewRoute.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewRoute.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dataGridViewRoute.Rows[i].Cells[j].Value.ToString();
                    worksheet.Cells.HorizontalAlignment = 3;
                }
            }
            application.Visible = true;
        }
        private void txtMain_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
