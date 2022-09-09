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
    public partial class fBaoCao : Form
    {
        public fBaoCao()
        {
            InitializeComponent();
        }

        Connection con;
        DataTable dt;
        private void btnXem_Click(object sender, EventArgs e)
        {
            if(txtMaHD.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã hóa đơn!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
            else
            {
                dt = new DataTable();
                con = new Connection();
                dt = con.taobang("SELECT * FROM HOADON where MAHD='" + txtMaHD.Text + "'");
                Report_HD rp = new Report_HD();
                rp.SetDataSource(dt);
                crystalReportViewer1.ReportSource = rp;
            }    
        }

        private void fBaoCao_Load(object sender, EventArgs e)
        {
            con = new Connection();
            dt = con.taobang("SELECT * FROM HOADON");
            Report_HD rp = new Report_HD();
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            fBanNuoc a = new fBanNuoc();
            this.Hide();
            a.ShowDialog();
        }
    }
}
