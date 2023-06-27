using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrbanTransport
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void путиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            PathMaks path = new PathMaks();
            path.Show();
        }

        private void маршрутыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Route route = new Route();
            route.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void контактыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("+7(911)235-62-24\nШишкина 303\n", "Контактная информация", MessageBoxButtons.OK);
        }
      
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Hide();
            Authorization authorization = new Authorization();
            authorization.Show();
        }
    }
}
