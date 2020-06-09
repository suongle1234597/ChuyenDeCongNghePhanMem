namespace N16DCCN134_LeThiHongSuong_CDCNPM
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnGiaoDich = new DevExpress.XtraBars.BarButtonItem();
            this.btnLenhBan = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangGiaTT = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangGiaTrucTuyen = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnGiaoDich,
            this.btnLenhBan,
            this.btnBangGiaTT,
            this.btnBangGiaTrucTuyen});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1026, 183);
            // 
            // btnGiaoDich
            // 
            this.btnGiaoDich.Caption = "Giao Dịch";
            this.btnGiaoDich.Id = 1;
            this.btnGiaoDich.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiaoDich.ImageOptions.Image")));
            this.btnGiaoDich.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGiaoDich.ImageOptions.LargeImage")));
            this.btnGiaoDich.Name = "btnGiaoDich";
            this.btnGiaoDich.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiaoDich_ItemClick);
            // 
            // btnLenhBan
            // 
            this.btnLenhBan.Caption = "Lệnh bán";
            this.btnLenhBan.Id = 2;
            this.btnLenhBan.Name = "btnLenhBan";
            // 
            // btnBangGiaTT
            // 
            this.btnBangGiaTT.Caption = "Bảng giá trực tuyến";
            this.btnBangGiaTT.Id = 3;
            this.btnBangGiaTT.Name = "btnBangGiaTT";
            // 
            // btnBangGiaTrucTuyen
            // 
            this.btnBangGiaTrucTuyen.Caption = "Bảng Giá Trực Tuyến";
            this.btnBangGiaTrucTuyen.Id = 4;
            this.btnBangGiaTrucTuyen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBangGiaTrucTuyen.ImageOptions.Image")));
            this.btnBangGiaTrucTuyen.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBangGiaTrucTuyen.ImageOptions.LargeImage")));
            this.btnBangGiaTrucTuyen.Name = "btnBangGiaTrucTuyen";
            this.btnBangGiaTrucTuyen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBangGiaTrucTuyen_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Chứng khoán";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGiaoDich);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnBangGiaTrucTuyen);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 507);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem btnGiaoDich;
        private DevExpress.XtraBars.BarButtonItem btnLenhBan;
        private DevExpress.XtraBars.BarButtonItem btnBangGiaTT;
        private DevExpress.XtraBars.BarButtonItem btnBangGiaTrucTuyen;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}