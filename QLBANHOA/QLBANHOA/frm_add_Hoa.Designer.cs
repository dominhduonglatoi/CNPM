
namespace QLBANHOA
{
    partial class frm_add_Hoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add_Hoa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaHoa = new System.Windows.Forms.TextBox();
            this.txtTenHoa = new System.Windows.Forms.TextBox();
            this.txtMau = new System.Windows.Forms.TextBox();
            this.txtGiaHoa = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.add_Hoa = new System.Windows.Forms.ToolStripButton();
            this.delHoa = new System.Windows.Forms.ToolStripButton();
            this.cancelHoa = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgHoa = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHoa)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên hoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Màu sắc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá";
            // 
            // txtMaHoa
            // 
            this.txtMaHoa.Location = new System.Drawing.Point(163, 39);
            this.txtMaHoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaHoa.Name = "txtMaHoa";
            this.txtMaHoa.Size = new System.Drawing.Size(279, 22);
            this.txtMaHoa.TabIndex = 5;
            // 
            // txtTenHoa
            // 
            this.txtTenHoa.Location = new System.Drawing.Point(163, 76);
            this.txtTenHoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenHoa.Name = "txtTenHoa";
            this.txtTenHoa.Size = new System.Drawing.Size(279, 22);
            this.txtTenHoa.TabIndex = 6;
            // 
            // txtMau
            // 
            this.txtMau.Location = new System.Drawing.Point(163, 121);
            this.txtMau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMau.Name = "txtMau";
            this.txtMau.Size = new System.Drawing.Size(147, 22);
            this.txtMau.TabIndex = 7;
            // 
            // txtGiaHoa
            // 
            this.txtGiaHoa.Location = new System.Drawing.Point(163, 159);
            this.txtGiaHoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGiaHoa.Name = "txtGiaHoa";
            this.txtGiaHoa.Size = new System.Drawing.Size(147, 22);
            this.txtGiaHoa.TabIndex = 8;
            this.txtGiaHoa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaHoa_KeyPress);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_Hoa,
            this.delHoa,
            this.cancelHoa});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(712, 27);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // add_Hoa
            // 
            this.add_Hoa.Image = ((System.Drawing.Image)(resources.GetObject("add_Hoa.Image")));
            this.add_Hoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add_Hoa.Name = "add_Hoa";
            this.add_Hoa.Size = new System.Drawing.Size(64, 24);
            this.add_Hoa.Text = "Save";
            this.add_Hoa.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // delHoa
            // 
            this.delHoa.Image = ((System.Drawing.Image)(resources.GetObject("delHoa.Image")));
            this.delHoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delHoa.Name = "delHoa";
            this.delHoa.Size = new System.Drawing.Size(77, 24);
            this.delHoa.Text = "Delete";
            this.delHoa.Click += new System.EventHandler(this.delHoa_Click);
            // 
            // cancelHoa
            // 
            this.cancelHoa.Image = ((System.Drawing.Image)(resources.GetObject("cancelHoa.Image")));
            this.cancelHoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelHoa.Name = "cancelHoa";
            this.cancelHoa.Size = new System.Drawing.Size(77, 24);
            this.cancelHoa.Text = "Cancel";
            this.cancelHoa.Click += new System.EventHandler(this.cancelHoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgHoa);
            this.groupBox1.Location = new System.Drawing.Point(101, 322);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(501, 190);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Mục Hoa";
            // 
            // dgHoa
            // 
            this.dgHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgHoa.Location = new System.Drawing.Point(3, 17);
            this.dgHoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgHoa.Name = "dgHoa";
            this.dgHoa.RowHeadersWidth = 51;
            this.dgHoa.Size = new System.Drawing.Size(495, 171);
            this.dgHoa.TabIndex = 1;
            this.dgHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHoa_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(275, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 36);
            this.label6.TabIndex = 12;
            this.label6.Text = "THÊM HOA";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtGiaHoa);
            this.groupBox2.Controls.Add(this.txtMaHoa);
            this.groupBox2.Controls.Add(this.txtMau);
            this.groupBox2.Controls.Add(this.txtTenHoa);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(119, 96);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(464, 194);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin loại hoa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Đơn vị (VNĐ)";
            // 
            // frm_add_Hoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_add_Hoa";
            this.Text = "Danh Mục Hoa";
            this.Load += new System.EventHandler(this.frm_add_Hoa_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgHoa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaHoa;
        private System.Windows.Forms.TextBox txtTenHoa;
        private System.Windows.Forms.TextBox txtMau;
        private System.Windows.Forms.TextBox txtGiaHoa;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton add_Hoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgHoa;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ToolStripButton delHoa;
        private System.Windows.Forms.ToolStripButton cancelHoa;
        private System.Windows.Forms.Label label7;
    }
}