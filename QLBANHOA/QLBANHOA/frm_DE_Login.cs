using DevExpress.XtraEditors;
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
    public partial class frm_DE_Login : DevExpress.XtraEditors.XtraForm
    {
        QLNHANVIENEntities data = new QLNHANVIENEntities();
        public frm_DE_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTaiKhoan.Text.Trim()) || String.IsNullOrEmpty(txtMatKhau.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng nhập!!!", "Thông Báo");
            }
            else
            {
                var pass = (from t in data.TKNVs
                           where t.MATK == txtTaiKhoan.Text
                           select t.PASSWORD).SingleOrDefault();
                if(pass != txtMatKhau.Text)
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!!!", "Thông Báo");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công!!!", "Thông Báo");
                    frm_DE_Main frm_main = new frm_DE_Main();
                    frm_main.Show();
                }
            }
            
        }
    }
}