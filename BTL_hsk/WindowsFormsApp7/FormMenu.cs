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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void quảnLýNhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQlyNXB f = new FormQlyNXB();
            f.MdiParent = this;
            f.Show();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQlySach f2 = new FormQlySach();
            f2.MdiParent = this;
            f2.Show();
        }

        private void thêmHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThemHD f = new FrmThemHD();
            f.MdiParent = this;
            f.Show();
        }

        private void sửaHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSuaHD f = new FrmSuaHD();
            f.MdiParent = this;
            f.Show();
        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FrmCTHD f = new FrmCTHD();
            
            f.MdiParent = this;
            f.Show();
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKH f = new FrmKH();
            f.MdiParent = this;
            f.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQLyNhanVien f = new FrmQLyNhanVien();
            f.MdiParent = this;
            f.Show();
        }
    }
}
