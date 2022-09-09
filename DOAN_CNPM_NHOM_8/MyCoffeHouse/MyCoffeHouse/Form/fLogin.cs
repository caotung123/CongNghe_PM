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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        Connection con = new Connection();

        Modify_DangNhap mdf = new Modify_DangNhap();
        DangNhap dangNhap = new DangNhap();

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public bool kiemtrauser(string user, string pass, string manv)
        {
            dangNhap.Username = user;
            dangNhap.Password = pass;
            dangNhap.Manv = manv;
            return mdf.Kiemtrauser(dangNhap);
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            string user = this.txtuser.Text;
            string pass = this.txtpass.Text;
            string manv = this.cbnv.Text;
            try
            {
                dangNhap.Username = user;
                dangNhap.Password = pass;
                dangNhap.Manv = manv;
                if (!kiemtrauser(user, pass, manv))
                {
                    MessageBox.Show("Đăng Nhập Thành Công", "Chúc Mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fMain frm = new fMain();
                    this.Hide();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tài khoản đăng nhập chưa đúng. Vui lòng kiểm tra lại.", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtuser.Text = "";
                    txtpass.Text = "";
                    cbnv.Text = "";
                    txtuser.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                SendKeys.Send("{TAB}");
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnDN.Enabled = false;
                btnDN_Click(sender, e);
            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            mdf.loadcbnv(cbnv);
        }
    }
}
