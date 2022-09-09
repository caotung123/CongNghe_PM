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
    public partial class fNCC : Form
    {
        public fNCC()
        {
            InitializeComponent();
        }

        Modify_NCC mdf;
        NCC ncc;

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mancc = this.txtMaNCC.Text;
            string tenncc = this.txtTenNCC.Text;
            string diachi = this.txtDC.Text;
            string sdt = this.txtDT.Text;

            ncc = new NCC(mancc, tenncc, diachi, sdt);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mdf.themNCC(ncc))
            {
                dtgvNCC.DataSource = mdf.getAllNCC();
            }
            else
            {
                MessageBox.Show("Kết nối lỗi: " + "Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mancc = dtgvNCC.SelectedRows[0].Cells[0].Value.ToString();
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mdf.xoaNCC(mancc))
            {
                dtgvNCC.DataSource = mdf.getAllNCC();
            }
            else
            {
                MessageBox.Show("Kết nối lỗi: " + "Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mancc = this.txtMaNCC.Text;
            string tenncc = this.txtTenNCC.Text;
            string diachi = this.txtDC.Text;
            string sdt = this.txtDT.Text;

            ncc = new NCC(mancc, tenncc, diachi, sdt);
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mdf.suaNCC(ncc))
            {
                dtgvNCC.DataSource = mdf.getAllNCC();
            }
            else
            {
                MessageBox.Show("Kết nối lỗi: " + "Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void binding()
        {
            txtMaNCC.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtMaNCC.DataBindings.Add("text", dtgvNCC.DataSource, "MANCC");
            txtTenNCC.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtTenNCC.DataBindings.Add("text", dtgvNCC.DataSource, "TENNCC");
            txtDC.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtDC.DataBindings.Add("text", dtgvNCC.DataSource, "DIACHI");
            txtDT.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtDT.DataBindings.Add("text", dtgvNCC.DataSource, "SDT");
        }

        private void fNCC_Load(object sender, EventArgs e)
        {
            mdf = new Modify_NCC();
            try
            {
                dtgvNCC.DataSource = mdf.getAllNCC();
                binding();
            }
            catch(Exception ex)
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
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtDC.Clear();
            txtDT.Clear();
            txtMaNCC.Focus();
        }

        private void ExportExcel(string path)
        {
            Excel.Application app = new Excel.Application();
            app.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dtgvNCC.Columns.Count; i++)
            {
                app.Cells[1, i + 1] = dtgvNCC.Columns[i].HeaderText;
            }

            for (int i = 0; i < dtgvNCC.Rows.Count; i++)
            {
                for (int j = 0; j < dtgvNCC.Columns.Count; j++)
                {
                    app.Cells[i + 2, j + 1] = dtgvNCC.Rows[i].Cells[j].Value;
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
