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
    public partial class FrmRp : Form
    {
        private int thang;
        private int nam;
        private string ma;
        public FrmRp()
        {
            InitializeComponent();
           

        }
        public FrmRp(int thang, int nam, string manvlap )
        {
            InitializeComponent();
            this.thang = thang;
            this.nam = nam;
            this.ma = manvlap;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            int month = thang;
            int year = nam;
            string manv = ma;
                
            string constr = ConfigurationManager.ConnectionStrings["db_qlbs"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandText = "prtimkiemHD";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@thang", thang);
                    cmd.Parameters.AddWithValue("@nam", nam);
                    cmd.Parameters.AddWithValue("@ma", manv);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    
                    RpHoaDon r = new RpHoaDon();
                    r.SetDataSource(dt);
                    FrmRp f = new FrmRp();
                    crystalReportViewer1.ReportSource = r;
                    crystalReportViewer1.Refresh();

                    cnn.Close();
                }
            }
        }

    }
}
