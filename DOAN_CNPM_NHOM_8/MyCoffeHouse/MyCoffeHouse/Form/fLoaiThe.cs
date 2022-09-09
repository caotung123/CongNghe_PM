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
    public partial class fLoaiThe : Form
    {
        public fLoaiThe()
        {
            InitializeComponent();
        }

        Modify_LoaiThe mdf;
        LoaiThe lt;

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mathe = this.txtMathe.Text;
            string tenthe = this.txtTenthe.Text;
            string ghichu = this.txtGhichu.Text;

            lt = new LoaiThe(mathe, tenthe, ghichu);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mdf.themThe(lt))
            {
                dtgvLoaithe.DataSource = mdf.getAllLoaiThe();
            }
            else
            {
                MessageBox.Show("Kết nối lỗi: " + "Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mathe = dtgvLoaithe.SelectedRows[0].Cells[0].Value.ToString();
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mdf.xoaThe(mathe))
            {
                dtgvLoaithe.DataSource = mdf.getAllLoaiThe();
            }
            else
            {
                MessageBox.Show("Kết nối lỗi: " + "Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mathe = this.txtMathe.Text;
            string tenthe = this.txtTenthe.Text;
            string ghichu = this.txtGhichu.Text;

            lt = new LoaiThe(mathe, tenthe, ghichu);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mdf.suaThe(lt))
            {
                dtgvLoaithe.DataSource = mdf.getAllLoaiThe();
            }
            else
            {
                MessageBox.Show("Kết nối lỗi: " + "Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void binding()
        {
            txtMathe.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtMathe.DataBindings.Add("text", dtgvLoaithe.DataSource, "MATHE");
            txtTenthe.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtTenthe.DataBindings.Add("text", dtgvLoaithe.DataSource, "TENTHE");
            txtGhichu.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtGhichu.DataBindings.Add("text", dtgvLoaithe.DataSource, "GHICHU");
        }

        private void fLoaiThe_Load(object sender, EventArgs e)
        {
            mdf = new Modify_LoaiThe();
            try
            {
                dtgvLoaithe.DataSource = mdf.getAllLoaiThe();
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
            txtMathe.Clear();
            txtTenthe.Clear();
            txtGhichu.Clear();
            txtMathe.Focus();
        }

        private void ExportExcel(string path)
        {
            Excel.Application app = new Excel.Application();
            app.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dtgvLoaithe.Columns.Count; i++)
            {
                app.Cells[1, i + 1] = dtgvLoaithe.Columns[i].HeaderText;
            }

            for (int i = 0; i < dtgvLoaithe.Rows.Count; i++)
            {
                for (int j = 0; j < dtgvLoaithe.Columns.Count; j++)
                {
                    app.Cells[i + 2, j + 1] = dtgvLoaithe.Rows[i].Cells[j].Value;
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
