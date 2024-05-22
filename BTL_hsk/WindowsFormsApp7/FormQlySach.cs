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
    public partial class FormQlySach : Form
    {
        public FormQlySach()
        {
            InitializeComponent();
        }

        string str = ConfigurationManager.ConnectionStrings["db_qlbs"].ConnectionString;
        string vvSach = "select * from vvSach";
        private void hienDSSach(string query)
        {
            using (SqlConnection cnn = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        ad.Fill(dt);
                        dgvDSSach.DataSource = dt;
                    }
                }
            }
        }
        private void hienNXB()
        {
            using (SqlConnection cnn = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand("Select*from tblNXB", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        ad.Fill(dt);
                        cbNhaXB.DataSource = dt;
                        cbNhaXB.DisplayMember = "sTenNXB";
                        cbNhaXB.ValueMember = "sMaNXB";
                        cbNhaXB.SelectedItem = false;
                    }
                }
            }
        }
        private void quảnLýNhàXuấtBảnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormQlyNXB f = new FormQlyNXB();
            f.Show();
        }

        private void FormQlySach_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void FormQlySach_FormClosed(object sender, FormClosedEventArgs e)
        {               
        }

        private void FormQlySach_Load(object sender, EventArgs e)
        {
            hienDSSach(vvSach);
            hienNXB();
        }
        string maSachCanXoa;
        string maSachCanSua;

        private void dgvDSSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvDSSach.Rows[e.RowIndex];
                tbTenSach.Text = row.Cells[1].Value.ToString();
                cbNhaXB.Text = row.Cells[2].Value.ToString();
                tbTacGia.Text = row.Cells[3].Value.ToString();
                tbTheLoai.Text = row.Cells[4].Value.ToString();
                tbGiaTien.Text = row.Cells[5].Value.ToString();
                tbNamXB.Text = row.Cells[6].Value.ToString();
                maSachCanXoa = row.Cells[0].Value.ToString();
                maSachCanSua = row.Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                dgvDSSach.AllowUserToOrderColumns = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tbTenSach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTenSach.Focus();
            }
            else if (cbNhaXB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbNhaXB.Focus();
            }
            else if (tbTacGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTacGia.Focus();
            }
            else if (tbTheLoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTheLoai.Focus();
            }
            else if (tbGiaTien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbGiaTien.Focus();
            }
            else if (tbNamXB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập năm xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNamXB.Focus();
            }
            else
            {
                using (SqlConnection cnn = new SqlConnection(str))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_themSach", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@tensach", tbTenSach.Text);
                        cmd.Parameters.AddWithValue("@manxb", cbNhaXB.Text);
                        cmd.Parameters.AddWithValue("@tacgia", tbTacGia.Text);
                        cmd.Parameters.AddWithValue("@theloai", tbTheLoai.Text);
                        cmd.Parameters.AddWithValue("@giatien", tbGiaTien.Text);
                        cmd.Parameters.AddWithValue("@namxb", tbNamXB.Text);
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0) MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                        else MessageBox.Show("Không thể thêm vì mã sách tồn tại", "Thông báo", MessageBoxButtons.OK);
                        cnn.Close();
                        hienDSSach(vvSach);
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maSachCanSua == "")
            {
                MessageBox.Show("Click vào sách bạn muốn xóa!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (kiemTraTextBoxRong() == false)
            {
                using (SqlConnection cnn = new SqlConnection(str))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_SuaSach", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@masach", maSachCanSua);
                        cmd.Parameters.AddWithValue("@tensach", tbTenSach.Text);
                        cmd.Parameters.AddWithValue("@manxb", cbNhaXB.Text);
                        cmd.Parameters.AddWithValue("@tacgia", tbTacGia.Text);
                        cmd.Parameters.AddWithValue("@theloai", tbTheLoai.Text);
                        cmd.Parameters.AddWithValue("@giatien", tbGiaTien.Text);
                        cmd.Parameters.AddWithValue("@namxb", tbNamXB.Text);
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0) MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                        else MessageBox.Show("Không thể sửa vì mã sách không tồn tại", "Thông báo", MessageBoxButtons.OK);
                        cnn.Close();
                        hienDSSach(vvSach);
                    }
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maSachCanXoa == "")
            {
                MessageBox.Show("Click vào sách bạn muốn xóa!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (kiemTraTextBoxRong() == false)
            {
                using (SqlConnection cnn = new SqlConnection(str))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_xoaSach", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@masach", maSachCanXoa);
                        cnn.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0) MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                        else MessageBox.Show("Không thể xóa vì mã sách không tồn tại", "Thông báo", MessageBoxButtons.OK);
                        cnn.Close();
                        hienDSSach(vvSach);
                    }
                }
            }
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private bool kiemTraTextBoxRong()
        {
            bool kiemtra = false;
            if (tbTenSach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTenSach.Focus();
                kiemtra = true;
            }
            else if (cbNhaXB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbNhaXB.Focus();
                kiemtra = true;
            }
            else if (tbTacGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTacGia.Focus();
                kiemtra = true;
            }
            else if (tbTheLoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTheLoai.Focus();
                kiemtra = true;
            }
            else if (tbGiaTien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbGiaTien.Focus();
                kiemtra = true;
            }
            else if (tbNamXB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập năm xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNamXB.Focus();
                kiemtra = true;
            }
            return kiemtra;
        }
    }
}
