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
    public partial class frm_DE_KHang : DevExpress.XtraEditors.XtraForm
    {
        bool flag = true;
        QLBANHOAEntities6 data = new QLBANHOAEntities6();
        public frm_DE_KHang()
        {
            InitializeComponent();
        }

        private void btn_DE_saveKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (flag)
            {
                if (!String.IsNullOrEmpty(txt_MaKH.Text.Trim()) && !String.IsNullOrEmpty(txt_TenKH.Text.Trim()) && !String.IsNullOrEmpty(txt_DCKH.Text.Trim())
                && !String.IsNullOrEmpty(txt_DTKH.Text.Trim()))

                {
                    var kh = new KHACHHANG
                    {
                        MAKHACHHANG = txt_MaKH.Text.Trim(),
                        HOTEN = txt_TenKH.Text.Trim(),
                        DIACHI = txt_DCKH.Text.Trim(),
                        SODT = txt_DTKH.Text.Trim()
                    };
                    data.KHACHHANGs.Add(kh);
                    data.SaveChanges();
                    txt_MaKH.Text = null;
                    txt_TenKH.Text = null;
                    txt_DTKH.Text = null;
                    txt_DCKH.Text = null;
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
                    var khachhang = data.KHACHHANGs.FirstOrDefault(x => x.MAKHACHHANG.Contains(txt_MaKH.Text.Trim()));
                    khachhang.HOTEN = txt_TenKH.Text.Trim();
                    khachhang.DIACHI = txt_DCKH.Text.Trim();
                    khachhang.SODT = txt_DTKH.Text.Trim();
                    data.SaveChanges();
                    txt_MaKH.Text = null;
                    txt_TenKH.Text = null;
                    txt_DTKH.Text = null;
                    txt_DCKH.Text = null;
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
            dgKH.DataSource = v.ToList();
            dgKH.AutoResizeColumns();
            dgKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgKH.Columns[1].HeaderText = "Mã Khách Hàng";
            dgKH.Columns[2].HeaderText = "Họ tên";
            dgKH.Columns[3].HeaderText = "Địa chỉ";
            dgKH.Columns[4].HeaderText = "SĐT";
        }

        private void frm_DE_KHang_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void dgKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgKH.Rows[e.RowIndex];
                txt_MaKH.Text = r.Cells[1].Value.ToString();
                txt_TenKH.Text = r.Cells[2].Value.ToString();
                txt_DCKH.Text = r.Cells[3].Value.ToString();
                txt_DTKH.Text = r.Cells[4].Value.ToString();
                flag = false;
                txt_MaKH.ReadOnly = true;
                btn_DE_delKH.Enabled = true;
            }
        }

        private void btn_DE_delKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var s = (from t in data.KHACHHANGs
                         where t.MAKHACHHANG == txt_MaKH.Text
                         select t).SingleOrDefault();
                var khachhang_phieudat = data.PHIEUDATs.FirstOrDefault(x => x.MAKHACHHANG.Contains(txt_MaKH.Text));
                if (khachhang_phieudat != null)
                {
                    MessageBox.Show("Khách hàng này có liên kết dữ liệu với bảng khác không xóa được");
                    txt_MaKH.Text = null;
                    txt_TenKH.Text = null;
                    txt_DTKH.Text = null;
                    txt_DCKH.Text = null;
                }
                else
                {
                    data.KHACHHANGs.Remove(s);
                    data.SaveChanges();
                    getData();
                    txt_MaKH.Text = null;
                    txt_TenKH.Text = null;
                    txt_DTKH.Text = null;
                    txt_DCKH.Text = null;
                }

                btn_DE_delKH.Enabled = false;
                txt_MaKH.ReadOnly = false;
                flag = true;
            }
        }

        private void btn_DE_cancelKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txt_MaKH.ReadOnly = false;
            btn_DE_delKH.Enabled = false;
            flag = true;

            txt_MaKH.Text = null;
            txt_TenKH.Text = null;
            txt_DTKH.Text = null;
            txt_DCKH.Text = null;
        }

        private void txt_DTKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

            {

                e.Handled = true;

            }
        }
    }
}