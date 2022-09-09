
namespace MyCoffeHouse
{
    partial class fLoaiThe
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReSet = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.txtTenthe = new System.Windows.Forms.TextBox();
            this.txtMathe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpTTKH = new System.Windows.Forms.GroupBox();
            this.dtgvLoaithe = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gpTTKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaithe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(926, 43);
            this.panel2.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(379, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Danh mục loại thẻ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnReSet);
            this.panel1.Controls.Add(this.btnQuayLai);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtGhichu);
            this.panel1.Controls.Add(this.txtTenthe);
            this.panel1.Controls.Add(this.txtMathe);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(471, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 203);
            this.panel1.TabIndex = 19;
            // 
            // btnReSet
            // 
            this.btnReSet.Location = new System.Drawing.Point(53, 161);
            this.btnReSet.Name = "btnReSet";
            this.btnReSet.Size = new System.Drawing.Size(75, 38);
            this.btnReSet.TabIndex = 26;
            this.btnReSet.Text = "Reset";
            this.btnReSet.UseVisualStyleBackColor = true;
            this.btnReSet.Click += new System.EventHandler(this.btnReSet_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(382, 174);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(75, 23);
            this.btnQuayLai.TabIndex = 8;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoa.Image = global::MyCoffeHouse.Properties.Resources.Delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(198, 147);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(56, 53);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSua.Image = global::MyCoffeHouse.Properties.Resources.Modify;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(260, 147);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(53, 53);
            this.btnSua.TabIndex = 4;
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThem.Image = global::MyCoffeHouse.Properties.Resources.Add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(134, 147);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(58, 52);
            this.btnThem.TabIndex = 4;
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(72, 87);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(385, 26);
            this.txtGhichu.TabIndex = 1;
            // 
            // txtTenthe
            // 
            this.txtTenthe.Location = new System.Drawing.Point(72, 47);
            this.txtTenthe.Name = "txtTenthe";
            this.txtTenthe.Size = new System.Drawing.Size(147, 20);
            this.txtTenthe.TabIndex = 1;
            // 
            // txtMathe
            // 
            this.txtMathe.Location = new System.Drawing.Point(72, 8);
            this.txtMathe.Name = "txtMathe";
            this.txtMathe.Size = new System.Drawing.Size(100, 20);
            this.txtMathe.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ghi Chú:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên thẻ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thẻ:";
            // 
            // gpTTKH
            // 
            this.gpTTKH.Controls.Add(this.dtgvLoaithe);
            this.gpTTKH.Location = new System.Drawing.Point(3, 51);
            this.gpTTKH.Name = "gpTTKH";
            this.gpTTKH.Size = new System.Drawing.Size(462, 203);
            this.gpTTKH.TabIndex = 18;
            this.gpTTKH.TabStop = false;
            this.gpTTKH.Text = "Thông Tin Loại Thẻ";
            // 
            // dtgvLoaithe
            // 
            this.dtgvLoaithe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvLoaithe.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgvLoaithe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLoaithe.Location = new System.Drawing.Point(0, 19);
            this.dtgvLoaithe.Name = "dtgvLoaithe";
            this.dtgvLoaithe.ReadOnly = true;
            this.dtgvLoaithe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLoaithe.Size = new System.Drawing.Size(460, 178);
            this.dtgvLoaithe.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExport.Image = global::MyCoffeHouse.Properties.Resources.Load;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(319, 147);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(57, 53);
            this.btnExport.TabIndex = 30;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(321, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Export";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(268, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Sửa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(209, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Xóa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(149, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Thêm";
            // 
            // fLoaiThe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 255);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gpTTKH);
            this.Name = "fLoaiThe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý loại thẻ của Khách";
            this.Load += new System.EventHandler(this.fLoaiThe_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpTTKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaithe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.TextBox txtTenthe;
        private System.Windows.Forms.TextBox txtMathe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpTTKH;
        private System.Windows.Forms.DataGridView dtgvLoaithe;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnReSet;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}