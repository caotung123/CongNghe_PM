using MyCoffeHouse.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCoffeHouse
{
    public partial class fBaoCaoNuocUong : Form
    {
        public fBaoCaoNuocUong()
        {
            InitializeComponent();
        }

        Connection con;
        DataTable dt;

        private void fBaoCaoNuocUong_Load(object sender, EventArgs e)
        {
            con = new Connection();
            dt = con.taobang("SELECT * FROM NUOCUONG");
            Report_NU rp = new Report_NU();
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            fNuocUong nu = new fNuocUong();
            this.Hide();
            nu.ShowDialog();
        }
    }
}
