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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát chương trình", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
            {
                fLogin login = new fLogin();
                this.Hide();
                login.ShowDialog();
            }
        }

        private void btnQLNU_Click(object sender, EventArgs e)
        {
                fNuocUong nuocUong = new fNuocUong();
                this.Hide();
                nuocUong.ShowDialog();
        }

        private void btnQLLN_Click(object sender, EventArgs e)
        {
                fLoaiNuoc loai = new fLoaiNuoc();
                this.Hide();
                loai.ShowDialog();
        }

        private void btnQLThe_Click(object sender, EventArgs e)
        {
                fLoaiThe lt = new fLoaiThe();
                this.Hide();
                lt.ShowDialog();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
                fKhachHang kh = new fKhachHang();
                this.Hide();
                kh.ShowDialog();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
                fNhanVien nv = new fNhanVien();
                this.Hide();
                nv.ShowDialog();   
        }

        private void btnQLCS_Click(object sender, EventArgs e)
        {
                fCoSo coSo = new fCoSo();
                this.Hide();
                coSo.ShowDialog();
        }

        private void btnQLNCC_Click(object sender, EventArgs e)
        {
                fNCC ncc = new fNCC();
                this.Hide();
                ncc.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
                fThongKe tk = new fThongKe();
                this.Hide();
                tk.ShowDialog();
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            fBanNuoc ban = new fBanNuoc();
            this.Hide();
            ban.ShowDialog();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            LoadThoiGian();
        }

        void LoadThoiGian()
        {
            DateTime nowTime = DateTime.Now;
            lbTime.Text = nowTime.ToString("dd/MM/yyyy");
        }
    }
}
