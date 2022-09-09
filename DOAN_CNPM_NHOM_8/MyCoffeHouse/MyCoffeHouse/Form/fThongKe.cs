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

namespace MyCoffeHouse
{
    public partial class fThongKe : Form
    {
        public fThongKe()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd1 = new OpenFileDialog();
            opfd1.Title = "Nhập file Excel";
            opfd1.Filter = "Excel (*.xlsx)|*.xlsx|Excel office (*.xls)|*.xls";
            if (opfd1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtPath.Text = opfd1.FileName;
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            try
            {
                string pathConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + txtPath.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
                OleDbConnection conn = new OleDbConnection(pathConn);

                OleDbDataAdapter myDataAdap = new OleDbDataAdapter("SELECT * FROM [" + txtSheet.Text + "$]", conn);
                DataTable dt = new DataTable();
                myDataAdap.Fill(dt);
                dtgvShow.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            fMain a = new fMain();
            this.Hide();
            a.ShowDialog();
        }
    }
}
