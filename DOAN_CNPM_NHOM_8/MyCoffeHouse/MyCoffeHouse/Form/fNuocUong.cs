using MyCoffeHouse.SQL;
using MyCoffeHouse.ThuocTinh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCoffeHouse
{
    public partial class fNuocUong : Form
    {
        public fNuocUong()
        {
            InitializeComponent();
        }
        Connection con = new Connection();
        Modify_NuocUong mdf;
        NuocUong nu;

        private byte[] ImageToByteArray(PictureBox pictureBox)
        {
            MemoryStream memoryStream = new MemoryStream();
            imgHinhAnh.Image.Save(memoryStream, pictureBox.Image.RawFormat);
            return memoryStream.ToArray();
        }

        private void btnAddHinh_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();

                dlg.Filter = "Image File (*.jpg;*.jpeg;*.bmp;*.gif;*.png)|*.jpg;*.jpeg;*.bmp;*.gif;*.png";
                dlg.Title = "Chọn Hình";

                DialogResult dlgRes = dlg.ShowDialog();
                if (dlgRes != DialogResult.Cancel)
                {
                    //Gán hình vào Picture box
                    imgHinhAnh.ImageLocation = dlg.FileName;
                    imgHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                    //Gán đường dẫn ảnh vào lbimgpath
                    imgHinhAnh.Text = dlg.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int GetDongia()
        {
            return Int32.Parse(txtDG.Text);
        }

        private int GetTonKho()
        {
            return Int32.Parse(txtTonKho.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            byte[] hinhanh = ImageToByteArray(imgHinhAnh);
            string manuoc = this.txtManuoc.Text;
            string tennuoc = this.txtTennuoc.Text;
            string dvt = this.txtDVT.Text;   
            int dongia = GetDongia();
            int tonkho = GetTonKho();
            string maloai = this.cbloai.Text;

            nu = new NuocUong(hinhanh, manuoc, tennuoc, dvt, dongia, tonkho, maloai);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mdf.themNU(nu))
            {
                dtgvNU.DataSource = mdf.getAllNuocUong();
            }
            else
            {
                MessageBox.Show("Kết nối lỗi: " + "Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            byte[] hinhanh = ImageToByteArray(imgHinhAnh);
            string manuoc = this.txtManuoc.Text;
            string tennuoc = this.txtTennuoc.Text;
            string dvt = this.txtDVT.Text;
            int dongia = GetDongia();
            int tonkho = GetTonKho();
            string maloai = this.cbloai.Text;

            nu = new NuocUong(hinhanh, manuoc, tennuoc, dvt, dongia, tonkho, maloai);
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mdf.suaNU(nu))
            {
                dtgvNU.DataSource = mdf.getAllNuocUong();
            }
            else
            {
                MessageBox.Show("Kết nối lỗi: " + "Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string manuoc = dtgvNU.SelectedRows[0].Cells[0].Value.ToString();
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mdf.xoaNU(manuoc))
            {
                dtgvNU.DataSource = mdf.getAllNuocUong();
            }
            else
            {
                MessageBox.Show("Kết nối lỗi: " + "Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void binding()
        {
            imgHinhAnh.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            imgHinhAnh.DataBindings.Add("text", dtgvNU.DataSource, "HINHANH");
            txtManuoc.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtManuoc.DataBindings.Add("text", dtgvNU.DataSource, "MANUOC");
            txtTennuoc.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtTennuoc.DataBindings.Add("text", dtgvNU.DataSource, "TENNUOC");
            txtDVT.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtDVT.DataBindings.Add("text", dtgvNU.DataSource, "DVT");
            txtDG.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtDG.DataBindings.Add("text", dtgvNU.DataSource, "DONGIA");
            txtTonKho.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            txtTonKho.DataBindings.Add("text", dtgvNU.DataSource, "TONKHO");
            cbloai.DataBindings.Clear(); //Xoa du lieu hien co cua text box
            cbloai.DataBindings.Add("text", dtgvNU.DataSource, "MALOAI");
        }

        private void fNuocUong_Load(object sender, EventArgs e)
        {
            mdf = new Modify_NuocUong();
            try
            {
                dtgvNU.DataSource = mdf.getAllNuocUong();
                mdf.loadcbLoai(cbloai);
                binding();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Kết nối lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtthongtin_TextChanged(object sender, EventArgs e)
        {
            if (txtthongtin.Text.Length == 0)
            {
                string sql = @"SELECT hinhanh, manuoc, tennuoc, dvt, dongia, tonkho, maloai FROM NUOCUONG";
                dtgvNU.DataSource = con.taobang(sql);

                SqlConnection sqlcon = Connection.getcon();
                sqlcon.Open();
            }
            if (op1.Checked)
            {
                string sql = @"SELECT hinhanh, manuoc, tennuoc, dvt, dongia, tonkho, maloai FROM NUOCUONG WHERE manuoc= '" + txtthongtin.Text + "'";
                dtgvNU.DataSource = con.taobang(sql);

                SqlConnection sqlcon = Connection.getcon();
                sqlcon.Open();
            }
            if (op2.Checked)
            {
                string sql = @"SELECT hinhanh, manuoc, tennuoc, dvt, dongia, tonkho, maloai FROM NUOCUONG WHERE tennuoc= '" + txtthongtin.Text + "'";
                dtgvNU.DataSource = con.taobang(sql);

                SqlConnection sqlcon = Connection.getcon();
                sqlcon.Open();
            }
            if (op3.Checked)
            {
                string sql = @"SELECT hinhanh, manuoc, tennuoc, dvt, dongia, tonkho, maloai FROM NUOCUONG WHERE maloai= '" + txtthongtin.Text + "'";
                dtgvNU.DataSource = con.taobang(sql);

                SqlConnection sqlcon = Connection.getcon();
                sqlcon.Open();
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
            txtManuoc.Clear();
            txtTennuoc.Clear();
            txtDVT.Clear();
            txtDG.Clear();
            txtTonKho.Clear();
            txtManuoc.Focus();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            fBaoCaoNuocUong bcnu = new fBaoCaoNuocUong();
            this.Hide();
            bcnu.Show();
        }
    }
}
