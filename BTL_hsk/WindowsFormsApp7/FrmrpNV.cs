using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class FrmrpNV : Form
    {
        public FrmrpNV()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["db_qlbs"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable table = new DataTable();

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
                    rpNV rpnv = new rpNV();
                    rpnv.SetDataSource(table);
                    crystalReportViewer1.ReportSource = rpnv;
                crystalReportViewer1.Refresh();
                cnn.Close();
                
             }
        } 
    } 
}

