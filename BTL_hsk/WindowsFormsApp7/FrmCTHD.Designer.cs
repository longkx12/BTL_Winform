namespace WindowsFormsApp7
{
    partial class FrmCTHD
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
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMasach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSuaCT = new System.Windows.Forms.Button();
            this.errSL = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errSL)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Location = new System.Drawing.Point(0, 240);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowTemplate.Height = 24;
            this.dgvCTHD.Size = new System.Drawing.Size(798, 207);
            this.dgvCTHD.TabIndex = 0;
            this.dgvCTHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHD_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSL);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMasach);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 185);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN HÓA ĐƠN";
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(121, 138);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(100, 22);
            this.txtSL.TabIndex = 16;
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số lượng";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(121, 41);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(100, 22);
            this.txtMaHD.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã hóa đơn";
            // 
            // txtMasach
            // 
            this.txtMasach.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasach.Location = new System.Drawing.Point(121, 87);
            this.txtMasach.Name = "txtMasach";
            this.txtMasach.Size = new System.Drawing.Size(100, 22);
            this.txtMasach.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã sách";
            // 
            // btnSuaCT
            // 
            this.btnSuaCT.Location = new System.Drawing.Point(88, 211);
            this.btnSuaCT.Name = "btnSuaCT";
            this.btnSuaCT.Size = new System.Drawing.Size(75, 23);
            this.btnSuaCT.TabIndex = 22;
            this.btnSuaCT.Text = "Sửa";
            this.btnSuaCT.UseVisualStyleBackColor = true;
            this.btnSuaCT.Click += new System.EventHandler(this.btnSuaCT_Click);
            // 
            // errSL
            // 
            this.errSL.ContainerControl = this;
            // 
            // FrmCTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSuaCT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCTHD);
            this.Name = "FrmCTHD";
            this.Text = "FrmCTHD";
            this.Load += new System.EventHandler(this.FrmCTHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errSL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMasach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSuaCT;
        private System.Windows.Forms.ErrorProvider errSL;
    }
}