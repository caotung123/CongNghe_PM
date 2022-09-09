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
    public partial class fLoaiNuoc : Form
    {
        public fLoaiNuoc()
        {
            InitializeComponent();
        }

        Modify_LoaiNuoc mdf;
        LoaiNuoc loai;

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maloai = this.txtMaloai.Text;
            string tenloai = this.txtTenloai.Text;

            loai = new LoaiNuoc(maloai, tenloai);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mdf.themLN(loai))
            {
                dtgvLoai.DataSource = mdf.getAllLoaiNuoc();
            }
            else
            {
                MessageBox.Show("Kết nối lỗi: " + "Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maloai = dtgvLoai.SelectedRows[0].Cells[0].Value.ToString();
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mdf.xoaLN(maloai))
            {
                dtgvLoai.DataSource = mdf.getAllLoaiNuoc();
            }
            else
            {
                MessageBox.Show("Kết nối lỗi: " + "Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maloai = this.txtMaloai.Text;
            string tenloai = this.txtTenloai.Text;

            loai = new LoaiNuoc(maloai, tenloai);
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mdf.suaLN(loai))
            {
                dtgvLoai.DataSource = mdf.getAllLoaiNuoc();
            }
            else
            {
                MessageBox.Show("Kết nối lỗi: " + "Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void binding()
        {
            txtMaloai.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtMaloai.DataBindings.Add("text", dtgvLoai.DataSource, "MALOAI");
            txtTenloai.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtTenloai.DataBindings.Add("text", dtgvLoai.DataSource, "TENLOAI");
        }
        private void fLoaiNuoc_Load(object sender, EventArgs e)
        {
            mdf = new Modify_LoaiNuoc();
            try
            {
                dtgvLoai.DataSource = mdf.getAllLoaiNuoc();
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
            txtMaloai.Clear();
            txtTenloai.Clear();
            txtMaloai.Focus();
        }

        private void ExportExcel(string path)
        {
            Excel.Application app = new Excel.Application();
            app.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dtgvLoai.Columns.Count; i++)
            {
                app.Cells[1, i + 1] = dtgvLoai.Columns[i].HeaderText;
            }

            for (int i = 0; i < dtgvLoai.Rows.Count; i++)
            {
                for (int j = 0; j < dtgvLoai.Columns.Count; j++)
                {
                    app.Cells[i + 2, j + 1] = dtgvLoai.Rows[i].Cells[j].Value;
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
