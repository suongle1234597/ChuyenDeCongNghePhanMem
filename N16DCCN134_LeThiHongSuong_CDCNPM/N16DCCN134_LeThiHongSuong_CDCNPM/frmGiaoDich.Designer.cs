﻿namespace N16DCCN134_LeThiHongSuong_CDCNPM
{
    partial class frmGiaoDich
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
            this.txtSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.txtGia = new DevExpress.XtraEditors.SpinEdit();
            this.rbtBan = new System.Windows.Forms.RadioButton();
            this.rbtMua = new System.Windows.Forms.RadioButton();
            this.btnGD = new System.Windows.Forms.Button();
            this.cbbLoaiLenh = new System.Windows.Forms.ComboBox();
            this.txtMA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNgay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lENHDATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lENHDATBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoLuong.Location = new System.Drawing.Point(886, 238);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoLuong.Size = new System.Drawing.Size(243, 24);
            this.txtSoLuong.TabIndex = 61;
            // 
            // txtGia
            // 
            this.txtGia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtGia.Location = new System.Drawing.Point(886, 275);
            this.txtGia.Name = "txtGia";
            this.txtGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtGia.Size = new System.Drawing.Size(243, 24);
            this.txtGia.TabIndex = 60;
            // 
            // rbtBan
            // 
            this.rbtBan.AutoSize = true;
            this.rbtBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtBan.Location = new System.Drawing.Point(986, 328);
            this.rbtBan.Name = "rbtBan";
            this.rbtBan.Size = new System.Drawing.Size(89, 21);
            this.rbtBan.TabIndex = 59;
            this.rbtBan.TabStop = true;
            this.rbtBan.Text = "Lệnh bán";
            this.rbtBan.UseVisualStyleBackColor = true;
            // 
            // rbtMua
            // 
            this.rbtMua.AutoSize = true;
            this.rbtMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMua.Location = new System.Drawing.Point(837, 328);
            this.rbtMua.Name = "rbtMua";
            this.rbtMua.Size = new System.Drawing.Size(92, 21);
            this.rbtMua.TabIndex = 58;
            this.rbtMua.TabStop = true;
            this.rbtMua.Text = "Lệnh mua";
            this.rbtMua.UseVisualStyleBackColor = true;
            // 
            // btnGD
            // 
            this.btnGD.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGD.Location = new System.Drawing.Point(775, 379);
            this.btnGD.Name = "btnGD";
            this.btnGD.Size = new System.Drawing.Size(158, 38);
            this.btnGD.TabIndex = 57;
            this.btnGD.Text = "Giao Dịch";
            this.btnGD.UseVisualStyleBackColor = true;
            this.btnGD.Click += new System.EventHandler(this.btnGD_Click);
            // 
            // cbbLoaiLenh
            // 
            this.cbbLoaiLenh.FormattingEnabled = true;
            this.cbbLoaiLenh.Items.AddRange(new object[] {
            "Lệnh khớp liên tục (LO)"});
            this.cbbLoaiLenh.Location = new System.Drawing.Point(886, 192);
            this.cbbLoaiLenh.Name = "cbbLoaiLenh";
            this.cbbLoaiLenh.Size = new System.Drawing.Size(243, 24);
            this.cbbLoaiLenh.TabIndex = 56;
            // 
            // txtMA
            // 
            this.txtMA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMA.Location = new System.Drawing.Point(886, 153);
            this.txtMA.Name = "txtMA";
            this.txtMA.Size = new System.Drawing.Size(243, 22);
            this.txtMA.TabIndex = 55;
            this.txtMA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMA_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(772, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 54;
            this.label6.Text = "Mã CP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(772, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 53;
            this.label5.Text = "Loại lệnh :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(771, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 52;
            this.label4.Text = "Số lượng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(772, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(771, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 50;
            this.label3.Text = "Ngày đặt lệnh:";
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgay.Location = new System.Drawing.Point(896, 106);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(42, 18);
            this.lbNgay.TabIndex = 49;
            this.lbNgay.Text = "Ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(771, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "Bảng Lệnh Đặt";
            // 
            // lENHDATBindingSource
            // 
            this.lENHDATBindingSource.DataMember = "LENHDAT";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(956, 379);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(158, 38);
            this.btnThoat.TabIndex = 63;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 499);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.rbtBan);
            this.Controls.Add(this.rbtMua);
            this.Controls.Add(this.btnGD);
            this.Controls.Add(this.cbbLoaiLenh);
            this.Controls.Add(this.txtMA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbNgay);
            this.Controls.Add(this.label1);
            this.Name = "frmGiaoDich";
            this.Text = "Giao Dịch";
            this.Load += new System.EventHandler(this.frmGiaoDich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lENHDATBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit txtSoLuong;
        private System.Windows.Forms.BindingSource lENHDATBindingSource;
        private DevExpress.XtraEditors.SpinEdit txtGia;
        private System.Windows.Forms.RadioButton rbtBan;
        private System.Windows.Forms.RadioButton rbtMua;
        private System.Windows.Forms.Button btnGD;
        private System.Windows.Forms.ComboBox cbbLoaiLenh;
        private System.Windows.Forms.TextBox txtMA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
    }
}