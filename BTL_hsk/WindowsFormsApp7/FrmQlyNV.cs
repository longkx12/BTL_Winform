using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApp7
{
    public partial class FrmQLyNhanVien : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["db_qlbs"].ConnectionString;
        public FrmQLyNhanVien()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void LayDSNV()
        {
            //khởi tạo các đối tượng SqlConnection, SqlDataAdapter, DataTable
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable table = new DataTable();

                try
                {
                    //mở chuỗi kết nối
                    cnn.Open();
                    //khai báo đối tượng SqlCommand trong SqlDataAdapter
                    da.SelectCommand = new SqlCommand();
                    //gọi thủ tục từ SQL
                    da.SelectCommand.CommandText = "prHienNV";
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    //gán chuỗi kết nối
                    da.SelectCommand.Connection = cnn;
                    //sử dụng phương thức fill để điền dữ liệu từ datatable vào SqlDataAdapter
                    da.Fill(table);
                    //gán dữ liệu từ datatable vào datagridview
                    dgvNV.DataSource = table;
                    //đóng chuỗi kết nối
                    cnn.Close();
                    //sử dụng thuộc tính Width và HeaderText để set chiều dài và tiêu đề cho các coloumns
                    dgvNV.Columns[0].Width = 40;
                    dgvNV.Columns[0].HeaderText = "Mã NV";
                    dgvNV.Columns[1].Width = 200;
                    dgvNV.Columns[1].HeaderText = "Tên NV";
                    dgvNV.Columns[2].Width = 100;
                    dgvNV.Columns[2].HeaderText = "Ngày sinh";
                    dgvNV.Columns[3].Width = 90;
                    dgvNV.Columns[3].HeaderText = "Giới tính";
                    dgvNV.Columns[4].Width = 90;
                    dgvNV.Columns[4].HeaderText = "Quê Quán";
                    dgvNV.Columns[5].Width = 90;
                    dgvNV.Columns[5].HeaderText = "SĐT";
                    dgvNV.Columns[6].Width = 90;
                    dgvNV.Columns[6].HeaderText = "Chức vụ";
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FormQlyNV_Load(object sender, EventArgs e)
        {
            LayDSNV();
        }


        public bool KTThongTin()
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã NV", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
                return false;
            }
            if (txtTenNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên NV", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNV.Focus();
                return false;
            }
            if (txtdiachi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdiachi.Focus();
                return false;
            }
            if (txtsdt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập SĐT", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsdt.Focus();
                return false;
            }
            if (cbCheckNamNu.Text == "")
            {
                MessageBox.Show("Vui lòng chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsdt.Focus();
                return false;
            }
            if (cbCvu.Text == "")
            {
                MessageBox.Show("Vui lòng chọn chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsdt.Focus();
                return false;
            }
            return true;
        }

        private bool KTkhoachinh()
        {
            SqlConnection cnn = new SqlConnection(constr);
            cnn.Open();
            string sql = "select sMaNV from tblNhanVien where sMaNV = '" + txtMaNV.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Mã Nhân viên đã tồn tại, vui lòng nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return false;
            }
            return true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (KTThongTin())
            {
                if (KTkhoachinh())
                {
                    try
                    {
                        using (SqlConnection cnn = new SqlConnection(constr))
                        {
                            SqlCommand cmd = new SqlCommand();

                            cmd.CommandText = "prThemNV";
                            cmd.CommandType = CommandType.StoredProcedure;
                            
                            cmd.Parameters.AddWithValue("@manv", txtMaNV.Text);
                            cmd.Parameters.AddWithValue("@tennv", txtTenNV.Text) ;
                            cmd.Parameters.AddWithValue("@ngaysinh", dtNS.Value.Date);
                            cmd.Parameters.AddWithValue("@gioitinh", cbCheckNamNu.Text);
                            cmd.Parameters.AddWithValue("@diachi", txtdiachi.Text);
                            cmd.Parameters.AddWithValue("@sdt", txtsdt.Text);
                            cmd.Parameters.AddWithValue("@chucvu", cbCvu.Text);

                            cmd.Connection = cnn;
                            cnn.Open();
                            cmd.ExecuteNonQuery();
                            cnn.Close();
                            LayDSNV();
                            MessageBox.Show("Đã thêm mới Nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nhập tuổi lớn hơn 18");
                    }
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvNV.Rows[e.RowIndex];
            txtMaNV.Text = Convert.ToString(row.Cells["sMaNV"].Value);
            txtTenNV.Text = Convert.ToString(row.Cells["sTenNV"].Value);
            dtNS.Text = Convert.ToString(row.Cells["dNgaysinh"].Value);
            cbCheckNamNu.Text = Convert.ToString(row.Cells["sGioitinh"].Value);
            txtdiachi.Text = Convert.ToString(row.Cells["sQuequan"].Value);
            txtsdt.Text = Convert.ToString(row.Cells["sSDT"].Value);
            cbCvu.Text = Convert.ToString(row.Cells["sChucvu"].Value);
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Cần nhập Mã Nhân viên muốn sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "prSuaNhanVien";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@manv", txtMaNV.Text);
                    cmd.Parameters.AddWithValue("@tennv", txtTenNV.Text);
                    cmd.Parameters.AddWithValue("@ngaysinh", dtNS.Value.Date);
                    cmd.Parameters.AddWithValue("@gioitinh", cbCheckNamNu.Text);
                    cmd.Parameters.AddWithValue("@diachi", txtdiachi.Text);
                    cmd.Parameters.AddWithValue("@sdt", txtsdt.Text);
                    cmd.Parameters.AddWithValue("@chucvu", cbCvu.Text);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Đã sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    cnn.Close();
                    LayDSNV();

                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "prXoaNhanVien";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@manv", txtMaNV.Text);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    cnn.Close();
                    LayDSNV();
                }
            }
        }
        private void timkiemNV(string valueTK)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("prTimkiemNV", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tukhoa", valueTK);
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        ad.Fill(dt);
                        dgvNV.DataSource = dt;
                    }
                }
            }
            if (txtTimkiem.Text == "") LayDSNV();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            timkiemNV(txtTimkiem.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            FrmrpNV rpnv = new FrmrpNV();
            rpnv.Show();
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            cbCheckNamNu.Text = "";
            cbCvu.Text = "";
            txtsdt.Text = "";
            txtdiachi.Text = "";

        }
    }
}
