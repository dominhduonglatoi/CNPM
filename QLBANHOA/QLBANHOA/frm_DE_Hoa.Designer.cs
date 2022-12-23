
namespace QLBANHOA
{
    partial class frm_DE_Hoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DE_Hoa));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_DE_saveHoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DE_delHoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DE_cancelHoa = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txt_MauHoa = new DevExpress.XtraEditors.TextEdit();
            this.txt_GiaHoa = new DevExpress.XtraEditors.TextEdit();
            this.txt_TenHoa = new DevExpress.XtraEditors.TextEdit();
            this.txt_MaHoa = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dgHoa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MauHoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GiaHoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenHoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaHoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHoa)).BeginInit();
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
            this.btn_DE_delHoa,
            this.btn_DE_saveHoa,
            this.btn_DE_cancelHoa});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_DE_saveHoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_DE_delHoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_DE_cancelHoa)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btn_DE_saveHoa
            // 
            this.btn_DE_saveHoa.Caption = "Lưu";
            this.btn_DE_saveHoa.Id = 3;
            this.btn_DE_saveHoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DE_saveHoa.ImageOptions.Image")));
            this.btn_DE_saveHoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DE_saveHoa.ImageOptions.LargeImage")));
            this.btn_DE_saveHoa.Name = "btn_DE_saveHoa";
            this.btn_DE_saveHoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_DE_saveHoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DE_saveHoa_ItemClick);
            // 
            // btn_DE_delHoa
            // 
            this.btn_DE_delHoa.Caption = "Xóa";
            this.btn_DE_delHoa.Id = 1;
            this.btn_DE_delHoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DE_delHoa.ImageOptions.Image")));
            this.btn_DE_delHoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DE_delHoa.ImageOptions.LargeImage")));
            this.btn_DE_delHoa.Name = "btn_DE_delHoa";
            this.btn_DE_delHoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_DE_delHoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DE_delHoa_ItemClick);
            // 
            // btn_DE_cancelHoa
            // 
            this.btn_DE_cancelHoa.Caption = "Hủy";
            this.btn_DE_cancelHoa.Id = 4;
            this.btn_DE_cancelHoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DE_cancelHoa.ImageOptions.Image")));
            this.btn_DE_cancelHoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DE_cancelHoa.ImageOptions.LargeImage")));
            this.btn_DE_cancelHoa.Name = "btn_DE_cancelHoa";
            this.btn_DE_cancelHoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_DE_cancelHoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DE_cancelHoa_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(710, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 397);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(710, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 373);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(710, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 373);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txt_MauHoa);
            this.layoutControl1.Controls.Add(this.txt_GiaHoa);
            this.layoutControl1.Controls.Add(this.txt_TenHoa);
            this.layoutControl1.Controls.Add(this.txt_MaHoa);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(710, 68);
            this.layoutControl1.TabIndex = 6;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txt_MauHoa
            // 
            this.txt_MauHoa.Location = new System.Drawing.Point(370, 36);
            this.txt_MauHoa.MenuManager = this.barManager1;
            this.txt_MauHoa.Name = "txt_MauHoa";
            this.txt_MauHoa.Size = new System.Drawing.Size(328, 20);
            this.txt_MauHoa.StyleController = this.layoutControl1;
            this.txt_MauHoa.TabIndex = 7;
            // 
            // txt_GiaHoa
            // 
            this.txt_GiaHoa.Location = new System.Drawing.Point(54, 36);
            this.txt_GiaHoa.MenuManager = this.barManager1;
            this.txt_GiaHoa.Name = "txt_GiaHoa";
            this.txt_GiaHoa.Size = new System.Drawing.Size(270, 20);
            this.txt_GiaHoa.StyleController = this.layoutControl1;
            this.txt_GiaHoa.TabIndex = 6;
            this.txt_GiaHoa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_GiaHoa_KeyPress);
            // 
            // txt_TenHoa
            // 
            this.txt_TenHoa.Location = new System.Drawing.Point(370, 12);
            this.txt_TenHoa.MenuManager = this.barManager1;
            this.txt_TenHoa.Name = "txt_TenHoa";
            this.txt_TenHoa.Size = new System.Drawing.Size(328, 20);
            this.txt_TenHoa.StyleController = this.layoutControl1;
            this.txt_TenHoa.TabIndex = 5;
            // 
            // txt_MaHoa
            // 
            this.txt_MaHoa.Location = new System.Drawing.Point(54, 12);
            this.txt_MaHoa.MenuManager = this.barManager1;
            this.txt_MaHoa.Name = "txt_MaHoa";
            this.txt_MaHoa.Size = new System.Drawing.Size(270, 20);
            this.txt_MaHoa.StyleController = this.layoutControl1;
            this.txt_MaHoa.TabIndex = 4;
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
            this.Root.Size = new System.Drawing.Size(710, 68);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txt_MaHoa;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(316, 24);
            this.layoutControlItem1.Text = "Mã hoa";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(39, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txt_TenHoa;
            this.layoutControlItem2.Location = new System.Drawing.Point(316, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(374, 24);
            this.layoutControlItem2.Text = "Tên hoa";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(39, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txt_GiaHoa;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(316, 24);
            this.layoutControlItem3.Text = "Giá";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(39, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txt_MauHoa;
            this.layoutControlItem4.Location = new System.Drawing.Point(316, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(374, 24);
            this.layoutControlItem4.Text = "Màu sắc";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(39, 13);
            // 
            // dgHoa
            // 
            this.dgHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgHoa.Location = new System.Drawing.Point(0, 92);
            this.dgHoa.Name = "dgHoa";
            this.dgHoa.Size = new System.Drawing.Size(710, 305);
            this.dgHoa.TabIndex = 11;
            this.dgHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHoa_CellClick);
            // 
            // frm_DE_Hoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 397);
            this.Controls.Add(this.dgHoa);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frm_DE_Hoa.IconOptions.Image")));
            this.Name = "frm_DE_Hoa";
            this.Text = "Danh mục hoa";
            this.Load += new System.EventHandler(this.frm_DE_Hoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_MauHoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GiaHoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenHoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaHoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btn_DE_delHoa;
        private DevExpress.XtraBars.BarButtonItem btn_DE_saveHoa;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txt_MauHoa;
        private DevExpress.XtraEditors.TextEdit txt_GiaHoa;
        private DevExpress.XtraEditors.TextEdit txt_TenHoa;
        private DevExpress.XtraEditors.TextEdit txt_MaHoa;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.DataGridView dgHoa;
        private DevExpress.XtraBars.BarButtonItem btn_DE_cancelHoa;
    }
}