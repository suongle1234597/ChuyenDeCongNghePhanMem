namespace N16DCCN134_LeThiHongSuong_CDCNPM
{
    partial class frmBangGiaTrucTuyen
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
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.DS1 = new N16DCCN134_LeThiHongSuong_CDCNPM.N16DCCN134_LeThiHongSuongDataSet();
            this.bdsBangGiaTrucTuyen = new System.Windows.Forms.BindingSource(this.components);
            this.bANGGIATRUCTUYENTableAdapter = new N16DCCN134_LeThiHongSuong_CDCNPM.N16DCCN134_LeThiHongSuongDataSetTableAdapters.BANGGIATRUCTUYENTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDatLenh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ColMACP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIADUMUA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KLDUMUA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIADUMUA2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KLDUMUA2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIAKHOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KLKHOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIADUBAN1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KLDUBAN1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIADUBAN2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KLDUBAN2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBangGiaTrucTuyen)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 16;
            this.ListBox1.Location = new System.Drawing.Point(126, 30);
            this.ListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(159, 84);
            this.ListBox1.TabIndex = 12;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1260, 86);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 28);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMACP,
            this.GIADUMUA1,
            this.KLDUMUA1,
            this.GIADUMUA2,
            this.KLDUMUA2,
            this.GIAKHOP,
            this.KLKHOP,
            this.GIADUBAN1,
            this.KLDUBAN1,
            this.GIADUBAN2,
            this.KLDUBAN2});
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(1430, 367);
            this.DataGridView1.TabIndex = 15;
            // 
            // DS1
            // 
            this.DS1.DataSetName = "N16DCCN134_LeThiHongSuongDataSet";
            this.DS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsBangGiaTrucTuyen
            // 
            this.bdsBangGiaTrucTuyen.DataMember = "BANGGIATRUCTUYEN";
            this.bdsBangGiaTrucTuyen.DataSource = this.DS1;
            // 
            // bANGGIATRUCTUYENTableAdapter
            // 
            this.bANGGIATRUCTUYENTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDatLenh);
            this.panel1.Controls.Add(this.ListBox1);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1430, 155);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 14;
            // 
            // btnDatLenh
            // 
            this.btnDatLenh.Location = new System.Drawing.Point(1260, 30);
            this.btnDatLenh.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatLenh.Name = "btnDatLenh";
            this.btnDatLenh.Size = new System.Drawing.Size(100, 28);
            this.btnDatLenh.TabIndex = 13;
            this.btnDatLenh.Text = "Đặt lệnh";
            this.btnDatLenh.UseVisualStyleBackColor = true;
            this.btnDatLenh.Click += new System.EventHandler(this.btnDatLenh_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1430, 367);
            this.panel2.TabIndex = 18;
            // 
            // ColMACP
            // 
            this.ColMACP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColMACP.DataPropertyName = "MACP";
            this.ColMACP.HeaderText = "MACP";
            this.ColMACP.Name = "ColMACP";
            // 
            // GIADUMUA1
            // 
            this.GIADUMUA1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GIADUMUA1.DataPropertyName = "GIADUMUA1";
            this.GIADUMUA1.HeaderText = "GIADUMUA1";
            this.GIADUMUA1.Name = "GIADUMUA1";
            // 
            // KLDUMUA1
            // 
            this.KLDUMUA1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KLDUMUA1.DataPropertyName = "KLDUMUA1";
            this.KLDUMUA1.HeaderText = "KLDUMUA1";
            this.KLDUMUA1.Name = "KLDUMUA1";
            // 
            // GIADUMUA2
            // 
            this.GIADUMUA2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GIADUMUA2.DataPropertyName = "GIADUMUA2";
            this.GIADUMUA2.HeaderText = "GIADUMUA2";
            this.GIADUMUA2.Name = "GIADUMUA2";
            // 
            // KLDUMUA2
            // 
            this.KLDUMUA2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KLDUMUA2.DataPropertyName = "KLDUMUA2";
            this.KLDUMUA2.HeaderText = "KLDUMUA2";
            this.KLDUMUA2.Name = "KLDUMUA2";
            // 
            // GIAKHOP
            // 
            this.GIAKHOP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GIAKHOP.DataPropertyName = "GIAKHOP";
            this.GIAKHOP.HeaderText = "GIAKHOP";
            this.GIAKHOP.Name = "GIAKHOP";
            // 
            // KLKHOP
            // 
            this.KLKHOP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KLKHOP.DataPropertyName = "KLKHOP";
            this.KLKHOP.HeaderText = "KLKHOP";
            this.KLKHOP.Name = "KLKHOP";
            // 
            // GIADUBAN1
            // 
            this.GIADUBAN1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GIADUBAN1.DataPropertyName = "GIADUBAN1";
            this.GIADUBAN1.HeaderText = "GIADUBAN1";
            this.GIADUBAN1.Name = "GIADUBAN1";
            // 
            // KLDUBAN1
            // 
            this.KLDUBAN1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KLDUBAN1.DataPropertyName = "KLDUBAN1";
            this.KLDUBAN1.HeaderText = "KLDUBAN1";
            this.KLDUBAN1.Name = "KLDUBAN1";
            // 
            // GIADUBAN2
            // 
            this.GIADUBAN2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GIADUBAN2.DataPropertyName = "GIADUBAN2";
            this.GIADUBAN2.HeaderText = "GIADUBAN2";
            this.GIADUBAN2.Name = "GIADUBAN2";
            // 
            // KLDUBAN2
            // 
            this.KLDUBAN2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KLDUBAN2.DataPropertyName = "KLDUBAN2";
            this.KLDUBAN2.HeaderText = "KLDUBAN2";
            this.KLDUBAN2.Name = "KLDUBAN2";
            // 
            // frmBangGiaTrucTuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 522);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBangGiaTrucTuyen";
            this.Text = "Bảng giá trực tuyến";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBangGiaTrucTuyen_FormClosed);
            this.Load += new System.EventHandler(this.frmBangGiaTrucTuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBangGiaTrucTuyen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.ListBox ListBox1;
        internal System.Windows.Forms.Button btnThoat;
        internal System.Windows.Forms.DataGridView DataGridView1;
        private N16DCCN134_LeThiHongSuongDataSet DS1;
        private System.Windows.Forms.BindingSource bdsBangGiaTrucTuyen;
        private N16DCCN134_LeThiHongSuongDataSetTableAdapters.BANGGIATRUCTUYENTableAdapter bANGGIATRUCTUYENTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Button btnDatLenh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMACP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIADUMUA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KLDUMUA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIADUMUA2;
        private System.Windows.Forms.DataGridViewTextBoxColumn KLDUMUA2;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIAKHOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn KLKHOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIADUBAN1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KLDUBAN1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIADUBAN2;
        private System.Windows.Forms.DataGridViewTextBoxColumn KLDUBAN2;
    }
}

