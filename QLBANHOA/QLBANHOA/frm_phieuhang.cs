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
    public partial class frm_phieuhang : Form
    {
        QLBANHOAEntities6 data = new QLBANHOAEntities6();
        bool flag = true;
        public frm_phieuhang()
        {
            InitializeComponent();
        }

        private void frm_phieuhang_Load(object sender, EventArgs e)
        {
            init();
            getData();
            delPhieuHang.Enabled = false;
        }

        private void init()
        {
            radChuGiao.Checked = true;
            txt_NgayGiao.Format = DateTimePickerFormat.Custom;
            txt_NgayGiao.CustomFormat = "dd/MM/yyyy";
            cboMaHoa.DisplayMember = "TENHOA";
            cboMaHoa.ValueMember = "MAHOA";
            cboKhachHang.DisplayMember = "HOTEN";
            cboKhachHang.ValueMember = "MAKHACHHANG";
            cboMaKhuVuc.DisplayMember = "TENKHUVUC";
            cboMaKhuVuc.ValueMember = "MAKHUVUC";
            cboMaHoa.DataSource = data.DM_HOA.ToList();
            cboKhachHang.DataSource = data.KHACHHANGs.ToList();
            cboMaKhuVuc.DataSource = data.GIAPHIVANCHUYENs.ToList();

        }

        private void getData()
        {
            List<PHIEUDAT> lst = data.PHIEUDATs.ToList();
            int i = 0;
            var v = from t in lst
                    select new
                    {
                        STT = ++i,
                        SoPhieu = t.SOPHIEU,
                        MaHoa = t.DM_HOA.TENHOA,
                        TenKH = t.KHACHHANG.HOTEN,
                        TenNN = t.TENNGUOINHAN,
                        DiaChi = t.DIACHINGUOINHAN,
                        MaKV = t.GIAPHIVANCHUYEN.TENKHUVUC,
                        NgayGiao = t.NGAYGIAO,
                        GioGiao = t.GIOGIAO,
                        TinhTrang = t.DAGIAO
                    };
            dg_phieuhang.DataSource = v.ToList();
            dg_phieuhang.Columns[1].HeaderText = "Số Phiếu";
            dg_phieuhang.Columns[2].HeaderText = "Tên Hoa";
            dg_phieuhang.Columns[3].HeaderText = "Tên Khách Hàng";
            dg_phieuhang.Columns[4].HeaderText = "Họ Tên Người Nhận";
            dg_phieuhang.Columns[5].HeaderText = "Địa Chỉ Người Nhận";
            dg_phieuhang.Columns[6].HeaderText = "Tên Khu Vực";
            dg_phieuhang.Columns[7].HeaderText = "Ngày Giao";
            dg_phieuhang.Columns[8].HeaderText = "Giờ Giao";
            dg_phieuhang.Columns[9].HeaderText = "Tình Trạng";
            dg_phieuhang.AutoResizeColumns();
            dg_phieuhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
            String tt = "Chưa Giao";
            if(flag )
            {
                if (radGiao.Checked)
                {
                    tt = "Đã Giao";
                }
                if (!String.IsNullOrEmpty(txtSoPhieu.Text.Trim()) && !String.IsNullOrEmpty(cboKhachHang.SelectedValue.ToString()) && !String.IsNullOrEmpty(cboKhachHang.SelectedValue.ToString())
                    && !String.IsNullOrEmpty(txtTenNN.Text.Trim()) && !String.IsNullOrEmpty(txtDiaChiNguoiNhan.Text.Trim()) && !String.IsNullOrEmpty(cboMaKhuVuc.SelectedValue.ToString())
                    && !String.IsNullOrEmpty(txt_NgayGiao.Value.ToString("dd/MM/yyyy")) && !String.IsNullOrEmpty(txtGioGiao.Value.ToString("HH:mm")))

                {
                    var h = new PHIEUDAT
                    {
                        SOPHIEU = txtSoPhieu.Text.Trim(),
                        MAHOA = cboMaHoa.SelectedValue.ToString(),
                        MAKHACHHANG = cboKhachHang.SelectedValue.ToString(),
                        TENNGUOINHAN = txtTenNN.Text.Trim(),
                        DIACHINGUOINHAN = txtDiaChiNguoiNhan.Text.Trim(),
                        MAKHUVUC = cboMaKhuVuc.SelectedValue.ToString(),
                        NGAYGIAO = DateTime.Parse(txt_NgayGiao.Value.ToString("dd/MM/yyyy")),
                        GIOGIAO = TimeSpan.Parse(txtGioGiao.Value.ToString("HH:mm")),
                        DAGIAO = tt
                    };
                    data.PHIEUDATs.Add(h);
                    data.SaveChanges();
                    txtTenNN.Clear();
                    txtSoPhieu.Clear();
                    txtDiaChiNguoiNhan.Clear();
                    radChuGiao.Checked = true;
                    radGiao.Checked = false;
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
                    if (radGiao.Checked)
                    {
                        tt = "Đã Giao";
                        MessageBox.Show("Đơn hàng đã giao rồi không thể sửa dữ liệu", "Thông báo");
                    }
                    else
                    {
                        var phieuhang = data.PHIEUDATs.FirstOrDefault(x => x.SOPHIEU.Contains(txtSoPhieu.Text.Trim()));
                        phieuhang.MAHOA = cboMaHoa.SelectedValue.ToString();
                        phieuhang.MAKHACHHANG = cboKhachHang.SelectedValue.ToString();
                        phieuhang.TENNGUOINHAN = txtTenNN.Text.Trim();
                        phieuhang.DIACHINGUOINHAN = txtDiaChiNguoiNhan.Text.Trim();
                        phieuhang.MAKHUVUC = cboMaKhuVuc.SelectedValue.ToString();
                        phieuhang.NGAYGIAO = DateTime.Parse(txt_NgayGiao.Value.ToString("dd/MM/yyyy"));
                        phieuhang.GIOGIAO = TimeSpan.Parse(txtGioGiao.Value.ToString("HH:mm"));
                        phieuhang.DAGIAO = tt;
                        data.SaveChanges();
                        getData();
                        txtTenNN.Clear();
                        txtSoPhieu.Clear();
                        txtDiaChiNguoiNhan.Clear();
                        radChuGiao.Checked = true;
                        radGiao.Checked = false;
                        flag = true;
                    }
                  
                }
            }
           
        }

        private void dg_phieuhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dg_phieuhang.Rows[e.RowIndex];
                txtSoPhieu.Text = r.Cells[1].Value.ToString();
                cboMaHoa.SelectedIndex = cboMaHoa.FindStringExact(r.Cells[2].Value.ToString());
                cboKhachHang.SelectedIndex = cboKhachHang.FindStringExact(r.Cells[3].Value.ToString());
                txtTenNN.Text = r.Cells[4].Value.ToString();
                txtDiaChiNguoiNhan.Text = r.Cells[5].Value.ToString();
                cboMaKhuVuc.SelectedIndex = cboMaKhuVuc.FindStringExact(r.Cells[6].Value.ToString());
                txt_NgayGiao.Text = DateTime.Parse(r.Cells[7].Value.ToString()).ToString();
                txtGioGiao.Text = TimeSpan.Parse(r.Cells[8].Value.ToString()).ToString();
                if(r.Cells[9].Value.ToString()=="Đã Giao")
                {
                    radGiao.Checked = true;
                }
                else
                {
                    radChuGiao.Checked = true;
                }
                flag = false;
                txtSoPhieu.ReadOnly = true;
                delPhieuHang.Enabled = true;
            }
        }

        private void delPhieuHang_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var s = (from t in data.PHIEUDATs
                         where t.SOPHIEU == txtSoPhieu.Text
                         select t
                          ).SingleOrDefault();
                data.PHIEUDATs.Remove(s);
                data.SaveChanges();
                getData();
                txtTenNN.Clear();
                txtSoPhieu.Clear();
                txtDiaChiNguoiNhan.Clear();
                radChuGiao.Checked = false;
                radGiao.Checked = false;
                delPhieuHang.Enabled = false;
                txtSoPhieu.ReadOnly = false;
                flag = true;
            }
        }

        private void cancelPhieuHang_Click(object sender, EventArgs e)
        {
            txtTenNN.Clear();
            txtSoPhieu.Clear();
            txtDiaChiNguoiNhan.Clear();
            radChuGiao.Checked = false;
            radGiao.Checked = false;
            delPhieuHang.Enabled = false;
            txtSoPhieu.ReadOnly = false;
            flag = true;
        }
    }
}
