
namespace WindowsFormsApp7
{
    partial class FrmQLyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQLyNhanVien));
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbCvu = new System.Windows.Forms.ComboBox();
            this.cbCheckNamNu = new System.Windows.Forms.ComboBox();
            this.dtNS = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(709, 466);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(164, 54);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-4, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tìm kiếm :";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(120, 9);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(260, 22);
            this.txtTimkiem.TabIndex = 0;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTimkiem);
            this.panel1.Location = new System.Drawing.Point(383, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 46);
            this.panel1.TabIndex = 27;
            // 
            // btnIn
            // 
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.Location = new System.Drawing.Point(1003, 466);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(164, 54);
            this.btnIn.TabIndex = 25;
            this.btnIn.Text = "In danh sách";
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnSua
            // 
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(545, 466);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(156, 54);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(17, 70);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(352, 450);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhân viên";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.cbCvu);
            this.panel2.Controls.Add(this.cbCheckNamNu);
            this.panel2.Controls.Add(this.dtNS);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtMaNV);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtsdt);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtdiachi);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtTenNV);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(12, 23);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 636);
            this.panel2.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(111, 373);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 32);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbCvu
            // 
            this.cbCvu.FormattingEnabled = true;
            this.cbCvu.Items.AddRange(new object[] {
            "Admin",
            "Giám Đốc",
            "Nhân Viên"});
            this.cbCvu.Location = new System.Drawing.Point(148, 314);
            this.cbCvu.Name = "cbCvu";
            this.cbCvu.Size = new System.Drawing.Size(148, 24);
            this.cbCvu.TabIndex = 31;
            // 
            // cbCheckNamNu
            // 
            this.cbCheckNamNu.FormattingEnabled = true;
            this.cbCheckNamNu.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbCheckNamNu.Location = new System.Drawing.Point(148, 169);
            this.cbCheckNamNu.Name = "cbCheckNamNu";
            this.cbCheckNamNu.Size = new System.Drawing.Size(148, 24);
            this.cbCheckNamNu.TabIndex = 30;
            // 
            // dtNS
            // 
            this.dtNS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNS.Location = new System.Drawing.Point(148, 117);
            this.dtNS.Name = "dtNS";
            this.dtNS.Size = new System.Drawing.Size(148, 22);
            this.dtNS.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 122);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 17);
            this.label16.TabIndex = 28;
            this.label16.Text = "Ngày sinh :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 169);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 17);
            this.label15.TabIndex = 27;
            this.label15.Text = "Giới tính :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(297, 317);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "(*)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(297, 266);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "(*)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(297, 214);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "(*)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 319);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Chức vụ :";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(148, 15);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(148, 22);
            this.txtMaNV.TabIndex = 19;
            this.txtMaNV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(297, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "(*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(297, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "(*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(297, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "(*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(297, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "(*)";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(148, 265);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(148, 22);
            this.txtsdt.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 268);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "SĐT :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 214);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Quê quán :";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(148, 214);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(148, 22);
            this.txtdiachi.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 68);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Tên nhân viên :";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(148, 64);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(148, 22);
            this.txtTenNV.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 18);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mã nhân viên:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(568, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "QUẢN LÝ NHÂN VIÊN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.Location = new System.Drawing.Point(377, 466);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(156, 54);
            this.btnthem.TabIndex = 19;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(1024, 528);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(143, 49);
            this.btnThoat.TabIndex = 28;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvNV
            // 
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Location = new System.Drawing.Point(383, 126);
            this.dgvNV.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowHeadersWidth = 51;
            this.dgvNV.Size = new System.Drawing.Size(784, 321);
            this.dgvNV.TabIndex = 29;
            this.dgvNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmQLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 645);
            this.Controls.Add(this.dgvNV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnthem);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmQLyNhanVien";
            this.Text = "FrmQLyNhanVien";
            this.Load += new System.EventHandler(this.FormQlyNV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtNS;
        private System.Windows.Forms.ComboBox cbCheckNamNu;
        private System.Windows.Forms.ComboBox cbCvu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnClear;
    }
}