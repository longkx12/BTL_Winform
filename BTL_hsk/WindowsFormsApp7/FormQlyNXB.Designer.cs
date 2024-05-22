
namespace WindowsFormsApp7
{
    partial class FormQlyNXB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQlyNXB));
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaNXB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvNXB = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(709, 466);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 46);
            this.panel1.TabIndex = 27;
            // 
            // btnIn
            // 
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.Location = new System.Drawing.Point(1003, 466);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(164, 54);
            this.btnIn.TabIndex = 25;
            this.btnIn.Text = "In danh sách";
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(545, 466);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(352, 241);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhà xuất bản";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.txtMaNXB);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtsdt);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtdiachi);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtTenNXB);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(12, 23);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 202);
            this.panel2.TabIndex = 0;
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.Location = new System.Drawing.Point(148, 15);
            this.txtMaNXB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.Size = new System.Drawing.Size(148, 22);
            this.txtMaNXB.TabIndex = 19;
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
            this.label4.Location = new System.Drawing.Point(297, 117);
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
            this.txtsdt.Location = new System.Drawing.Point(148, 164);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(148, 22);
            this.txtsdt.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 167);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "SĐT :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 117);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Địa chỉ :";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(148, 113);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.label12.Size = new System.Drawing.Size(127, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Tên nhà xuất bản :";
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Location = new System.Drawing.Point(148, 64);
            this.txtTenNXB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(148, 22);
            this.txtTenNXB.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 18);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mã nhà xuất bản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(568, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "QUẢN LÝ NHÀ XUẤT BẢN";
            // 
            // btnthem
            // 
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.Location = new System.Drawing.Point(377, 466);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(143, 49);
            this.btnThoat.TabIndex = 28;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvNXB
            // 
            this.dgvNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNXB.Location = new System.Drawing.Point(383, 126);
            this.dgvNXB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvNXB.Name = "dgvNXB";
            this.dgvNXB.RowHeadersWidth = 51;
            this.dgvNXB.Size = new System.Drawing.Size(784, 321);
            this.dgvNXB.TabIndex = 29;
            this.dgvNXB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormQlyNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 645);
            this.Controls.Add(this.dgvNXB);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnthem);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormQlyNXB";
            this.Text = "FormQlyNXB";
            this.Load += new System.EventHandler(this.FormQlyNXB_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).EndInit();
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
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvNXB;
        private System.Windows.Forms.TextBox txtMaNXB;
    }
}