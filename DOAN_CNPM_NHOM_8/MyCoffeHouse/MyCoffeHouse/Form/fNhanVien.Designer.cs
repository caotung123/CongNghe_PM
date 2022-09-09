
namespace MyCoffeHouse
{
    partial class fNhanVien
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
            this.gpTTKH = new System.Windows.Forms.GroupBox();
            this.dtgvNV = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbcs = new System.Windows.Forms.ComboBox();
            this.rdbGTNu = new System.Windows.Forms.RadioButton();
            this.rdbGTNam = new System.Windows.Forms.RadioButton();
            this.dtpNS = new System.Windows.Forms.DateTimePicker();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtCV = new System.Windows.Forms.TextBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnReSet = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gpTTKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNV)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpTTKH
            // 
            this.gpTTKH.Controls.Add(this.dtgvNV);
            this.gpTTKH.Location = new System.Drawing.Point(2, 2);
            this.gpTTKH.Name = "gpTTKH";
            this.gpTTKH.Size = new System.Drawing.Size(580, 298);
            this.gpTTKH.TabIndex = 7;
            this.gpTTKH.TabStop = false;
            this.gpTTKH.Text = "Thông Tin Nhân Viên";
            // 
            // dtgvNV
            // 
            this.dtgvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvNV.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNV.Location = new System.Drawing.Point(0, 19);
            this.dtgvNV.Name = "dtgvNV";
            this.dtgvNV.ReadOnly = true;
            this.dtgvNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvNV.Size = new System.Drawing.Size(574, 273);
            this.dtgvNV.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(2, 306);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 43);
            this.panel2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(215, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lập thông tin chi tiết nhân viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbcs);
            this.panel1.Controls.Add(this.rdbGTNu);
            this.panel1.Controls.Add(this.rdbGTNam);
            this.panel1.Controls.Add(this.dtpNS);
            this.panel1.Controls.Add(this.txtDC);
            this.panel1.Controls.Add(this.txtCV);
            this.panel1.Controls.Add(this.txtDT);
            this.panel1.Controls.Add(this.txtCMND);
            this.panel1.Controls.Add(this.txtTenNV);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(2, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 218);
            this.panel1.TabIndex = 12;
            // 
            // cbcs
            // 
            this.cbcs.FormattingEnabled = true;
            this.cbcs.Location = new System.Drawing.Point(432, 157);
            this.cbcs.Name = "cbcs";
            this.cbcs.Size = new System.Drawing.Size(103, 21);
            this.cbcs.TabIndex = 26;
            // 
            // rdbGTNu
            // 
            this.rdbGTNu.AutoSize = true;
            this.rdbGTNu.Location = new System.Drawing.Point(255, 119);
            this.rdbGTNu.Name = "rdbGTNu";
            this.rdbGTNu.Size = new System.Drawing.Size(39, 17);
            this.rdbGTNu.TabIndex = 25;
            this.rdbGTNu.TabStop = true;
            this.rdbGTNu.Text = "Nữ";
            this.rdbGTNu.UseVisualStyleBackColor = true;
            // 
            // rdbGTNam
            // 
            this.rdbGTNam.AutoSize = true;
            this.rdbGTNam.Location = new System.Drawing.Point(150, 119);
            this.rdbGTNam.Name = "rdbGTNam";
            this.rdbGTNam.Size = new System.Drawing.Size(47, 17);
            this.rdbGTNam.TabIndex = 24;
            this.rdbGTNam.TabStop = true;
            this.rdbGTNam.Text = "Nam";
            this.rdbGTNam.UseVisualStyleBackColor = true;
            // 
            // dtpNS
            // 
            this.dtpNS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNS.Location = new System.Drawing.Point(156, 76);
            this.dtpNS.Name = "dtpNS";
            this.dtpNS.Size = new System.Drawing.Size(103, 20);
            this.dtpNS.TabIndex = 23;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(152, 157);
            this.txtDC.Multiline = true;
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(160, 49);
            this.txtDC.TabIndex = 21;
            // 
            // txtCV
            // 
            this.txtCV.Location = new System.Drawing.Point(432, 112);
            this.txtCV.Name = "txtCV";
            this.txtCV.Size = new System.Drawing.Size(160, 20);
            this.txtCV.TabIndex = 20;
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(432, 64);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(160, 20);
            this.txtDT.TabIndex = 19;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(432, 12);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(160, 20);
            this.txtCMND.TabIndex = 18;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(133, 40);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(160, 20);
            this.txtTenNV.TabIndex = 22;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(134, 9);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 20);
            this.txtMaNV.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ngày Sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Giới tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Địa chỉ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(366, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Cơ Sở:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(366, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Chức vụ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(366, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Điện thoại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "CMND:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên NV:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(85, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Mã NV:";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(588, 277);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(75, 23);
            this.btnQuayLai.TabIndex = 25;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnReSet
            // 
            this.btnReSet.Location = new System.Drawing.Point(588, 6);
            this.btnReSet.Name = "btnReSet";
            this.btnReSet.Size = new System.Drawing.Size(75, 38);
            this.btnReSet.TabIndex = 26;
            this.btnReSet.Text = "Reset";
            this.btnReSet.UseVisualStyleBackColor = true;
            this.btnReSet.Click += new System.EventHandler(this.btnReSet_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoa.Image = global::MyCoffeHouse.Properties.Resources.Delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(588, 105);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(61, 52);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSua.Image = global::MyCoffeHouse.Properties.Resources.Modify;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(588, 163);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(61, 53);
            this.btnSua.TabIndex = 9;
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThem.Image = global::MyCoffeHouse.Properties.Resources.Add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(588, 50);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(61, 49);
            this.btnThem.TabIndex = 10;
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExport.Image = global::MyCoffeHouse.Properties.Resources.Load;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(589, 222);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(60, 49);
            this.btnExport.TabIndex = 27;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(656, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Thêm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(657, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Xóa";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(657, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Sửa";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(657, 240);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Export";
            // 
            // fNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(699, 579);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnReSet);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gpTTKH);
            this.Name = "fNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.fNhanVien_Load);
            this.gpTTKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpTTKH;
        private System.Windows.Forms.DataGridView dtgvNV;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbcs;
        private System.Windows.Forms.RadioButton rdbGTNu;
        private System.Windows.Forms.RadioButton rdbGTNam;
        private System.Windows.Forms.DateTimePicker dtpNS;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtCV;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnReSet;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}