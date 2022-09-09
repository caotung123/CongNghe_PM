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
    public partial class fKhachHang : Form
    {
        public fKhachHang()
        {
            InitializeComponent();
        }

        Modify_KhachHang mdf;
        KhachHang khachHang;

        private int GetDiemTL()
        {
            return Int32.Parse(txtDiemTL.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string makh = this.txtMaKH.Text;
            string tenkh = this.txtTenKH.Text;
            string diachi = this.txtDC.Text;
            string sdt = this.txtDT.Text;
            int diemTL = GetDiemTL();
            string mathe = this.cbthe.Text;

            khachHang = new KhachHang(makh, tenkh, diachi, sdt, diemTL, mathe);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mdf.themKH(khachHang))
            {
                dtgvKH.DataSource = mdf.getAllKH();
            }
            else
            {
                MessageBox.Show("Kết nối lỗi: " + "Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string makh = this.txtMaKH.Text;
            string tenkh = this.txtTenKH.Text;
            string diachi = this.txtDC.Text;
            string sdt = this.txtDT.Text;
            int diemTL = GetDiemTL();
            string mathe = this.cbthe.Text;

            khachHang = new KhachHang(makh, tenkh, diachi, sdt, diemTL, mathe);
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mdf.suaKH(khachHang))
            {
                dtgvKH.DataSource = mdf.getAllKH();
            }
            else
            {
                MessageBox.Show("Kết nối lỗi: " + "Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string makh = dtgvKH.SelectedRows[0].Cells[0].Value.ToString();
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mdf.xoaKH(makh))
            {
                dtgvKH.DataSource = mdf.getAllKH();
            }
            else
            {
                MessageBox.Show("Kết nối lỗi: " + "Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void binding()
        {
            txtMaKH.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtMaKH.DataBindings.Add("text", dtgvKH.DataSource, "MAKH");
            txtTenKH.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtTenKH.DataBindings.Add("text", dtgvKH.DataSource, "TENKH");
            txtDC.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtDC.DataBindings.Add("text", dtgvKH.DataSource, "DIACHI");
            txtDT.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtDT.DataBindings.Add("text", dtgvKH.DataSource, "SDT");
            txtDiemTL.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtDiemTL.DataBindings.Add("text", dtgvKH.DataSource, "DIEMTL");
            cbthe.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            cbthe.DataBindings.Add("text", dtgvKH.DataSource, "MATHE");
        }

        private void fKhachHang_Load(object sender, EventArgs e)
        {
            mdf = new Modify_KhachHang();
            try
            {
                dtgvKH.DataSource = mdf.getAllKH();
                mdf.loadcbthe(cbthe);
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
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtDC.Clear();
            txtDT.Clear();
            txtDiemTL.Clear();
            txtMaKH.Focus();
        }

        private void ExportExcel(string path)
        {
            Excel.Application app = new Excel.Application();
            app.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dtgvKH.Columns.Count; i++)
            {
                app.Cells[1, i + 1] = dtgvKH.Columns[i].HeaderText;
            }

            for (int i = 0; i < dtgvKH.Rows.Count; i++)
            {
                for (int j = 0; j < dtgvKH.Columns.Count; j++)
                {
                    app.Cells[i + 2, j + 1] = dtgvKH.Rows[i].Cells[j].Value;
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
