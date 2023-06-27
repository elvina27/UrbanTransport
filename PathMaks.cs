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
    public partial class PathMaks : Form
    {
        public PathMaks()
        {
            InitializeComponent();
        }
        public static void DostupAdmin(string admin)
        {
            dostup = admin;
        }
        private static string dostup;
        private void PathMaks_Load(object sender, EventArgs e)
        {
            this.pathTableTableAdapter.Fill(this.dB_UrbanTransportDataSet.PathTable);
            if (dostup == "Админ")
            {
                groupBox1.Visible = true;
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            pathTableBindingSource.MoveNext();
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            pathTableBindingSource.MovePrevious();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Hide();
            AddPath addPath = new AddPath();
            addPath.FormClosed += formClosed;
            addPath.Show();
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            Hide();
            AddPath addPath = new AddPath(Convert.ToInt32(idPathLabel1.Text));
            addPath.FormClosed += formClosed;
            addPath.Show();
        }
        void formClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            this.pathTableTableAdapter.Fill(this.dB_UrbanTransportDataSet.PathTable);
        }
    }
}
