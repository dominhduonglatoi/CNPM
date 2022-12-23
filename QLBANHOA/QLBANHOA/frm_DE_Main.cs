using DevExpress.XtraBars;
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
    public partial class frm_DE_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_DE_Main()
        {
            InitializeComponent();
        }

        private void btn_DM_Hoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_DE_Hoa frm = new frm_DE_Hoa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btn_DM_KHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_DE_KHang frm = new frm_DE_KHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btn_DM_VChuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_DE_VChuyen frm = new frm_DE_VChuyen();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btn_DM_PGiao_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_DE_PGiao frm = new frm_DE_PGiao();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}