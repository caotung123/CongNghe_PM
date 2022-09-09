
namespace MyCoffeHouse
{
    partial class fCoSo
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
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtTenCS = new System.Windows.Forms.TextBox();
            this.txtMaCS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpTTKH = new System.Windows.Forms.GroupBox();
            this.dtgvCoSo = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gpTTKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCoSo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 43);
            this.panel2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(146, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Danh mục cơ sở";
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
            this.panel1.Controls.Add(this.txtDC);
            this.panel1.Controls.Add(this.txtTenCS);
            this.panel1.Controls.Add(this.txtMaCS);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 185);
            this.panel1.TabIndex = 13;
            // 
            // btnReSet
            // 
            this.btnReSet.Location = new System.Drawing.Point(48, 142);
            this.btnReSet.Name = "btnReSet";
            this.btnReSet.Size = new System.Drawing.Size(75, 38);
            this.btnReSet.TabIndex = 26;
            this.btnReSet.Text = "Reset";
            this.btnReSet.UseVisualStyleBackColor = true;
            this.btnReSet.Click += new System.EventHandler(this.btnReSet_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(385, 160);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(75, 23);
            this.btnQuayLai.TabIndex = 5;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoa.Image = global::MyCoffeHouse.Properties.Resources.Delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(194, 129);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(57, 51);
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
            this.btnSua.Location = new System.Drawing.Point(257, 129);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(59, 53);
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
            this.btnThem.Location = new System.Drawing.Point(129, 129);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(59, 53);
            this.btnThem.TabIndex = 4;
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(300, 5);
            this.txtDC.Multiline = true;
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(160, 43);
            this.txtDC.TabIndex = 1;
            // 
            // txtTenCS
            // 
            this.txtTenCS.Location = new System.Drawing.Point(72, 76);
            this.txtTenCS.Name = "txtTenCS";
            this.txtTenCS.Size = new System.Drawing.Size(147, 20);
            this.txtTenCS.TabIndex = 1;
            // 
            // txtMaCS
            // 
            this.txtMaCS.Location = new System.Drawing.Point(72, 8);
            this.txtMaCS.Name = "txtMaCS";
            this.txtMaCS.Size = new System.Drawing.Size(100, 20);
            this.txtMaCS.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên cơ sở:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã cơ sở:";
            // 
            // gpTTKH
            // 
            this.gpTTKH.Controls.Add(this.dtgvCoSo);
            this.gpTTKH.Location = new System.Drawing.Point(2, 241);
            this.gpTTKH.Name = "gpTTKH";
            this.gpTTKH.Size = new System.Drawing.Size(462, 251);
            this.gpTTKH.TabIndex = 12;
            this.gpTTKH.TabStop = false;
            this.gpTTKH.Text = "Thông Tin Cơ Sở";
            // 
            // dtgvCoSo
            // 
            this.dtgvCoSo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCoSo.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgvCoSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCoSo.Location = new System.Drawing.Point(0, 19);
            this.dtgvCoSo.Name = "dtgvCoSo";
            this.dtgvCoSo.ReadOnly = true;
            this.dtgvCoSo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCoSo.Size = new System.Drawing.Size(460, 224);
            this.dtgvCoSo.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExport.Image = global::MyCoffeHouse.Properties.Resources.Load;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(322, 129);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(57, 53);
            this.btnExport.TabIndex = 33;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(326, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Export";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(267, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Sửa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(208, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Xóa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(138, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Thêm";
            // 
            // fCoSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(468, 493);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gpTTKH);
            this.Name = "fCoSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý các cơ sở";
            this.Load += new System.EventHandler(this.fCoSo_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpTTKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCoSo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtTenCS;
        private System.Windows.Forms.TextBox txtMaCS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpTTKH;
        private System.Windows.Forms.DataGridView dtgvCoSo;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnReSet;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}