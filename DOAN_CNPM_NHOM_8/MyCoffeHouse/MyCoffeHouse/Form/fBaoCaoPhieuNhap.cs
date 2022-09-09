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
    public partial class fBaoCaoPhieuNhap : Form
    {
        public fBaoCaoPhieuNhap()
        {
            InitializeComponent();
        }

        Connection con;
        DataTable dt;
        private void fBaoCaoPhieuNhap_Load(object sender, EventArgs e)
        {
            con = new Connection();
            dt = con.taobang("SELECT * FROM PHIEUNHAP");
            Report_PN rp = new Report_PN();
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
