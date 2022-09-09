
namespace MyCoffeHouse
{
    partial class fThongKe
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
            this.txtSheet = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnTK = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.dtgvShow = new System.Windows.Forms.DataGridView();
            this.btnQuayLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSheet
            // 
            this.txtSheet.Location = new System.Drawing.Point(147, 57);
            this.txtSheet.Name = "txtSheet";
            this.txtSheet.Size = new System.Drawing.Size(281, 20);
            this.txtSheet.TabIndex = 9;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(147, 21);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(281, 20);
            this.txtPath.TabIndex = 10;
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTK.Location = new System.Drawing.Point(49, 48);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(80, 30);
            this.btnTK.TabIndex = 7;
            this.btnTK.Text = "Thống Kê";
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnChoose.Location = new System.Drawing.Point(49, 12);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(80, 30);
            this.btnChoose.TabIndex = 8;
            this.btnChoose.Text = "Chọn file";
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // dtgvShow
            // 
            this.dtgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvShow.Location = new System.Drawing.Point(7, 106);
            this.dtgvShow.Name = "dtgvShow";
            this.dtgvShow.Size = new System.Drawing.Size(586, 317);
            this.dtgvShow.TabIndex = 6;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(516, 77);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(75, 23);
            this.btnQuayLai.TabIndex = 26;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // fThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(603, 433);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.txtSheet);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.dtgvShow);
            this.Name = "fThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSheet;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.DataGridView dtgvShow;
        private System.Windows.Forms.Button btnQuayLai;
    }
}