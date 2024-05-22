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
    public partial class FrmKH : Form
    {
        public FrmKH()
        {
            InitializeComponent();
        }

        private void loaddl()
        {
            string constr = ConfigurationManager.ConnectionStrings["db_qlbs"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandText = "prHienKH";
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dataGridView1.DataSource = tb;
                    }
                    cnn.Close();
                }
            }
        }

        public bool kiemtraKHtontai()
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            string makh = txtMaKH.Text;
            string tenkh = txtTenKH.Text;
            DateTime ngaysinh = dateTimePicker1.Value.Date;
            string gioitinh = rdNam.Checked ? "Nam" : "Nữ";
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;

            string constr = ConfigurationManager.ConnectionStrings["db_qlbs"].ConnectionString;
            if (txtMaKH.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenKH.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(dateTimePicker1.Value.Date > DateTime.Now)
            {
                MessageBox.Show("Vui lòng nhập lại vì ngày sinh bạn nhập lớn hơn hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtDiaChi.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSDT.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (kiemtraKHtontai() == true)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cnn.Open();
                        cmd.CommandText = "prThemKH";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@makh", makh);
                        cmd.Parameters.AddWithValue("@tenkh", tenkh);
                        cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
                        cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
                        cmd.Parameters.AddWithValue("@diachi", diachi);
                        cmd.Parameters.AddWithValue("@sdt", sdt);

                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Thêm thành công!");

                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại!");
                        }
                        cnn.Close();
                        loaddl();
                    }
                }
            }
        }

        private void FrmKH_Load(object sender, EventArgs e)
        {
            loaddl();
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtSDT.Text);
                errorProvider1.SetError(txtSDT, null);
            }
            catch
            {
                errorProvider1.SetError(txtSDT, "Vui lòng nhập số");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string makh = txtMaKH.Text;
            string tenkh = txtTenKH.Text;
            DateTime ngaysinh = dateTimePicker1.Value.Date;
            string gioitinh = rdNam.Checked ? "Nam" : "Nữ";
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;

            string constr = ConfigurationManager.ConnectionStrings["db_qlbs"].ConnectionString;
            if (txtMaKH.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTenKH.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dateTimePicker1.Value.Date > DateTime.Now)
            {
                MessageBox.Show("Vui lòng nhập lại vì ngày sinh bạn nhập lớn hơn hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtDiaChi.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSDT.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (kiemtraKHtontai() == false)
            {
                MessageBox.Show("Mã khách hàng không tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cnn.Open();
                        cmd.CommandText = "prCapnhatKH";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@makh", makh);
                        cmd.Parameters.AddWithValue("@tenkh", tenkh);
                        cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
                        cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
                        cmd.Parameters.AddWithValue("@diachi", diachi);
                        cmd.Parameters.AddWithValue("@sdt", sdt);

                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Sửa thành công!");

                        }
                        else
                        {
                            MessageBox.Show("Sửa thất bại!");
                        }
                        cnn.Close();
                        loaddl();
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string makh = txtMaKH.Text;

            string constr = ConfigurationManager.ConnectionStrings["db_qlbs"].ConnectionString;
            if (txtMaKH.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng cần xóa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cnn.Open();
                        cmd.CommandText = "prXoaKH";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@makh", makh);



                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Xoá thành công");

                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại.");
                        }
                        cnn.Close();
                        loaddl();

                    }
                }
            }
        }

        private void FrmKH_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
