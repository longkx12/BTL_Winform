namespace WindowsFormsApp7
{
    partial class FrmSuaHD
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
            this.dgvHoadon = new System.Windows.Forms.DataGridView();
            this.btnSuaHD = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.cboTrangthai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtPNgaymua = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaNVlap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHoadon
            // 
            this.dgvHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoadon.Location = new System.Drawing.Point(12, 251);
            this.dgvHoadon.Name = "dgvHoadon";
            this.dgvHoadon.RowTemplate.Height = 24;
            this.dgvHoadon.Size = new System.Drawing.Size(991, 193);
            this.dgvHoadon.TabIndex = 18;
            this.dgvHoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoadon_CellClick);
            // 
            // btnSuaHD
            // 
            this.btnSuaHD.AutoSize = true;
            this.btnSuaHD.Location = new System.Drawing.Point(41, 191);
            this.btnSuaHD.Name = "btnSuaHD";
            this.btnSuaHD.Size = new System.Drawing.Size(110, 27);
            this.btnSuaHD.TabIndex = 17;
            this.btnSuaHD.Text = "Sửa";
            this.btnSuaHD.UseVisualStyleBackColor = true;
            this.btnSuaHD.Click += new System.EventHandler(this.btnSuaHD_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.cboTrangthai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtPNgaymua);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 157);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN HÓA ĐƠN";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(121, 109);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 22);
            this.txtMaKH.TabIndex = 16;
            // 
            // cboTrangthai
            // 
            this.cboTrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangthai.FormattingEnabled = true;
            this.cboTrangthai.Items.AddRange(new object[] {
            "Chua thanh toan",
            "Da thanh toan"});
            this.cboTrangthai.Location = new System.Drawing.Point(413, 62);
            this.cboTrangthai.Name = "cboTrangthai";
            this.cboTrangthai.Size = new System.Drawing.Size(121, 24);
            this.cboTrangthai.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Trạng thái";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(121, 21);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(100, 22);
            this.txtMaHD.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày mua";
            // 
            // dtPNgaymua
            // 
            this.dtPNgaymua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPNgaymua.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPNgaymua.Location = new System.Drawing.Point(412, 19);
            this.dtPNgaymua.Name = "dtPNgaymua";
            this.dtPNgaymua.Size = new System.Drawing.Size(122, 22);
            this.dtPNgaymua.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã hóa đơn";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(121, 64);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 22);
            this.txtMaNV.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã nhân viên";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(333, 194);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMaNVlap);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtNam);
            this.groupBox2.Controls.Add(this.txtThang);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(650, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 157);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "In báo cáo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã NV lập";
            // 
            // txtMaNVlap
            // 
            this.txtMaNVlap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNVlap.Location = new System.Drawing.Point(114, 112);
            this.txtMaNVlap.Name = "txtMaNVlap";
            this.txtMaNVlap.Size = new System.Drawing.Size(100, 22);
            this.txtMaNVlap.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tháng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Năm";
            // 
            // txtNam
            // 
            this.txtNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.Location = new System.Drawing.Point(114, 69);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(100, 22);
            this.txtNam.TabIndex = 1;
            // 
            // txtThang
            // 
            this.txtThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThang.Location = new System.Drawing.Point(114, 24);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(100, 22);
            this.txtThang.TabIndex = 0;
            this.txtThang.TextChanged += new System.EventHandler(this.txtThang_TextChanged);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(724, 191);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(124, 23);
            this.btnIn.TabIndex = 0;
            this.btnIn.Text = "In báo cáo";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSuaHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 450);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvHoadon);
            this.Controls.Add(this.btnSuaHD);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSuaHD";
            this.Text = "FrmSuaHD";
            this.Load += new System.EventHandler(this.FrmSuaHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoadon;
        private System.Windows.Forms.Button btnSuaHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboTrangthai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtPNgaymua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaNVlap;
    }
}