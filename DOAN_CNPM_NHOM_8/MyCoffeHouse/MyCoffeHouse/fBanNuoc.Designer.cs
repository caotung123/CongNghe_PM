
namespace MyCoffeHouse
{
    partial class fBanNuoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBanNuoc));
            this.label9 = new System.Windows.Forms.Label();
            this.lstHoaDon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.lbBan = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbT = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lstBanNuoc = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnBotMon = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.dgvDanhSachNuocUong = new System.Windows.Forms.DataGridView();
            this.lbTime = new System.Windows.Forms.Label();
            this.txtPhanCham = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKhuyenMai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongCong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnMoBan = new System.Windows.Forms.Button();
            this.btnThem1 = new System.Windows.Forms.Button();
            this.btnGiam1 = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.ttThemSLNuoc = new System.Windows.Forms.ToolTip(this.components);
            this.ttGiamSLNuoc = new System.Windows.Forms.ToolTip(this.components);
            this.imgBan = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNuocUong)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(632, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 157;
            this.label9.Text = "Ngày : ";
            // 
            // lstHoaDon
            // 
            this.lstHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstHoaDon.FullRowSelect = true;
            this.lstHoaDon.GridLines = true;
            this.lstHoaDon.HideSelection = false;
            this.lstHoaDon.Location = new System.Drawing.Point(414, 98);
            this.lstHoaDon.Name = "lstHoaDon";
            this.lstHoaDon.Size = new System.Drawing.Size(373, 358);
            this.lstHoaDon.TabIndex = 156;
            this.lstHoaDon.UseCompatibleStateImageBehavior = false;
            this.lstHoaDon.View = System.Windows.Forms.View.Details;
            this.lstHoaDon.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstHoaDon_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Nước";
            this.columnHeader1.Width = 123;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Lượng";
            this.columnHeader2.Width = 74;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Giá";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 96;
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.lbTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangThai.ForeColor = System.Drawing.Color.Red;
            this.lbTrangThai.Location = new System.Drawing.Point(679, 70);
            this.lbTrangThai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(72, 16);
            this.lbTrangThai.TabIndex = 155;
            this.lbTrangThai.Text = "Không có";
            // 
            // lbBan
            // 
            this.lbBan.AutoSize = true;
            this.lbBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.lbBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBan.ForeColor = System.Drawing.Color.Red;
            this.lbBan.Location = new System.Drawing.Point(679, 43);
            this.lbBan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBan.Name = "lbBan";
            this.lbBan.Size = new System.Drawing.Size(80, 16);
            this.lbBan.TabIndex = 154;
            this.lbBan.Text = "Chưa chọn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(894, 75);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 153;
            this.label11.Text = "Tìm Kiếm";
            // 
            // lbT
            // 
            this.lbT.AutoSize = true;
            this.lbT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.lbT.Location = new System.Drawing.Point(598, 70);
            this.lbT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbT.Name = "lbT";
            this.lbT.Size = new System.Drawing.Size(65, 13);
            this.lbT.TabIndex = 152;
            this.lbT.Text = "Trạng Thái :";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.lb.Location = new System.Drawing.Point(641, 43);
            this.lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(35, 13);
            this.lb.TabIndex = 151;
            this.lb.Text = "Bàn : ";
            // 
            // lstBanNuoc
            // 
            this.lstBanNuoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstBanNuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstBanNuoc.HideSelection = false;
            this.lstBanNuoc.Location = new System.Drawing.Point(11, 98);
            this.lstBanNuoc.Margin = new System.Windows.Forms.Padding(2);
            this.lstBanNuoc.Name = "lstBanNuoc";
            this.lstBanNuoc.Size = new System.Drawing.Size(398, 568);
            this.lstBanNuoc.TabIndex = 134;
            this.lstBanNuoc.UseCompatibleStateImageBehavior = false;
            this.lstBanNuoc.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstBanNuoc_ItemSelectionChanged);
            this.lstBanNuoc.SelectedIndexChanged += new System.EventHandler(this.lstBanNuoc_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(144, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 23);
            this.label8.TabIndex = 149;
            this.label8.Text = "Sơ Đồ Bàn Ăn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1074, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 23);
            this.label7.TabIndex = 148;
            this.label7.Text = "Danh Sách Món Ăn";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.Location = new System.Drawing.Point(948, 69);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(397, 20);
            this.txtTimKiem.TabIndex = 147;
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // btnBotMon
            // 
            this.btnBotMon.BackColor = System.Drawing.SystemColors.Control;
            this.btnBotMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBotMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBotMon.ForeColor = System.Drawing.Color.Black;
            this.btnBotMon.Location = new System.Drawing.Point(792, 238);
            this.btnBotMon.Margin = new System.Windows.Forms.Padding(2);
            this.btnBotMon.Name = "btnBotMon";
            this.btnBotMon.Size = new System.Drawing.Size(98, 52);
            this.btnBotMon.TabIndex = 146;
            this.btnBotMon.Text = "Bớt Món    >>";
            this.btnBotMon.UseVisualStyleBackColor = false;
            this.btnBotMon.Click += new System.EventHandler(this.btnBotMon_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.ForeColor = System.Drawing.Color.Black;
            this.btnThemMon.Location = new System.Drawing.Point(792, 181);
            this.btnThemMon.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(98, 53);
            this.btnThemMon.TabIndex = 145;
            this.btnThemMon.Text = "<<   Thêm Món";
            this.btnThemMon.UseVisualStyleBackColor = false;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // dgvDanhSachNuocUong
            // 
            this.dgvDanhSachNuocUong.AllowUserToAddRows = false;
            this.dgvDanhSachNuocUong.AllowUserToDeleteRows = false;
            this.dgvDanhSachNuocUong.AllowUserToResizeColumns = false;
            this.dgvDanhSachNuocUong.AllowUserToResizeRows = false;
            this.dgvDanhSachNuocUong.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachNuocUong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNuocUong.Location = new System.Drawing.Point(894, 98);
            this.dgvDanhSachNuocUong.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDanhSachNuocUong.MultiSelect = false;
            this.dgvDanhSachNuocUong.Name = "dgvDanhSachNuocUong";
            this.dgvDanhSachNuocUong.ReadOnly = true;
            this.dgvDanhSachNuocUong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachNuocUong.Size = new System.Drawing.Size(465, 567);
            this.dgvDanhSachNuocUong.TabIndex = 144;
            this.dgvDanhSachNuocUong.AllowUserToOrderColumnsChanged += new System.EventHandler(this.dgvDanhSachNuocUong_AllowUserToOrderColumnsChanged);
            this.dgvDanhSachNuocUong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachNuocUong_CellClick);
            this.dgvDanhSachNuocUong.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgvDanhSachNuocUong_CellContextMenuStripNeeded);
            this.dgvDanhSachNuocUong.Click += new System.EventHandler(this.dgvDanhSachNuocUong_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.lbTime.Location = new System.Drawing.Point(679, 17);
            this.lbTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(0, 13);
            this.lbTime.TabIndex = 158;
            // 
            // txtPhanCham
            // 
            this.txtPhanCham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhanCham.Location = new System.Drawing.Point(704, 508);
            this.txtPhanCham.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhanCham.Name = "txtPhanCham";
            this.txtPhanCham.Size = new System.Drawing.Size(48, 20);
            this.txtPhanCham.TabIndex = 169;
            this.txtPhanCham.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPhanCham.TextChanged += new System.EventHandler(this.txtPhanCham_TextChanged);
            this.txtPhanCham.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhanCham_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(756, 511);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 168;
            this.label6.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(676, 511);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(9, 13);
            this.label5.TabIndex = 167;
            this.label5.Text = "|";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(647, 511);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 166;
            this.label4.Text = "đ";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BackColor = System.Drawing.SystemColors.Window;
            this.txtThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtThanhTien.Location = new System.Drawing.Point(581, 539);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(192, 26);
            this.txtThanhTien.TabIndex = 164;
            this.txtThanhTien.Text = "0";
            this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 539);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 163;
            this.label3.Text = "Thành Tiền";
            // 
            // txtKhuyenMai
            // 
            this.txtKhuyenMai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKhuyenMai.Location = new System.Drawing.Point(581, 508);
            this.txtKhuyenMai.Margin = new System.Windows.Forms.Padding(2);
            this.txtKhuyenMai.Name = "txtKhuyenMai";
            this.txtKhuyenMai.Size = new System.Drawing.Size(62, 20);
            this.txtKhuyenMai.TabIndex = 162;
            this.txtKhuyenMai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtKhuyenMai.TextChanged += new System.EventHandler(this.txtKhuyenMai_TextChanged);
            this.txtKhuyenMai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKhuyenMai_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 508);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 161;
            this.label2.Text = "Khuyến Mãi";
            // 
            // txtTongCong
            // 
            this.txtTongCong.BackColor = System.Drawing.SystemColors.Window;
            this.txtTongCong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongCong.ForeColor = System.Drawing.Color.Red;
            this.txtTongCong.Location = new System.Drawing.Point(581, 471);
            this.txtTongCong.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongCong.Name = "txtTongCong";
            this.txtTongCong.ReadOnly = true;
            this.txtTongCong.Size = new System.Drawing.Size(192, 26);
            this.txtTongCong.TabIndex = 160;
            this.txtTongCong.Text = "0";
            this.txtTongCong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 479);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 159;
            this.label1.Text = "Tổng Cộng";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Image = global::MyCoffeHouse.Properties.Resources.Line_Chart;
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(650, 594);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(136, 50);
            this.btnThanhToan.TabIndex = 165;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnInHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDon.Image = global::MyCoffeHouse.Properties.Resources.Print;
            this.btnInHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHoaDon.Location = new System.Drawing.Point(506, 594);
            this.btnInHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(137, 50);
            this.btnInHoaDon.TabIndex = 170;
            this.btnInHoaDon.Text = "In Hóa Đơn";
            this.btnInHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnMoBan
            // 
            this.btnMoBan.BackColor = System.Drawing.Color.White;
            this.btnMoBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoBan.Location = new System.Drawing.Point(414, 41);
            this.btnMoBan.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoBan.Name = "btnMoBan";
            this.btnMoBan.Size = new System.Drawing.Size(94, 45);
            this.btnMoBan.TabIndex = 171;
            this.btnMoBan.Text = "Mở Bàn";
            this.btnMoBan.UseVisualStyleBackColor = false;
            this.btnMoBan.Click += new System.EventHandler(this.btnMoBan_Click);
            // 
            // btnThem1
            // 
            this.btnThem1.BackColor = System.Drawing.Color.Yellow;
            this.btnThem1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem1.Location = new System.Drawing.Point(518, 63);
            this.btnThem1.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem1.Name = "btnThem1";
            this.btnThem1.Size = new System.Drawing.Size(31, 27);
            this.btnThem1.TabIndex = 173;
            this.btnThem1.Text = "+";
            this.btnThem1.UseVisualStyleBackColor = false;
            this.btnThem1.Click += new System.EventHandler(this.btnThem1_Click);
            // 
            // btnGiam1
            // 
            this.btnGiam1.BackColor = System.Drawing.Color.Yellow;
            this.btnGiam1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGiam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiam1.Location = new System.Drawing.Point(553, 63);
            this.btnGiam1.Margin = new System.Windows.Forms.Padding(2);
            this.btnGiam1.Name = "btnGiam1";
            this.btnGiam1.Size = new System.Drawing.Size(30, 27);
            this.btnGiam1.TabIndex = 172;
            this.btnGiam1.Text = "-";
            this.btnGiam1.UseVisualStyleBackColor = false;
            this.btnGiam1.Click += new System.EventHandler(this.btnGiam1_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(1284, 7);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(75, 32);
            this.btnQuayLai.TabIndex = 174;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // ttThemSLNuoc
            // 
            this.ttThemSLNuoc.AutoPopDelay = 3000;
            this.ttThemSLNuoc.InitialDelay = 100;
            this.ttThemSLNuoc.ReshowDelay = 100;
            // 
            // ttGiamSLNuoc
            // 
            this.ttGiamSLNuoc.AutoPopDelay = 3000;
            this.ttGiamSLNuoc.InitialDelay = 100;
            this.ttGiamSLNuoc.ReshowDelay = 100;
            // 
            // imgBan
            // 
            this.imgBan.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgBan.ImageStream")));
            this.imgBan.TransparentColor = System.Drawing.Color.Transparent;
            this.imgBan.Images.SetKeyName(0, "ban.png");
            this.imgBan.Images.SetKeyName(1, "banko.png");
            // 
            // fBanNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 677);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnThem1);
            this.Controls.Add(this.btnGiam1);
            this.Controls.Add(this.btnMoBan);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.txtPhanCham);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKhuyenMai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTongCong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lstHoaDon);
            this.Controls.Add(this.lbTrangThai);
            this.Controls.Add(this.lbBan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbT);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.lstBanNuoc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnBotMon);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.dgvDanhSachNuocUong);
            this.Name = "fBanNuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bàn nước";
            this.Load += new System.EventHandler(this.fBanNuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNuocUong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lstHoaDon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.Label lbBan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbT;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.ListView lstBanNuoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnBotMon;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.DataGridView dgvDanhSachNuocUong;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.TextBox txtPhanCham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKhuyenMai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTongCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnMoBan;
        private System.Windows.Forms.Button btnThem1;
        private System.Windows.Forms.Button btnGiam1;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.ToolTip ttThemSLNuoc;
        private System.Windows.Forms.ToolTip ttGiamSLNuoc;
        private System.Windows.Forms.ImageList imgBan;
    }
}