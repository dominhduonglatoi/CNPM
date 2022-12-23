using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBANHOA
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void menuKhachHang_Click(object sender, EventArgs e)
        {
            frm_add_KhachHang f = new frm_add_KhachHang();
            f.MdiParent = this;
            f.Show();
        }

        private void menuHoa_Click(object sender, EventArgs e)
        {
            frm_add_Hoa f = new frm_add_Hoa();
            f.MdiParent = this;
            f.Show();
        }

        private void menuVanChuyen_Click(object sender, EventArgs e)
        {
            frm_vanchuyen f = new frm_vanchuyen();
            f.MdiParent = this;
            f.Show();
        }

        private void phiếuĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_phieuhang f = new frm_phieuhang();
            f.MdiParent = this;
            f.Show();
        }
    }
}
