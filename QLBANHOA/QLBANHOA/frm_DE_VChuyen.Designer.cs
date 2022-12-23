
namespace QLBANHOA
{
    partial class frm_DE_VChuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DE_VChuyen));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_DE_saveVC = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DE_delVC = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DE_cancelVC = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtgia = new DevExpress.XtraEditors.TextEdit();
            this.txttenkv = new DevExpress.XtraEditors.TextEdit();
            this.txtkhoangcach = new DevExpress.XtraEditors.TextEdit();
            this.txtmakv = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dgVanChuyen = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtgia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenkv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkhoangcach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmakv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVanChuyen)).BeginInit();
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
            this.btn_DE_saveVC,
            this.btn_DE_delVC,
            this.btn_DE_cancelVC});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_DE_saveVC),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_DE_delVC),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_DE_cancelVC)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btn_DE_saveVC
            // 
            this.btn_DE_saveVC.Caption = "Lưu";
            this.btn_DE_saveVC.Id = 0;
            this.btn_DE_saveVC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DE_saveVC.ImageOptions.Image")));
            this.btn_DE_saveVC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DE_saveVC.ImageOptions.LargeImage")));
            this.btn_DE_saveVC.Name = "btn_DE_saveVC";
            this.btn_DE_saveVC.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_DE_saveVC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DE_saveVC_ItemClick);
            // 
            // btn_DE_delVC
            // 
            this.btn_DE_delVC.Caption = "Xóa";
            this.btn_DE_delVC.Id = 1;
            this.btn_DE_delVC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DE_delVC.ImageOptions.Image")));
            this.btn_DE_delVC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DE_delVC.ImageOptions.LargeImage")));
            this.btn_DE_delVC.Name = "btn_DE_delVC";
            this.btn_DE_delVC.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_DE_delVC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DE_delVC_ItemClick);
            // 
            // btn_DE_cancelVC
            // 
            this.btn_DE_cancelVC.Caption = "Hủy";
            this.btn_DE_cancelVC.Id = 2;
            this.btn_DE_cancelVC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DE_cancelVC.ImageOptions.Image")));
            this.btn_DE_cancelVC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DE_cancelVC.ImageOptions.LargeImage")));
            this.btn_DE_cancelVC.Name = "btn_DE_cancelVC";
            this.btn_DE_cancelVC.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_DE_cancelVC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DE_cancelVC_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(818, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 425);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(818, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 401);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(818, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 401);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtgia);
            this.layoutControl1.Controls.Add(this.txttenkv);
            this.layoutControl1.Controls.Add(this.txtkhoangcach);
            this.layoutControl1.Controls.Add(this.txtmakv);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(818, 72);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(493, 36);
            this.txtgia.MenuManager = this.barManager1;
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(313, 20);
            this.txtgia.StyleController = this.layoutControl1;
            this.txtgia.TabIndex = 7;
            this.txtgia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgia_KeyPress);
            // 
            // txttenkv
            // 
            this.txttenkv.Location = new System.Drawing.Point(95, 36);
            this.txttenkv.MenuManager = this.barManager1;
            this.txttenkv.Name = "txttenkv";
            this.txttenkv.Size = new System.Drawing.Size(311, 20);
            this.txttenkv.StyleController = this.layoutControl1;
            this.txttenkv.TabIndex = 6;
            // 
            // txtkhoangcach
            // 
            this.txtkhoangcach.Location = new System.Drawing.Point(493, 12);
            this.txtkhoangcach.MenuManager = this.barManager1;
            this.txtkhoangcach.Name = "txtkhoangcach";
            this.txtkhoangcach.Size = new System.Drawing.Size(313, 20);
            this.txtkhoangcach.StyleController = this.layoutControl1;
            this.txtkhoangcach.TabIndex = 5;
            this.txtkhoangcach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtkhoangcach_KeyPress);
            // 
            // txtmakv
            // 
            this.txtmakv.Location = new System.Drawing.Point(95, 12);
            this.txtmakv.MenuManager = this.barManager1;
            this.txtmakv.Name = "txtmakv";
            this.txtmakv.Size = new System.Drawing.Size(311, 20);
            this.txtmakv.StyleController = this.layoutControl1;
            this.txtmakv.TabIndex = 4;
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
            this.Root.Size = new System.Drawing.Size(818, 72);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtmakv;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(398, 24);
            this.layoutControlItem1.Text = "Mã khu vực";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtkhoangcach;
            this.layoutControlItem2.Location = new System.Drawing.Point(398, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(400, 24);
            this.layoutControlItem2.Text = "Khoảng cách (m)";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txttenkv;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(398, 28);
            this.layoutControlItem3.Text = "Tên khu vực";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtgia;
            this.layoutControlItem4.Location = new System.Drawing.Point(398, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(400, 28);
            this.layoutControlItem4.Text = "Giá (VND)";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(80, 13);
            // 
            // dgVanChuyen
            // 
            this.dgVanChuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVanChuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgVanChuyen.Location = new System.Drawing.Point(0, 96);
            this.dgVanChuyen.Name = "dgVanChuyen";
            this.dgVanChuyen.Size = new System.Drawing.Size(818, 329);
            this.dgVanChuyen.TabIndex = 9;
            this.dgVanChuyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVanChuyen_CellClick);
            // 
            // frm_DE_VChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 425);
            this.Controls.Add(this.dgVanChuyen);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frm_DE_VChuyen.IconOptions.Image")));
            this.Name = "frm_DE_VChuyen";
            this.Text = "Phí vận chuyển";
            this.Load += new System.EventHandler(this.frm_DE_VChuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtgia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenkv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkhoangcach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmakv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVanChuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btn_DE_saveVC;
        private DevExpress.XtraBars.BarButtonItem btn_DE_delVC;
        private DevExpress.XtraBars.BarButtonItem btn_DE_cancelVC;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtgia;
        private DevExpress.XtraEditors.TextEdit txttenkv;
        private DevExpress.XtraEditors.TextEdit txtkhoangcach;
        private DevExpress.XtraEditors.TextEdit txtmakv;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.DataGridView dgVanChuyen;
    }
}