
namespace QLBANHOA
{
    partial class frm_DE_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DE_Main));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_DM_Hoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DM_KHang = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DM_VChuyen = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DM_PGiao = new DevExpress.XtraBars.BarButtonItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.btn_ReportPG = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btn_DM_Hoa,
            this.btn_DM_KHang,
            this.btn_DM_VChuyen,
            this.btn_DM_PGiao,
            this.barHeaderItem1,
            this.btn_ReportPG});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.Size = new System.Drawing.Size(815, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btn_DM_Hoa
            // 
            this.btn_DM_Hoa.Caption = "Hoa";
            this.btn_DM_Hoa.Id = 1;
            this.btn_DM_Hoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DM_Hoa.ImageOptions.Image")));
            this.btn_DM_Hoa.Name = "btn_DM_Hoa";
            this.btn_DM_Hoa.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btn_DM_Hoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DM_Hoa_ItemClick);
            // 
            // btn_DM_KHang
            // 
            this.btn_DM_KHang.Caption = "Khách hàng";
            this.btn_DM_KHang.Id = 2;
            this.btn_DM_KHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DM_KHang.ImageOptions.Image")));
            this.btn_DM_KHang.Name = "btn_DM_KHang";
            this.btn_DM_KHang.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btn_DM_KHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DM_KHang_ItemClick);
            // 
            // btn_DM_VChuyen
            // 
            this.btn_DM_VChuyen.Caption = "Phí vận chuyển";
            this.btn_DM_VChuyen.Id = 3;
            this.btn_DM_VChuyen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DM_VChuyen.ImageOptions.Image")));
            this.btn_DM_VChuyen.Name = "btn_DM_VChuyen";
            this.btn_DM_VChuyen.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btn_DM_VChuyen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DM_VChuyen_ItemClick);
            // 
            // btn_DM_PGiao
            // 
            this.btn_DM_PGiao.Caption = "Phiếu giao hàng";
            this.btn_DM_PGiao.Id = 4;
            this.btn_DM_PGiao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DM_PGiao.ImageOptions.Image")));
            this.btn_DM_PGiao.Name = "btn_DM_PGiao";
            this.btn_DM_PGiao.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btn_DM_PGiao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DM_PGiao_ItemClick);
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "Trịnh Tú Quyên 51800475 - Đỗ Minh Đường 51900703";
            this.barHeaderItem1.Id = 5;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Danh mục";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_DM_Hoa);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_DM_KHang);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_DM_VChuyen);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_DM_PGiao);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Danh mục lưu trữ";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "In";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_ReportPG);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Báo cáo";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barHeaderItem1);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 719);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(815, 24);
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // btn_ReportPG
            // 
            this.btn_ReportPG.Caption = "Phiếu giao";
            this.btn_ReportPG.Id = 6;
            this.btn_ReportPG.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ReportPG.ImageOptions.Image")));
            this.btn_ReportPG.Name = "btn_ReportPG";
            this.btn_ReportPG.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // frm_DE_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 743);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frm_DE_Main.IconOptions.Image")));
            this.IsMdiContainer = true;
            this.Name = "frm_DE_Main";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "2D.Flower Shop - Quản lý cửa hàng";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btn_DM_Hoa;
        private DevExpress.XtraBars.BarButtonItem btn_DM_KHang;
        private DevExpress.XtraBars.BarButtonItem btn_DM_VChuyen;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem btn_DM_PGiao;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarButtonItem btn_ReportPG;
    }
}