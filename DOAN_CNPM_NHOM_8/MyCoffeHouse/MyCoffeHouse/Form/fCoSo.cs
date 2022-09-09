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
    public partial class fCoSo : Form
    {
        public fCoSo()
        {
            InitializeComponent();
        }

        Modify_CoSo mdf;
        CoSo coSo;

        public void binding()
        {
            txtMaCS.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtMaCS.DataBindings.Add("text", dtgvCoSo.DataSource, "MACS");
            txtTenCS.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtTenCS.DataBindings.Add("text", dtgvCoSo.DataSource, "TENCS");
            txtDC.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtDC.DataBindings.Add("text", dtgvCoSo.DataSource, "DIACHI");
        }

        private void fCoSo_Load(object sender, EventArgs e)
        {
            mdf = new Modify_CoSo();
            try
            {
                dtgvCoSo.DataSource = mdf.getAllCoSo();
                binding();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string macs = this.txtMaCS.Text;
            string tencs = this.txtTenCS.Text;
            string diachi = this.txtDC.Text;

            coSo = new CoSo(macs, tencs, diachi);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mdf.themCS(coSo))
            {
                dtgvCoSo.DataSource = mdf.getAllCoSo();
            }
            else
            {
                MessageBox.Show("Kết nối lỗi: " + "Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string macs = dtgvCoSo.SelectedRows[0].Cells[0].Value.ToString();
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mdf.xoaCS(macs))
            {
                dtgvCoSo.DataSource = mdf.getAllCoSo();
            }
            else
            {
                MessageBox.Show("Kết nối lỗi: " + "Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string macs = this.txtMaCS.Text;
            string tencs = this.txtTenCS.Text;
            string diachi = this.txtDC.Text;

            coSo = new CoSo(macs, tencs, diachi);
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mdf.suaCS(coSo))
            {
                dtgvCoSo.DataSource = mdf.getAllCoSo();
            }
            else
            {
                MessageBox.Show("Kết nối lỗi: " + "Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtMaCS.Clear();
            txtTenCS.Clear();
            txtDC.Clear();
            txtMaCS.Focus();
        }

        private void ExportExcel(string path)
        {
            Excel.Application app = new Excel.Application();
            app.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dtgvCoSo.Columns.Count; i++)
            {
                app.Cells[1, i + 1] = dtgvCoSo.Columns[i].HeaderText;
            }

            for (int i = 0; i < dtgvCoSo.Rows.Count; i++)
            {
                for (int j = 0; j < dtgvCoSo.Columns.Count; j++)
                {
                    app.Cells[i + 2, j + 1] = dtgvCoSo.Rows[i].Cells[j].Value;
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
