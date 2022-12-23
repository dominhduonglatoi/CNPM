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
    public partial class frm_add_KhachHang : Form
    {
        bool flag = true;
        QLBANHOAEntities6 data = new QLBANHOAEntities6();
        public frm_add_KhachHang()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                if (!String.IsNullOrEmpty(txtMaKH.Text.Trim()) && !String.IsNullOrEmpty(txtTenKH.Text.Trim()) && !String.IsNullOrEmpty(txtDiachi.Text.Trim())
                && !String.IsNullOrEmpty(txtSDT.Text.Trim()))

                {
                    var kh = new KHACHHANG
                    {
                        MAKHACHHANG = txtMaKH.Text.Trim(),
                        HOTEN = txtTenKH.Text.Trim(),
                        DIACHI = txtDiachi.Text.Trim(),
                        SODT = txtSDT.Text.Trim()
                    };
                    data.KHACHHANGs.Add(kh);
                    data.SaveChanges();
                    txtMaKH.Clear();
                    txtTenKH.Clear();
                    txtDiachi.Clear();
                    txtSDT.Clear();
                    getData();

                }

                else
                {

                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !!!", "Thông Báo");

                }

            }
            else
            {
                if (MessageBox.Show("Bạn có muốn sửa thông tin  không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var khachhang = data.KHACHHANGs.FirstOrDefault(x => x.MAKHACHHANG.Contains(txtMaKH.Text.Trim()));
                    khachhang.HOTEN = txtTenKH.Text.Trim();
                    khachhang.DIACHI = txtDiachi.Text.Trim();
                    khachhang.SODT = txtSDT.Text.Trim();
                    data.SaveChanges();
                    txtMaKH.Clear();
                    txtTenKH.Clear();
                    txtDiachi.Clear();
                    txtSDT.Clear();
                    flag = true;
                    getData();
                }
            }

        }

        private void getData()
        {
            List<KHACHHANG> lst = data.KHACHHANGs.ToList();
            int i = 0;
            var v = from t in lst
                    select new
                    {
                        STT = ++i,
                        MaKhachHang = t.MAKHACHHANG,
                        TenKhachHang = t.HOTEN,
                        DiaChi = t.DIACHI,
                        SDT = t.SODT
                    };
            dg_KH.DataSource = v.ToList();
            dg_KH.AutoResizeColumns();
            dg_KH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg_KH.Columns[1].HeaderText = "Mã Khách Hàng";
            dg_KH.Columns[2].HeaderText = "Họ tên";
            dg_KH.Columns[3].HeaderText = "Địa chỉ";
            dg_KH.Columns[4].HeaderText = "SĐT";



        }

        private void frm_add_KhachHang_Load(object sender, EventArgs e)
        {
            getData();
            delKhachHang.Enabled = false;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

            {

                e.Handled = true;

            }
        }

        private void dg_KH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dg_KH.Rows[e.RowIndex];
                txtMaKH.Text = r.Cells[1].Value.ToString();
                txtTenKH.Text = r.Cells[2].Value.ToString();
                txtDiachi.Text = r.Cells[3].Value.ToString();
                txtSDT.Text = r.Cells[4].Value.ToString();
                flag = false;
                txtMaKH.ReadOnly = true;
                delKhachHang.Enabled = true;
            }
        }

        private void delKhachHang_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var s = (from t in data.KHACHHANGs
                         where t.MAKHACHHANG == txtMaKH.Text
                         select t).SingleOrDefault();
                var khachhang_phieudat = data.PHIEUDATs.FirstOrDefault(x => x.MAKHACHHANG.Contains(txtMaKH.Text));       
                if (khachhang_phieudat != null)
                {
                    MessageBox.Show("Khách hàng này có liên kết dữ liệu với bảng khác không xóa được");
                    txtMaKH.Clear();
                    txtTenKH.Clear();
                    txtDiachi.Clear();
                    txtSDT.Clear();
                }
                else
                {
                    data.KHACHHANGs.Remove(s);
                    data.SaveChanges();
                    getData();
                    txtMaKH.Clear();
                    txtTenKH.Clear();
                    txtDiachi.Clear();
                    txtSDT.Clear();
                }
             
                delKhachHang.Enabled = false;
                txtMaKH.ReadOnly = false;
                flag = true;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            txtMaKH.ReadOnly = false;
            delKhachHang.Enabled = false;
            flag = true;
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtDiachi.Clear();
            txtSDT.Clear();
        }
    }
}
