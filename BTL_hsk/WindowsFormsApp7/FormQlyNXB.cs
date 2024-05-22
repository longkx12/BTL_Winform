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
    public partial class FormQlyNXB : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["db_qlbs"].ConnectionString;
        public FormQlyNXB()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void LayDSNXB()
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
                    da.SelectCommand.CommandText = "danhsachNXB";
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    //gán chuỗi kết nối
                    da.SelectCommand.Connection = cnn;
                    //sử dụng phương thức fill để điền dữ liệu từ datatable vào SqlDataAdapter
                    da.Fill(table);
                    //gán dữ liệu từ datatable vào datagridview
                    dgvNXB.DataSource = table;
                    //đóng chuỗi kết nối
                    cnn.Close();
                    //sử dụng thuộc tính Width và HeaderText để set chiều dài và tiêu đề cho các coloumns
                    dgvNXB.Columns[0].Width = 40;
                    dgvNXB.Columns[0].HeaderText = "Mã NXB";
                    dgvNXB.Columns[1].Width = 200;
                    dgvNXB.Columns[1].HeaderText = "Tên NXB";
                    dgvNXB.Columns[2].Width = 200;
                    dgvNXB.Columns[2].HeaderText = "Địa chỉ";
                    dgvNXB.Columns[3].Width = 90;
                    dgvNXB.Columns[3].HeaderText = "Số ĐT";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        private void FormQlyNXB_Load(object sender, EventArgs e)
        {
            LayDSNXB();
        }

        public bool KTThongTin()
        {
            if (txtMaNXB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã NXB", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNXB.Focus();
                return false;
            }
            if (txtTenNXB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên NXB", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNXB.Focus();
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
            return true;
        }

        private bool KTkhoachinh()
        {
            SqlConnection cnn = new SqlConnection(constr);
            cnn.Open();
            string sql = "select sMaNXB from tblNXB where sMaNXB = '" + txtMaNXB.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Mã Nhà xuất bản đã tồn tại, vui lòng nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNXB.Focus();
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

                            cmd.CommandText = "prThemNXB";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@manxb", txtMaNXB.Text);
                            cmd.Parameters.AddWithValue("@tennxb", txtTenNXB.Text);
                            cmd.Parameters.AddWithValue("@diachi", txtdiachi.Text);
                            cmd.Parameters.AddWithValue("@sdt", txtsdt.Text);


                            cmd.Connection = cnn;
                            cnn.Open();
                            cmd.ExecuteNonQuery();
                            cnn.Close();
                            LayDSNXB();
                            MessageBox.Show("Đã thêm mới NXB thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvNXB.Rows[e.RowIndex];
            txtMaNXB.Text = Convert.ToString(row.Cells["sMaNXB"].Value);
            txtTenNXB.Text = Convert.ToString(row.Cells["sTenNXB"].Value);
            txtdiachi.Text = Convert.ToString(row.Cells["sDiachi"].Value);
            txtsdt.Text = Convert.ToString(row.Cells["sSDT"].Value);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNXB.Text == "")
            {
                MessageBox.Show("Cần nhập mã NXB muốn sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "prSuaNXB";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@manxb", txtMaNXB.Text);
                    cmd.Parameters.AddWithValue("@tennxb", txtTenNXB.Text);
                    cmd.Parameters.AddWithValue("@diachi", txtdiachi.Text);
                    cmd.Parameters.AddWithValue("@sdt", txtsdt.Text);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Đã sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    cnn.Close();
                    LayDSNXB();

                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandText = "prXoaNXB";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@manxb", txtMaNXB.Text);
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    cnn.Close();
                    LayDSNXB();
                }
            }
        }
        private void timKiemNXB(string valueTK)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("timkiem_theoma", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tennxb", valueTK);
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        ad.Fill(dt);
                        dgvNXB.DataSource = dt;
                    }
                }
            }
            if (txtTimkiem.Text == "") LayDSNXB();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            timKiemNXB(txtTimkiem.Text);
        }
    }
}
