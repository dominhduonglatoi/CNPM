
namespace QLBANHOA
{
    partial class frm_phieuhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_phieuhang));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGioGiao = new System.Windows.Forms.DateTimePicker();
            this.txt_NgayGiao = new System.Windows.Forms.DateTimePicker();
            this.cboMaKhuVuc = new System.Windows.Forms.ComboBox();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.cboMaHoa = new System.Windows.Forms.ComboBox();
            this.radChuGiao = new System.Windows.Forms.RadioButton();
            this.radGiao = new System.Windows.Forms.RadioButton();
            this.txtDiaChiNguoiNhan = new System.Windows.Forms.TextBox();
            this.txtTenNN = new System.Windows.Forms.TextBox();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dg_phieuhang = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_save = new System.Windows.Forms.ToolStripButton();
            this.delPhieuHang = new System.Windows.Forms.ToolStripButton();
            this.cancelPhieuHang = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_phieuhang)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(312, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU ĐẶT HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.txtGioGiao);
            this.groupBox1.Controls.Add(this.txt_NgayGiao);
            this.groupBox1.Controls.Add(this.cboMaKhuVuc);
            this.groupBox1.Controls.Add(this.cboKhachHang);
            this.groupBox1.Controls.Add(this.cboMaHoa);
            this.groupBox1.Controls.Add(this.radChuGiao);
            this.groupBox1.Controls.Add(this.radGiao);
            this.groupBox1.Controls.Add(this.txtDiaChiNguoiNhan);
            this.groupBox1.Controls.Add(this.txtTenNN);
            this.groupBox1.Controls.Add(this.txtSoPhieu);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(75, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu đặt hàng";
            // 
            // txtGioGiao
            // 
            this.txtGioGiao.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtGioGiao.Location = new System.Drawing.Point(529, 95);
            this.txtGioGiao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGioGiao.Name = "txtGioGiao";
            this.txtGioGiao.Size = new System.Drawing.Size(116, 22);
            this.txtGioGiao.TabIndex = 18;
            // 
            // txt_NgayGiao
            // 
            this.txt_NgayGiao.CustomFormat = "HH:mm";
            this.txt_NgayGiao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_NgayGiao.Location = new System.Drawing.Point(529, 62);
            this.txt_NgayGiao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_NgayGiao.Name = "txt_NgayGiao";
            this.txt_NgayGiao.Size = new System.Drawing.Size(116, 22);
            this.txt_NgayGiao.TabIndex = 17;
            // 
            // cboMaKhuVuc
            // 
            this.cboMaKhuVuc.FormattingEnabled = true;
            this.cboMaKhuVuc.Location = new System.Drawing.Point(529, 32);
            this.cboMaKhuVuc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMaKhuVuc.Name = "cboMaKhuVuc";
            this.cboMaKhuVuc.Size = new System.Drawing.Size(116, 24);
            this.cboMaKhuVuc.TabIndex = 16;
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(140, 86);
            this.cboKhachHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(260, 24);
            this.cboKhachHang.TabIndex = 15;
            // 
            // cboMaHoa
            // 
            this.cboMaHoa.FormattingEnabled = true;
            this.cboMaHoa.Location = new System.Drawing.Point(140, 59);
            this.cboMaHoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMaHoa.Name = "cboMaHoa";
            this.cboMaHoa.Size = new System.Drawing.Size(260, 24);
            this.cboMaHoa.TabIndex = 14;
            // 
            // radChuGiao
            // 
            this.radChuGiao.AutoSize = true;
            this.radChuGiao.Location = new System.Drawing.Point(529, 150);
            this.radChuGiao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radChuGiao.Name = "radChuGiao";
            this.radChuGiao.Size = new System.Drawing.Size(125, 20);
            this.radChuGiao.TabIndex = 13;
            this.radChuGiao.TabStop = true;
            this.radChuGiao.Text = "Chưa Giao Hàng";
            this.radChuGiao.UseVisualStyleBackColor = true;
            // 
            // radGiao
            // 
            this.radGiao.AutoSize = true;
            this.radGiao.Location = new System.Drawing.Point(529, 127);
            this.radGiao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radGiao.Name = "radGiao";
            this.radGiao.Size = new System.Drawing.Size(111, 20);
            this.radGiao.TabIndex = 12;
            this.radGiao.TabStop = true;
            this.radGiao.Text = "Đã Giao Hàng";
            this.radGiao.UseVisualStyleBackColor = true;
            // 
            // txtDiaChiNguoiNhan
            // 
            this.txtDiaChiNguoiNhan.Location = new System.Drawing.Point(140, 136);
            this.txtDiaChiNguoiNhan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiaChiNguoiNhan.Name = "txtDiaChiNguoiNhan";
            this.txtDiaChiNguoiNhan.Size = new System.Drawing.Size(260, 22);
            this.txtDiaChiNguoiNhan.TabIndex = 11;
            // 
            // txtTenNN
            // 
            this.txtTenNN.Location = new System.Drawing.Point(140, 110);
            this.txtTenNN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenNN.Name = "txtTenNN";
            this.txtTenNN.Size = new System.Drawing.Size(260, 22);
            this.txtTenNN.TabIndex = 10;
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(140, 32);
            this.txtSoPhieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(260, 22);
            this.txtSoPhieu.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(424, 141);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Tình Trạng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(424, 101);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Giờ Giao";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(424, 68);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ngày Giao";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(424, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mã Khu Vực";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Địa Chỉ Người Nhận";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Họ Tên Người Nhận";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Hoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số Phiếu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dg_phieuhang);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(823, 203);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phiếu đặt hàng";
            // 
            // dg_phieuhang
            // 
            this.dg_phieuhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_phieuhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_phieuhang.Location = new System.Drawing.Point(3, 16);
            this.dg_phieuhang.Name = "dg_phieuhang";
            this.dg_phieuhang.RowHeadersWidth = 51;
            this.dg_phieuhang.Size = new System.Drawing.Size(817, 184);
            this.dg_phieuhang.TabIndex = 0;
            this.dg_phieuhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_phieuhang_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_save,
            this.delPhieuHang,
            this.cancelPhieuHang});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(823, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_save
            // 
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(55, 24);
            this.btn_save.Text = "Save";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // delPhieuHang
            // 
            this.delPhieuHang.Image = ((System.Drawing.Image)(resources.GetObject("delPhieuHang.Image")));
            this.delPhieuHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delPhieuHang.Name = "delPhieuHang";
            this.delPhieuHang.Size = new System.Drawing.Size(64, 24);
            this.delPhieuHang.Text = "Delete";
            this.delPhieuHang.Click += new System.EventHandler(this.delPhieuHang_Click);
            // 
            // cancelPhieuHang
            // 
            this.cancelPhieuHang.Image = ((System.Drawing.Image)(resources.GetObject("cancelPhieuHang.Image")));
            this.cancelPhieuHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelPhieuHang.Name = "cancelPhieuHang";
            this.cancelPhieuHang.Size = new System.Drawing.Size(67, 24);
            this.cancelPhieuHang.Text = "Cancel";
            this.cancelPhieuHang.Click += new System.EventHandler(this.cancelPhieuHang_Click);
            // 
            // frm_phieuhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_phieuhang";
            this.Text = "Phiếu hàng";
            this.Load += new System.EventHandler(this.frm_phieuhang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_phieuhang)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dg_phieuhang;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenNN;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.DateTimePicker txt_NgayGiao;
        private System.Windows.Forms.ComboBox cboMaKhuVuc;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.ComboBox cboMaHoa;
        private System.Windows.Forms.RadioButton radChuGiao;
        private System.Windows.Forms.RadioButton radGiao;
        private System.Windows.Forms.TextBox txtDiaChiNguoiNhan;
        private System.Windows.Forms.DateTimePicker txtGioGiao;
        private System.Windows.Forms.ToolStripButton delPhieuHang;
        private System.Windows.Forms.ToolStripButton cancelPhieuHang;
    }
}