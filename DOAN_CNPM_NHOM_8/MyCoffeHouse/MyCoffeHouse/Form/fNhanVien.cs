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
using Excel = Microsoft.Office.Interop.Excel;

namespace MyCoffeHouse
{
    public partial class fNhanVien : Form
    {
        public fNhanVien()
        {
            InitializeComponent();
        }

        Modify_NhanVien mdf;
        NhanVien nhanVien;

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string manv = dtgvNV.SelectedRows[0].Cells[0].Value.ToString();
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mdf.xoaNV(manv))
            {
                dtgvNV.DataSource = mdf.getAllNV();
            }
            else
            {
                MessageBox.Show("Kết nối lỗi: " + "Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string manv = this.txtMaNV.Text;
            string tennv = this.txtTenNV.Text;
            DateTime ngaysinh = this.dtpNS.Value;
            string gioitinh = (rdbGTNam.Checked ? rdbGTNam.Text : rdbGTNu.Text);
            string diachi = this.txtDC.Text;
            string cmnd = this.txtCMND.Text;
            string sdt = this.txtDT.Text;
            string chucvu = this.txtCV.Text;
            string macs = this.cbcs.Text;
            nhanVien = new NhanVien(manv, tennv, ngaysinh, gioitinh, diachi, cmnd, sdt, chucvu, macs);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mdf.themNV(nhanVien))
            {
                dtgvNV.DataSource = mdf.getAllNV();
            }
            else
            {
                MessageBox.Show("Kết nối lỗi: " + "Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string manv = this.txtMaNV.Text;
            string tennv = this.txtTenNV.Text;
            DateTime ngaysinh = this.dtpNS.Value;
            string gioitinh = (rdbGTNam.Checked ? rdbGTNam.Text : rdbGTNu.Text);
            string diachi = this.txtDC.Text;
            string cmnd = this.txtCMND.Text;
            string sdt = this.txtDT.Text;
            string chucvu = this.txtCV.Text;
            string macs = this.cbcs.Text;
            nhanVien = new NhanVien(manv, tennv, ngaysinh, gioitinh, diachi, cmnd, sdt, chucvu, macs);
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mdf.suaNV(nhanVien))
            {
                dtgvNV.DataSource = mdf.getAllNV();
            }
            else
            {
                MessageBox.Show("Kết nối lỗi: " + "Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void binding()
        {
            txtMaNV.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtMaNV.DataBindings.Add("text", dtgvNV.DataSource, "MANV");
            txtTenNV.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtTenNV.DataBindings.Add("text", dtgvNV.DataSource, "TENNV");
            dtpNS.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            dtpNS.DataBindings.Add("text", dtgvNV.DataSource, "NGAYSINH");
            txtDC.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtDC.DataBindings.Add("text", dtgvNV.DataSource, "DIACHI");
            txtCMND.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtCMND.DataBindings.Add("text", dtgvNV.DataSource, "CMND");
            txtDT.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtDT.DataBindings.Add("text", dtgvNV.DataSource, "SDT");
            txtCV.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtCV.DataBindings.Add("text", dtgvNV.DataSource, "CHUCVU");
            cbcs.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            cbcs.DataBindings.Add("text", dtgvNV.DataSource, "MACS");
        }

        private void fNhanVien_Load(object sender, EventArgs e)
        {
            mdf = new Modify_NhanVien();
            try
            {
                dtgvNV.DataSource = mdf.getAllNV();
                mdf.loadcbCS(cbcs);
                binding();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            fMain a = new fMain();
            this.Hide();
            a.ShowDialog();
        }

        private void btnReSet_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtDC.Clear();
            txtCMND.Clear();
            txtDT.Clear();
            txtCV.Clear();
            txtMaNV.Focus();
        }

        private void ExportExcel(string path)
        {
            Excel.Application app = new Excel.Application();
            app.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dtgvNV.Columns.Count; i++)
            {
                app.Cells[1, i + 1] = dtgvNV.Columns[i].HeaderText;
            }

            for (int i = 0; i < dtgvNV.Rows.Count; i++)
            {
                for (int j = 0; j < dtgvNV.Columns.Count; j++)
                {
                    app.Cells[i + 2, j + 1] = dtgvNV.Rows[i].Cells[j].Value;
                }
            }
            app.Columns.AutoFit();
            app.ActiveWorkbook.SaveCopyAs(path);
            app.ActiveWorkbook.Saved = true;
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog svfd = new SaveFileDialog();
            svfd.Title = "Export Excel";
            svfd.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2019 (*.xls)|*.xls";
            if (svfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(svfd.FileName);
                    MessageBox.Show("Xuất file thành công", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!\n" + ex.Message);
                }
            }
        }
    }
}
