namespace WindowsFormsApp7
{
    partial class FrmThemHD
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
            this.btnThemHD = new System.Windows.Forms.Button();
            this.dgvHoadon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.dtPNgaymua = new System.Windows.Forms.DateTimePicker();
            this.cboTrangthai = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSlCT = new System.Windows.Forms.TextBox();
            this.txtMasachCT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaHDCT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errSlCT = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errSlCT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemHD
            // 
            this.btnThemHD.AutoSize = true;
            this.btnThemHD.Location = new System.Drawing.Point(12, 197);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(110, 27);
            this.btnThemHD.TabIndex = 1;
            this.btnThemHD.Text = "Thêm hóa đơn";
            this.btnThemHD.UseVisualStyleBackColor = true;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // dgvHoadon
            // 
            this.dgvHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoadon.Location = new System.Drawing.Point(12, 255);
            this.dgvHoadon.Name = "dgvHoadon";
            this.dgvHoadon.RowTemplate.Height = 24;
            this.dgvHoadon.Size = new System.Drawing.Size(987, 228);
            this.dgvHoadon.TabIndex = 5;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã nhân viên";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày mua";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Trạng thái";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(121, 21);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(100, 22);
            this.txtMaHD.TabIndex = 11;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(121, 64);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 22);
            this.txtMaNV.TabIndex = 12;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(121, 112);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 22);
            this.txtMaKH.TabIndex = 13;
            // 
            // dtPNgaymua
            // 
            this.dtPNgaymua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPNgaymua.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPNgaymua.Location = new System.Drawing.Point(359, 19);
            this.dtPNgaymua.Name = "dtPNgaymua";
            this.dtPNgaymua.Size = new System.Drawing.Size(122, 22);
            this.dtPNgaymua.TabIndex = 14;
            // 
            // cboTrangthai
            // 
            this.cboTrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangthai.FormattingEnabled = true;
            this.cboTrangthai.Items.AddRange(new object[] {
            "Chua thanh toan",
            "Da thanh toan"});
            this.cboTrangthai.Location = new System.Drawing.Point(360, 62);
            this.cboTrangthai.Name = "cboTrangthai";
            this.cboTrangthai.Size = new System.Drawing.Size(121, 24);
            this.cboTrangthai.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTrangthai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtPNgaymua);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 157);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THONG TIN HOA DON";
            // 
            // btnThemCT
            // 
            this.btnThemCT.AutoSize = true;
            this.btnThemCT.Location = new System.Drawing.Point(650, 197);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(155, 27);
            this.btnThemCT.TabIndex = 17;
            this.btnThemCT.Text = "Thêm chi tiết hóa đơn";
            this.btnThemCT.UseVisualStyleBackColor = true;
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSlCT);
            this.groupBox2.Controls.Add(this.txtMasachCT);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtMaHDCT);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(650, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 157);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN CTHĐ";
            // 
            // txtSlCT
            // 
            this.txtSlCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlCT.Location = new System.Drawing.Point(124, 107);
            this.txtSlCT.Name = "txtSlCT";
            this.txtSlCT.Size = new System.Drawing.Size(100, 22);
            this.txtSlCT.TabIndex = 16;
            this.txtSlCT.TextChanged += new System.EventHandler(this.txtSlCT_TextChanged);
            // 
            // txtMasachCT
            // 
            this.txtMasachCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasachCT.Location = new System.Drawing.Point(124, 62);
            this.txtMasachCT.Name = "txtMasachCT";
            this.txtMasachCT.Size = new System.Drawing.Size(100, 22);
            this.txtMasachCT.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mã sách";
            // 
            // txtMaHDCT
            // 
            this.txtMaHDCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHDCT.Location = new System.Drawing.Point(124, 21);
            this.txtMaHDCT.Name = "txtMaHDCT";
            this.txtMaHDCT.Size = new System.Drawing.Size(100, 22);
            this.txtMaHDCT.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mã hóa đơn";
            // 
            // errSlCT
            // 
            this.errSlCT.ContainerControl = this;
            // 
            // FrmThemHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThemCT);
            this.Controls.Add(this.dgvHoadon);
            this.Controls.Add(this.btnThemHD);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmThemHD";
            this.Text = "Quan ly hoa don";
            this.Load += new System.EventHandler(this.FrmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errSlCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.DataGridView dgvHoadon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.DateTimePicker dtPNgaymua;
        private System.Windows.Forms.ComboBox cboTrangthai;
        private System.Windows.Forms.Button btnThemCT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSlCT;
        private System.Windows.Forms.TextBox txtMasachCT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaHDCT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errSlCT;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

