using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace WindowsFormsApp7
{
    public partial class FrmSuaHD : Form
    {
        public FrmSuaHD()
        {
            InitializeComponent();
        }
        private bool kiemtraNVtontai()
        {
            bool kt = false;
            string manv = txtMaNV.Text;
            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["db_qlbs"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select sMaNV from tblNhanVien", cnn);
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (manv == dr.GetString(0))
                {
                    kt = true;
                    break;
                }
            }
            cnn.Close();
            return kt;
        }
        private bool kiemtraNVlaptontai()
        {
            bool kt = false;
            string manv = txtMaNVlap.Text;
            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["db_qlbs"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select sMaNV from tblNhanVien", cnn);
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (manv == dr.GetString(0))
                {
                    kt = true;
                    break;
                }
            }
            cnn.Close();
            return kt;
        }
        private bool kiemtraKHtontai()
        {
            bool kt = false;
            string makh = txtMaKH.Text;
            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["db_qlbs"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select sMaKH from tblKhachHang", cnn);
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (makh == dr.GetString(0))
                {
                    kt = true;
                    break;
                }
            }
            cnn.Close();
            return kt;
        }

        private void FrmSuaHD_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["db_qlbs"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandText = "prHiendsHD ";
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgvHoadon.DataSource = tb;
                    }
                    cnn.Close();
                }
            }
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {

            string mahd = txtMaHD.Text;
            string makh = txtMaKH.Text;
            DateTime ngaylap = dtPNgaymua.Value.Date;
            string manv = txtMaNV.Text;
            int trangthai = cboTrangthai.SelectedIndex;

            if (txtMaHD.Text.Length == 0 || txtMaKH.Text.Length == 0 || txtMaNV.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
             if (kiemtraKHtontai() == false)
                {
                    MessageBox.Show("Mã khách hàng không đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             else if(kiemtraNVtontai() == false)
            {
                MessageBox.Show("Mã nhân viên không đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string constr = ConfigurationManager.ConnectionStrings["db_qlbs"].ConnectionString;
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cnn.Open();
                        cmd.CommandText = "prCapnhatHDcb";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@mahd", mahd);
                        cmd.Parameters.AddWithValue("@manv", manv);
                        cmd.Parameters.AddWithValue("@makh", makh);
                        cmd.Parameters.AddWithValue("@ngaylap", ngaylap);
                        cmd.Parameters.AddWithValue("@trangthai", trangthai);

                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("sua thanh cong");

                        }
                        else
                        {
                            MessageBox.Show("sua that bai");
                        }
                        cnn.Close();
                        FrmSuaHD_Load(sender, e);
                    }
                }
            }
        }
        private void dgvHoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvHoadon.Rows[e.RowIndex];
            txtMaHD.Text = Convert.ToString(row.Cells[0].Value);
            txtMaNV.Text = Convert.ToString(row.Cells[2].Value);
            txtMaKH.Text = Convert.ToString(row.Cells[3].Value);
            dtPNgaymua.Value = Convert.ToDateTime(row.Cells[1].Value);
            cboTrangthai.Text = Convert.ToString(row.Cells[6].Value);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string mahd = txtMaHD.Text;


                string constr = ConfigurationManager.ConnectionStrings["db_qlbs"].ConnectionString;
                if (txtMaHD.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn cần xóa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {

                    using (SqlConnection cnn = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = cnn.CreateCommand())
                        {
                            cnn.Open();
                            cmd.CommandText = "prXoaHD";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@mahd", mahd);



                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Xoa thanh cong");

                            }
                            else
                            {
                                MessageBox.Show("Hóa đơn chưa thanh toán không thể xóa.");
                            }
                            cnn.Close();
                            FrmSuaHD_Load(sender, e);
                            
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hóa đơn chưa thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvHoadon.Rows[e.RowIndex];
            txtMaHD.Text = Convert.ToString(row.Cells[0].Value);
            txtMaNV.Text = Convert.ToString(row.Cells[2].Value);
            txtMaKH.Text = Convert.ToString(row.Cells[3].Value);
            dtPNgaymua.Value = Convert.ToDateTime(row.Cells[1].Value);
            cboTrangthai.Text = Convert.ToString(row.Cells[6].Value);
        }

       
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNam.TextLength == 0 || txtThang.TextLength == 0 || txtMaNVlap.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else if (kiemtraNVlaptontai() == false)
            {
                    MessageBox.Show("Mã nhân viên không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                FrmRp rp = new FrmRp(int.Parse(txtThang.Text), int.Parse(txtNam.Text), txtMaNVlap.Text);
                rp.Show();
            }
        }

        private void txtThang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
