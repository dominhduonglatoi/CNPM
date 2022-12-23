
namespace QLBANHOA
{
    partial class frm_DE_KHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DE_KHang));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_DE_saveKH = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DE_delKH = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DE_cancelKH = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txt_DCKH = new DevExpress.XtraEditors.TextEdit();
            this.txt_DTKH = new DevExpress.XtraEditors.TextEdit();
            this.txt_TenKH = new DevExpress.XtraEditors.TextEdit();
            this.txt_MaKH = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dgKH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DCKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DTKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKH)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_DE_saveKH,
            this.btn_DE_delKH,
            this.btn_DE_cancelKH});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_DE_saveKH),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_DE_delKH),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_DE_cancelKH)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btn_DE_saveKH
            // 
            this.btn_DE_saveKH.Caption = "Lưu";
            this.btn_DE_saveKH.Id = 0;
            this.btn_DE_saveKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DE_saveKH.ImageOptions.Image")));
            this.btn_DE_saveKH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DE_saveKH.ImageOptions.LargeImage")));
            this.btn_DE_saveKH.Name = "btn_DE_saveKH";
            this.btn_DE_saveKH.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_DE_saveKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DE_saveKH_ItemClick);
            // 
            // btn_DE_delKH
            // 
            this.btn_DE_delKH.Caption = "Xóa";
            this.btn_DE_delKH.Id = 1;
            this.btn_DE_delKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DE_delKH.ImageOptions.Image")));
            this.btn_DE_delKH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DE_delKH.ImageOptions.LargeImage")));
            this.btn_DE_delKH.Name = "btn_DE_delKH";
            this.btn_DE_delKH.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_DE_delKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DE_delKH_ItemClick);
            // 
            // btn_DE_cancelKH
            // 
            this.btn_DE_cancelKH.Caption = "Hủy";
            this.btn_DE_cancelKH.Id = 3;
            this.btn_DE_cancelKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DE_cancelKH.ImageOptions.Image")));
            this.btn_DE_cancelKH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DE_cancelKH.ImageOptions.LargeImage")));
            this.btn_DE_cancelKH.Name = "btn_DE_cancelKH";
            this.btn_DE_cancelKH.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_DE_cancelKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DE_cancelKH_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(814, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 542);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(814, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 518);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(814, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 518);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txt_DCKH);
            this.layoutControl1.Controls.Add(this.txt_DTKH);
            this.layoutControl1.Controls.Add(this.txt_TenKH);
            this.layoutControl1.Controls.Add(this.txt_MaKH);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(814, 71);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txt_DCKH
            // 
            this.txt_DCKH.Location = new System.Drawing.Point(87, 36);
            this.txt_DCKH.MenuManager = this.barManager1;
            this.txt_DCKH.Name = "txt_DCKH";
            this.txt_DCKH.Size = new System.Drawing.Size(715, 20);
            this.txt_DCKH.StyleController = this.layoutControl1;
            this.txt_DCKH.TabIndex = 7;
            // 
            // txt_DTKH
            // 
            this.txt_DTKH.Location = new System.Drawing.Point(687, 12);
            this.txt_DTKH.MenuManager = this.barManager1;
            this.txt_DTKH.Name = "txt_DTKH";
            this.txt_DTKH.Size = new System.Drawing.Size(115, 20);
            this.txt_DTKH.StyleController = this.layoutControl1;
            this.txt_DTKH.TabIndex = 6;
            this.txt_DTKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DTKH_KeyPress);
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Location = new System.Drawing.Point(309, 12);
            this.txt_TenKH.MenuManager = this.barManager1;
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(299, 20);
            this.txt_TenKH.StyleController = this.layoutControl1;
            this.txt_TenKH.TabIndex = 5;
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Location = new System.Drawing.Point(87, 12);
            this.txt_MaKH.MenuManager = this.barManager1;
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(143, 20);
            this.txt_MaKH.StyleController = this.layoutControl1;
            this.txt_MaKH.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(814, 71);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txt_MaKH;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(222, 24);
            this.layoutControlItem1.Text = "Mã khách hàng";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txt_TenKH;
            this.layoutControlItem2.Location = new System.Drawing.Point(222, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(378, 24);
            this.layoutControlItem2.Text = "Họ tên";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txt_DTKH;
            this.layoutControlItem3.Location = new System.Drawing.Point(600, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(194, 24);
            this.layoutControlItem3.Text = "Số điện thoại";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txt_DCKH;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(794, 27);
            this.layoutControlItem4.Text = "Địa chỉ";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(72, 13);
            // 
            // dgKH
            // 
            this.dgKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgKH.Location = new System.Drawing.Point(0, 95);
            this.dgKH.Name = "dgKH";
            this.dgKH.Size = new System.Drawing.Size(814, 447);
            this.dgKH.TabIndex = 5;
            this.dgKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKH_CellClick);
            // 
            // frm_DE_KHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 542);
            this.Controls.Add(this.dgKH);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frm_DE_KHang.IconOptions.Image")));
            this.Name = "frm_DE_KHang";
            this.Text = "Danh sách khách hàng";
            this.Load += new System.EventHandler(this.frm_DE_KHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_DCKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DTKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btn_DE_saveKH;
        private DevExpress.XtraBars.BarButtonItem btn_DE_delKH;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txt_DTKH;
        private DevExpress.XtraEditors.TextEdit txt_TenKH;
        private DevExpress.XtraEditors.TextEdit txt_MaKH;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit txt_DCKH;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.DataGridView dgKH;
        private DevExpress.XtraBars.BarButtonItem btn_DE_cancelKH;
    }
}