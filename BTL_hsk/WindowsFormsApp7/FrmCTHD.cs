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
    public partial class FrmCTHD : Form
    {
        public FrmCTHD()
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
                    cmd.CommandText = "prHiendsCTHD  ";
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);
                        dgvCTHD.DataSource = tb;
                    }
                    cnn.Close();
                }
            }
        }
        

        private void FrmCTHD_Load(object sender, EventArgs e)
        {
            loaddl();
        }

        

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvCTHD.Rows[e.RowIndex];
            txtMaHD.Text = Convert.ToString(row.Cells[0].Value);
            txtMasach.Text = Convert.ToString(row.Cells[1].Value);
            txtSL.Text = Convert.ToString(row.Cells[2].Value);
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            string mahd = txtMaHD.Text;
            string masach = txtMasach.Text;
           
            string sl = txtSL.Text;
            

            if (txtMaHD.Text.Length == 0 || txtMasach.Text.Length == 0 || txtSL.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (kiemtratontai() == false)
            {
                MessageBox.Show("Mã sách không đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                string constr = ConfigurationManager.ConnectionStrings["db_qlbs"].ConnectionString;
                using (SqlConnection cnn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cnn.Open();
                        cmd.CommandText = "prCapnhatchitiethd";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@mahd", mahd);
                        cmd.Parameters.AddWithValue("@manv", masach);
                        cmd.Parameters.AddWithValue("@makh", sl);
                        

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
                        loaddl();
                    }
                }
            }
        }
        private bool kiemtratontai()
        {
            bool kt = false;
            string masach = txtMasach.Text;
            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["db_qlbs"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select sMasach from tblSach", cnn);
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (masach == dr.GetString(0))
                {
                    kt = true;
                    break;
                }
            }
            cnn.Close();
            return kt;
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtSL.Text);
                errSL.SetError(txtSL,null);
            }
            catch
            {
                errSL.SetError(txtSL, "Vui lòng nhập số.");
            }
        }
    }
}
