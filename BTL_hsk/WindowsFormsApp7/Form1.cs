using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            FormMenu f = new FormMenu();
            f.Show();
            this.Hide();
            //f.Logout += F_Logout; ;
        }

        private void F_Logout(object sender, EventArgs e)
        {
            //(sender as FormQlySach).isExit = false;
            //(sender as FormQlySach).Close();
            //this.Show();
        }
    }
}
