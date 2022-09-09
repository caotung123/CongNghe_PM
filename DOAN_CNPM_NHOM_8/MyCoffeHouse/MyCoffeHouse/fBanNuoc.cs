
using MyCoffeHouse.DuLieuBanNuoc;
using MyCoffeHouse.Returns;
using MyCoffeHouse.ThuocTinh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCoffeHouse
{
    public partial class fBanNuoc : Form
    {
        public fBanNuoc()
        {
            InitializeComponent();
        }

        //BanNuocData bndata;
        //HoaDonData hddata;
        //NuocUongData nudata;
        private void fBanNuoc_Load(object sender, EventArgs e)
        {
            LoadThoiGian();
            LoadBanNuoc();
            LoadNuocUong();
        }

        //==================Lấy ngày tháng năm hiện tại======================
        void LoadThoiGian()
        {
            DateTime nowTime = DateTime.Now;
            lbTime.Text = nowTime.ToString("dd/MM/yyyy");
        }

        //==================Load Nước Uống========================
        private void LoadNuocUong()
        {
            List<NuocUong> lstNuoc = R_NuocUong.LoadNuocUong();
            dgvDanhSachNuocUong.DataSource = lstNuoc;

            if (lstNuoc == null)
                return;

            dgvDanhSachNuocUong.Columns["MANUOC"].HeaderText = "MÃ NƯỚC";
            dgvDanhSachNuocUong.Columns["TENNUOC"].HeaderText = "TÊN NƯỚC";
            dgvDanhSachNuocUong.Columns["DVT"].HeaderText = "Đơn Vị Tính";
            dgvDanhSachNuocUong.Columns["DONGIA"].HeaderText = "Đơn Giá";

            dgvDanhSachNuocUong.Columns["MANUOC"].Width = 50;
            dgvDanhSachNuocUong.Columns["TENNUOC"].Width = 150;
            dgvDanhSachNuocUong.Columns["DVT"].Width = 100;
            dgvDanhSachNuocUong.Columns["DONGIA"].Width = 124;
        }
        //==========================End==================================
        //========================Load danh sách bàn=========================
        public List<BanNuoc> dsBan;
        ListViewItem banNuoc;
        private void LoadBanNuoc()
        {
            dsBan = R_BanNuoc.LoadBanNuoc();
            if (dsBan == null)
                return;
            for (int i = 0; i < dsBan.Count; i++)
            {
                banNuoc = new ListViewItem();
                if (dsBan[i].Status == "Có Người")
                    banNuoc.ImageIndex = 0;
                else
                    banNuoc.ImageIndex = 1;
                
                banNuoc.Text = dsBan[i].Tenban;
                lstBanNuoc.Items.Add(banNuoc);
            }

            //foreach (BanNuoc item in dsBan)
            //{
            //    Button btn = new Button() { Width = R_BanNuoc.TableWidth, Height = R_BanNuoc.TableHeight };
            //    btn.Text = item.Tenban + Environment.NewLine + item.Status;
            //    lstBanNuoc.Controls.Add(btn);
            //}

        }
        //===============End==============

        //==========================Load hóa đơn=========================
        List<HoaDon> dsHoaDon;
        private void LoadHoaDon(int maban)
        {
            int tongTien = 0;
            lstHoaDon.Items.Clear(); //Xóa tất cả các dòng trên listView để tránh bị trùng
            dsHoaDon = R_HoaDon.LoadHoaDon(maban); //Lấy hóa đơn của bàn đang được chọn 
            if(dsHoaDon == null) //Nếu ko có hóa đơn tiền = 0
            {
                txtTongCong.Text = "0";
                txtThanhTien.Text = "0";
                return;
            }  
            else //Nếu có hóa đơn thì tính
            {
                for (int i = 0; i < dsHoaDon.Count; i++) //Duyệt từ đầu danh sách đến cuối danh sách
                {
                    ListViewItem lsvi = new ListViewItem(dsHoaDon[i].Tennuoc.ToString()); //Tạo ra 1 item trong listView
                    lsvi.SubItems.Add(dsHoaDon[i].Soluong.ToString());
                    lsvi.SubItems.Add(dsHoaDon[i].Gia.ToString());
                    lsvi.SubItems.Add(dsHoaDon[i].Thanhtien.ToString());

                    tongTien += int.Parse(lsvi.SubItems[3].Text.ToString()); //Tính tổng tiền
                    lstHoaDon.Items.Add(lsvi);
                }

                //Gán tiền vào text box
                txtTongCong.Text = tongTien.ToString();
                txtThanhTien.Text = txtTongCong.Text.ToString();
            }    
        }
        //===============End===================

        //==========================In hóa đơn=========================
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            fBaoCao frm = new fBaoCao();
            this.Hide();
            frm.ShowDialog();
        }

        // Sự kiện khi nhấn vào 1 bàn nước thì tất cập nhật trạng thái và cập nhật hóa đơn cho bàn đó
        public int indexTable = -1; // lưu chỉ số của bàn đang được chọn

        private void lstBanNuoc_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            indexTable = e.ItemIndex;  // khi click vào bàn nào thì lưu lại chỉ số của bàn đó

            for (int i = 0; i < lstBanNuoc.Items.Count; i++)  // duyệt tất cả các bàn
            {
                if (lstBanNuoc.Items[i].Selected)  // kiểm tra nếu bàn nào được click thì
                {
                    if (lstBanNuoc.Items[i].ImageIndex == 1)  // nếu bàn đó đang trống thì màu chữ trạng thái có màu đỏ
                    {
                        lbBan.ForeColor = Color.Red;
                        lbTrangThai.ForeColor = Color.Red;
                        lbTrangThai.Text = "Trống";
                    }
                    else  // ngược lại thì màu chữ là màu xanh
                    {
                        lbBan.ForeColor = Color.ForestGreen;
                        lbTrangThai.ForeColor = Color.ForestGreen;
                        lbTrangThai.Text = "Có Người";
                    }
                    // load trạng thái cho label bàn
                    lbBan.Text = dsBan[i].Tenban.ToString();

                    // hiển thị hóa đơn
                    LoadHoaDon(dsBan[i].Maban);
                }
            }
        }

        //======================================Khuyến Mãi=========================================
        //Chỉ cho phép nhập số vào textbox Khuyến mãi (Không được nhập chữ)
        private void txtKhuyenMai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }    
        }

        //Khuyến mãi theo tiền
        private void txtKhuyenMai_TextChanged(object sender, EventArgs e)
        {
            if (txtKhuyenMai.Text != "" && txtTongCong.Text != "")
            {
                int tongCong, khuyenMai;
                try
                {
                    tongCong = int.Parse(txtTongCong.Text.ToString());
                    khuyenMai = int.Parse(txtKhuyenMai.Text.ToString());
                }
                catch(Exception)
                {
                    return;
                }

                if(khuyenMai > tongCong)
                {
                    MessageBox.Show("Mã khuyến mãi không hợp lệ. Hãy kiểm tra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtKhuyenMai.Text = "0";
                    return;
                }
                else
                {
                    txtThanhTien.Text = (tongCong - khuyenMai).ToString();
                }
            }
        }

        //Chỉ cho phép nhập số vào textbox phần chăm
        private void txtPhanCham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhanCham_TextChanged(object sender, EventArgs e)
        {
            if(txtPhanCham.Text != "" && txtTongCong.Text != "")
            {
                int tongCong = int.Parse(txtTongCong.Text.ToString());
                int khuyenMai = int.Parse(txtPhanCham.Text.ToString());
                if(khuyenMai > 100)
                {
                    MessageBox.Show("Mã khuyến mãi không hợp lệ. Hãy kiểm tra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPhanCham.Text = "0";
                    return;
                }
                else
                {
                    txtThanhTien.Text = (tongCong - ((tongCong * khuyenMai) / 100)).ToString();
                }
            }    
        }
        //=============End==============
        //==============================Mở bàn cho khách======================================
        private void btnMoBan_Click(object sender, EventArgs e)
        {
            if (indexTable == -1) // nếu chưa có bàn nào được chọn
            {
                MessageBox.Show("Chọn 1 Bàn Để Mở", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (lstBanNuoc.Items[indexTable].ImageIndex == 0)  // Nếu Bàn Đang Mở thì không thêm hóa đơn nữa
            {
                MessageBox.Show("Bàn Đang Mở", "Thông Báo");
                return;
            }
            // khi click thì thêm 1 hóa đơn vào bảng hóa đơn

            // nếu Thêm hóa đơn thành công thì Bàn sẽ màu xanh và trạng thái thành có người
            if (R_HoaDon.themHD(dsBan[indexTable].Maban) == true && R_BanNuoc.SuaTrangThaiThanhCoNguoi(dsBan[indexTable].Maban) == true)
            {

                lbTrangThai.Text = "Có Người";
                lstBanNuoc.Items[indexTable].ImageIndex = 0;

                lbBan.ForeColor = Color.Green;
                lbTrangThai.ForeColor = Color.Green;

                MessageBox.Show("Đã Mở Bàn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            MessageBox.Show("Lỗi. Không thể mở bàn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //=============End===========
        //==============================Thêm nước========================
        DataGridViewRow dgvr = new DataGridViewRow(); //Lưu thông tin của 1 dòng trong dtgv nước uống

        private void dgvDanhSachNuocUong_Click(object sender, EventArgs e)
        {
            try
            {
                dgvr = dgvDanhSachNuocUong.SelectedRows[0]; //Lưu lại thông tin của 1 dòng được chọn
            }
            catch(Exception)
            {
                return;
            }
        }

        int soluong = 1; //Số lượng món nước tự động bằng 1

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (indexTable == -1)
            {
                MessageBox.Show("Chọn bàn muốn thêm", "Thông báo");
                return;
            }    
            
            if(banNuoc.ImageIndex == 1)
            {
                MessageBox.Show("Phải mở bàn để thêm nước", "Thông báo");
                return;
            }

            if (lstBanNuoc.Items.Count > 0)
            {
                for (int i = 0; i < lstHoaDon.Items.Count; i++)
                {
                    try
                    {
                        if (lstHoaDon.Items[i].SubItems[0].Text.ToString() == dgvr.Cells["TENNUOC"].Value.ToString())
                        {
                            MessageBox.Show("Nước uống đã có rồi", "Thông Báo");
                            return;
                        }
                    }
                    catch (Exception) // có lỗi ở chỗ này thì thoát
                    {
                        MessageBox.Show("Nước uống đã có rồi", "Thông Báo");
                        return;
                    }
                }
            }
            ListViewItem lstItem;
            try
            {
                lstItem = new ListViewItem(dgvr.Cells["TenNuoc"].Value.ToString());
                lstItem.SubItems.Add("1");
                lstItem.SubItems.Add(dgvr.Cells["Gia"].Value.ToString());
                lstItem.SubItems.Add((soluong * int.Parse(dgvr.Cells["Gia"].Value.ToString())).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Chọn Nước Uống Muốn Thêm", "Thông Báo");
                return;
            }
            lstHoaDon.Items.Add(lstItem);
            //------------ ID Hóa Đơn ----------------------- //  //----------- ID Nước Uống ----------------// //---------------- Số Lượng -----------------//
            R_HoaDon.themTTHD(R_HoaDon.getIDHoaDon(dsBan[indexTable].Maban), dgvr.Cells["MANUOC"].Value.ToString(), int.Parse(lstItem.SubItems[1].Text.ToString()));

            LoadHoaDon(dsBan[indexTable].Maban); //Sau khi thêm thì load lại hóa đơn
        }

        //Lấy dòng 1 của nước uống trong lsthoadon
        int chisoHD = -1;
        private void lstHoaDon_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            chisoHD = e.ItemIndex;
        }

        //Tăng số lượng nước lên 1;
        private void btnThem1_Click(object sender, EventArgs e)
        {
            int sl;
            try
            {
                sl = int.Parse(lstHoaDon.Items[chisoHD].SubItems[1].Text.ToString());
            }
            catch (Exception)
            {
                return;
            }
            if (chisoHD != -1)
            {
                sl = sl + 1;
                lstHoaDon.Items[chisoHD].SubItems[1].Text = sl.ToString(); // tăng số lượng món ăn trong lstHoaDon lên 1

                // cập nhật số lượng món ăn trong Cơ Sở Dữ Liệu
                // ------------------  ID hóa đơn --------------- // //----------------- id món ăn -----------------------------------------------------//
                R_HoaDon.CapNhatSoLuongNU(sl, R_HoaDon.getIDHoaDon(dsBan[indexTable].Maban), R_NuocUong.layMaNuocUong(lstHoaDon.Items[chisoHD].SubItems[0].Text.ToString()));

                LoadHoaDon(dsBan[indexTable].Maban); // sau khi thêm thì load lại hóa đơn 
            }
        }

        //Giảm số lượng nước đi 1
        private void btnGiam1_Click(object sender, EventArgs e)
        {
            int sl;
            try
            {
                sl = int.Parse(lstHoaDon.Items[chisoHD].SubItems[1].Text.ToString());
            }
            catch (Exception)
            {
                return;
            }
            if (chisoHD != -1)
            {
                if (sl > 1)
                    sl = sl - 1;
                lstHoaDon.Items[chisoHD].SubItems[1].Text = sl.ToString(); // Giảm số lượng món nước đi 1
                                                                                     // cập nhật lại số lượng món nước trong cơ sở dữ liệu
                                                                                     // ------------------  ID hóa đơn --------------- //  // -------------------- id món nước -------------------------------------------------//
                R_HoaDon.CapNhatSoLuongNU(sl, R_HoaDon.getIDHoaDon(dsBan[indexTable].Maban), R_NuocUong.layMaNuocUong(lstHoaDon.Items[chisoHD].SubItems[0].Text.ToString()));

                LoadHoaDon(dsBan[indexTable].Maban);  // sau khi thêm thì load lại hóa đơn 
            }
        }
        //================End===============

        //===========================Bớt Món Nước============================
        private void btnBotMon_Click(object sender, EventArgs e)
        {
            if(lstHoaDon.Items.Count < 1)
            {
                return;
            }    

            if(chisoHD != -1)
            {
                //Xóa món nước dựa vào mã hóa đơn và mã nước uống
                try
                {
                    //Xóa món nước trong csdl dựa vào mã hóa đơn và mã nước uống
                    R_HoaDon.XoaNU(R_HoaDon.getIDHoaDon(dsBan[indexTable].Maban), R_NuocUong.layMaNuocUong(lstHoaDon.Items[chisoHD].SubItems[0].Text.ToString()));
                }
                catch(Exception)
                {
                    return;
                }

                lstHoaDon.Items.RemoveAt(chisoHD); //Xóa món nước trên listview
                LoadHoaDon(dsBan[indexTable].Maban); // sau khi thêm thì load lại hóa đơn 
            }    
        }
        //===============End================

        //=================================Thanh Toán====================================
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if(indexTable == -1)
            {
                return;
            }    

            if(banNuoc.ImageIndex == 1)
            {
                MessageBox.Show("Mở bàn để thanh toán", "Thông báo");
                return;
            }

            int tien = int.Parse(txtThanhTien.Text);
            CultureInfo cul = new CultureInfo("vi-VN"); //Định dạng tiền Việt
            string tienThanhToan = tien.ToString("c", cul);

            if(MessageBox.Show("Thanh toán: " + tienThanhToan, "Thanh toán", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //Xóa hết tất cả món nước trên bàn đó
                R_HoaDon.XoaTTHD(R_HoaDon.getIDHoaDon(dsBan[indexTable].Maban));

                //Cập nhật số tiền
                DateTime time = DateTime.Now;
                string ngayThanhToan = time.ToString("dd/MM/yyyy");

                try
                {
                    R_HoaDon.UpdateHoaDon(1, ngayThanhToan, int.Parse(txtThanhTien.Text), dsBan[indexTable].Maban);
                }
                catch(Exception)
                {
                    MessageBox.Show("Lỗi thanh toán", "Thông báo");
                    return;
                }

                //Sửa lại trạng thái bàn thành trống
                R_BanNuoc.SuaTrangThaiThanhBanTrong(dsBan[indexTable].Maban);
                lstBanNuoc.Items[indexTable].ImageIndex = 1;

                lbTrangThai.Text = "Trống";
                lbBan.ForeColor = Color.Red; //Load lại màu chữ cho label bàn thành màu đỏ
                lbTrangThai.ForeColor = Color.Red; //Load lại màu chữ cho label trạng thái thành màu đỏ

                LoadHoaDon(dsBan[indexTable].Maban); //Sau khi xóa thì load lại hóa đơn
            }    
        }
        //=================End==================


        //=============================Tìm kiếm===========================
        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            txtTimKiem.ForeColor = Color.Aqua;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            List<NuocUong> lstKQ = R_NuocUong.TimNuocUong(txtTimKiem.Text);
            if (lstKQ == null)
                return;
            dgvDanhSachNuocUong.DataSource = lstKQ;
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            txtTimKiem.Text = "Nhập tên nước...";
            txtTimKiem.ForeColor = Color.Gray;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            fMain a = new fMain();
            this.Hide();
            a.ShowDialog();
        }

        private void dgvDanhSachNuocUong_AllowUserToOrderColumnsChanged(object sender, EventArgs e)
        {

        }

        private void dgvDanhSachNuocUong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvDanhSachNuocUong_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {

        }

        private void lstBanNuoc_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if(lstBanNuoc.SelectedItems.Count > 0)
            {
                banNuoc = lstBanNuoc.SelectedItems[0];
                indexTable = banNuoc.Index;
            }
        }
        
    }
}
