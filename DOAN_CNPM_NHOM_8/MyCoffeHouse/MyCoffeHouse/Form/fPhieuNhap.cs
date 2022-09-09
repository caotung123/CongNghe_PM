using MyCoffeHouse.SQL;
using MyCoffeHouse.ThuocTinh;
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
    public partial class fPhieuNhap : Form
    {
        public fPhieuNhap()
        {
            InitializeComponent();
        }

        Modify_PhieuNhap mdf;
        PhieuNhap phieuNhap;

        private void btnReSet_Click(object sender, EventArgs e)
        {
            txtMaPN.Clear();
            cbnv.Items.Clear();
            cbncc.Items.Clear();
            cbcs.Items.Clear();
            txtTT.Clear();
            txtMaPN.Focus();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            fMain a = new fMain();
            this.Hide();
            a.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mapn = dtgvPN.SelectedRows[0].Cells[0].Value.ToString();
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mdf.xoaPN(mapn))
            {
                dtgvPN.DataSource = mdf.getAllPN();
            }
            else
            {
                MessageBox.Show("Kết nối lỗi: " + "Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mapn = this.txtMaPN.Text;
            string manv = this.cbnv.Text;
            string mancc = this.cbncc.Text;
            string macs = this.cbcs.Text;
            DateTime ngaylap = this.dtpNL.Value;
            int tongtien = this.GetTongTien();

            phieuNhap = new PhieuNhap(mapn, manv, mancc, macs, ngaylap, tongtien);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mdf.themPN(phieuNhap))
            {
                dtgvPN.DataSource = mdf.getAllPN();
            }
            else
            {
                MessageBox.Show("Kết nối lỗi: " + "Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetTongTien()
        {
            return Int32.Parse(txtTT.Text);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mapn = this.txtMaPN.Text;
            string manv = this.cbnv.Text;
            string mancc = this.cbncc.Text;
            string macs = this.cbcs.Text;
            DateTime ngaylap = this.dtpNL.Value;
            int tongtien = this.GetTongTien();

            phieuNhap = new PhieuNhap(mapn, manv, mancc, macs, ngaylap, tongtien);
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mdf.suaPN(phieuNhap))
            {
                dtgvPN.DataSource = mdf.getAllPN();
            }
            else
            {
                MessageBox.Show("Kết nối lỗi: " + "Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void binding()
        {
            txtMaPN.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtMaPN.DataBindings.Add("text", dtgvPN.DataSource, "MAPN");
            cbnv.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            cbnv.DataBindings.Add("text", dtgvPN.DataSource, "MANV");
            cbncc.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            cbncc.DataBindings.Add("text", dtgvPN.DataSource, "MANCC");
            cbcs.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            cbcs.DataBindings.Add("text", dtgvPN.DataSource, "MACS");
            dtpNL.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            dtpNL.DataBindings.Add("text", dtgvPN.DataSource, "NGAYLAP");
            txtTT.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtTT.DataBindings.Add("text", dtgvPN.DataSource, "TONGTIEN");
        }

        private void fPhieuNhap_Load(object sender, EventArgs e)
        {
            mdf = new Modify_PhieuNhap();
            try
            {
                dtgvPN.DataSource = mdf.getAllPN();
                mdf.loadcbNV(cbnv);
                mdf.loadcbNCC(cbncc);
                mdf.loadcbCS(cbcs);
                binding();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            fBaoCaoPhieuNhap bcpn = new fBaoCaoPhieuNhap();
            this.Hide();
            bcpn.Show();
        }
    }
}
