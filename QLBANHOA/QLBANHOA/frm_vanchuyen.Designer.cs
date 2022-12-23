namespace QLBANHOA
{
    partial class frm_vanchuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_vanchuyen));
            this.dgVanChuyen = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.save = new System.Windows.Forms.ToolStripLabel();
            this.delVanChuyen = new System.Windows.Forms.ToolStripButton();
            this.cancelVanChuyen = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmakv = new System.Windows.Forms.TextBox();
            this.txttenkv = new System.Windows.Forms.TextBox();
            this.txtkhoangcach = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgVanChuyen)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgVanChuyen
            // 
            this.dgVanChuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVanChuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgVanChuyen.Location = new System.Drawing.Point(3, 17);
            this.dgVanChuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgVanChuyen.Name = "dgVanChuyen";
            this.dgVanChuyen.RowHeadersWidth = 51;
            this.dgVanChuyen.RowTemplate.Height = 24;
            this.dgVanChuyen.Size = new System.Drawing.Size(567, 195);
            this.dgVanChuyen.TabIndex = 0;
            this.dgVanChuyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVanChuyen_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.save,
            this.delVanChuyen,
            this.cancelVanChuyen});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // save
            // 
            this.save.Image = ((System.Drawing.Image)(resources.GetObject("save.Image")));
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(60, 24);
            this.save.Text = "Save";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // delVanChuyen
            // 
            this.delVanChuyen.Image = ((System.Drawing.Image)(resources.GetObject("delVanChuyen.Image")));
            this.delVanChuyen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delVanChuyen.Name = "delVanChuyen";
            this.delVanChuyen.Size = new System.Drawing.Size(77, 24);
            this.delVanChuyen.Text = "Delete";
            this.delVanChuyen.Click += new System.EventHandler(this.delVanChuyen_Click);
            // 
            // cancelVanChuyen
            // 
            this.cancelVanChuyen.Image = ((System.Drawing.Image)(resources.GetObject("cancelVanChuyen.Image")));
            this.cancelVanChuyen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelVanChuyen.Name = "cancelVanChuyen";
            this.cancelVanChuyen.Size = new System.Drawing.Size(77, 24);
            this.cancelVanChuyen.Text = "Cancel";
            this.cancelVanChuyen.Click += new System.EventHandler(this.cancelVanChuyen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã khu vực";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên khu vực";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khoảng cách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giá";
            // 
            // txtmakv
            // 
            this.txtmakv.Location = new System.Drawing.Point(195, 30);
            this.txtmakv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmakv.Name = "txtmakv";
            this.txtmakv.Size = new System.Drawing.Size(284, 26);
            this.txtmakv.TabIndex = 6;
            // 
            // txttenkv
            // 
            this.txttenkv.Location = new System.Drawing.Point(195, 60);
            this.txttenkv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttenkv.Name = "txttenkv";
            this.txttenkv.Size = new System.Drawing.Size(284, 26);
            this.txttenkv.TabIndex = 7;
            // 
            // txtkhoangcach
            // 
            this.txtkhoangcach.Location = new System.Drawing.Point(193, 95);
            this.txtkhoangcach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtkhoangcach.Name = "txtkhoangcach";
            this.txtkhoangcach.Size = new System.Drawing.Size(228, 26);
            this.txtkhoangcach.TabIndex = 8;
            this.txtkhoangcach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtkhoangcach_KeyPress);
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(195, 127);
            this.txtgia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(227, 26);
            this.txtgia.TabIndex = 9;
            this.txtgia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgia_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(207, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(362, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "THÊM PHÍ VẬN CHUYỂN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgVanChuyen);
            this.groupBox1.Location = new System.Drawing.Point(71, 272);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(573, 214);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Mục Phí Vận Chuyển";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtgia);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtkhoangcach);
            this.groupBox2.Controls.Add(this.txtmakv);
            this.groupBox2.Controls.Add(this.txttenkv);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(71, 94);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(573, 155);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giá phí vận chuyển";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(459, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Đơn vị (VNĐ)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(467, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Đơn vị (m)";
            // 
            // frm_vanchuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_vanchuyen";
            this.Text = "Chi Phí Vận Chuyển";
            this.Load += new System.EventHandler(this.frm_vanchuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVanChuyen)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVanChuyen;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmakv;
        private System.Windows.Forms.TextBox txttenkv;
        private System.Windows.Forms.TextBox txtkhoangcach;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripButton delVanChuyen;
        private System.Windows.Forms.ToolStripButton cancelVanChuyen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}