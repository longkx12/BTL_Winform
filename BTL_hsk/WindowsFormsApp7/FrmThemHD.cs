using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp7
{
    public partial class FrmThemHD : Form
    {
        public FrmThemHD()
        {
            InitializeComponent();
        }
        public void loaddl()
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
        private void FrmHoaDon_Load(object sender, EventArgs e)
        {

            loaddl();

        }
        private void btnThemHD_Click(object sender, EventArgs e)
        {
            string mahd = txtMaHD.Text;
            string makh = txtMaKH.Text;
            DateTime ngaylap = dtPNgaymua.Value.Date;
            string manv = txtMaNV.Text;
            int trangthai = cboTrangthai.SelectedIndex;

            string constr = ConfigurationManager.ConnectionStrings["db_qlbs"].ConnectionString;
            if (txtMaHD.Text.Length == 0 || txtMaKH.Text.Length == 0 || txtMaNV.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (kiemtratontai()) {
                MessageBox.Show("Mã hđ đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            if (kiemtraKHtontai() == false)
            {
                MessageBox.Show("Mã khách hàng không đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (kiemtraNVtontai() == false)
            {
                MessageBox.Show("Mã nhân viên không đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cnn.Open();
                        cmd.CommandText = "prthemhdcoban";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@mahd", mahd);
                        cmd.Parameters.AddWithValue("@manv", manv);
                        cmd.Parameters.AddWithValue("@makh", makh);
                        cmd.Parameters.AddWithValue("@ngaylap", ngaylap);
                        cmd.Parameters.AddWithValue("@trangthai", trangthai);

                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("them thanh cong");

                        }
                        else
                        {
                            MessageBox.Show("Them that bai");
                        }
                        cnn.Close();
                        loaddl();
                        

                    }
                }
            }
        }
        private void btnThemCT_Click(object sender, EventArgs e)
        {
            string mahdct = txtMaHDCT.Text;
            string masach = txtMasachCT.Text;
            int sl = Convert.ToInt32(txtSlCT.Text);

            if (txtMaHDCT.Text.Length == 0 || txtMasachCT.Text.Length == 0 || txtSlCT.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (kiemtraHDCTtontai() == false)
            {
                MessageBox.Show("Mã hđ không tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (kiemtraSachtontai() == false)
                
            {
                MessageBox.Show("Mã sách không tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
                
                

                string constr = ConfigurationManager.ConnectionStrings["db_qlbs"].ConnectionString;
                
                    using (SqlConnection cnn = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = cnn.CreateCommand())
                        {
                            cnn.Open();
                            cmd.CommandText = "prThemCTHD";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@mahd", mahdct);
                            cmd.Parameters.AddWithValue("@masach", masach);
                            cmd.Parameters.AddWithValue("@sl", sl);


                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("them thanh cong");

                            }
                            else
                            {
                                MessageBox.Show("Them that bai");
                            }
                            cnn.Close();
                            loaddl();
                            
                        }
                    }
                
            }
            

        }
        private void txtSlCT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtSlCT.Text);
                
                errSlCT.SetError(txtSlCT, null);
            }
            catch
            {
                errSlCT.SetError(txtSlCT, "Vui lòng nhập số");
            }
        }
        private bool kiemtratontai() {
            bool kt = false;
            string ma = txtMaHD.Text;
            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["db_qlbs"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select sMaHD from tblHoaDon", cnn);
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) {
                if (ma == dr.GetString(0)) {
                    kt = true;
                    break;
                }
            }
            cnn.Close();
            return kt;
        }
        private bool kiemtraHDCTtontai()
        {
            bool kt = false;
            string ma = txtMaHDCT.Text;
            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["db_qlbs"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select sMaHD from tblHoaDon", cnn);
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (ma == dr.GetString(0))
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
        private bool kiemtraSachtontai()
        {
            bool kt = false;
            string manv = txtMasachCT.Text;
            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["db_qlbs"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select sMasach from tblSach", cnn);
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
    }
}
   
    
