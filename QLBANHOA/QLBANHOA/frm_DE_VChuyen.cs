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
    public partial class frm_DE_VChuyen : DevExpress.XtraEditors.XtraForm
    {
        bool flag = true;
        QLBANHOAEntities6 data = new QLBANHOAEntities6();

        public frm_DE_VChuyen()
        {
            InitializeComponent();
        }

        private void btn_DE_saveVC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (flag)
            {
                if (int.Parse(txtkhoangcach.Text.Trim()) < 0)
                {
                    MessageBox.Show("Vui lòng nhập khoảng cách lớn hơn 0 !!!", "Thông Báo");
                }
                else if (int.Parse(txtgia.Text.Trim()) < 0)
                {
                    MessageBox.Show("Vui lòng nhập giá lớn hơn 0 !!!", "Thông Báo");
                }
                else if (!String.IsNullOrEmpty(txtmakv.Text.Trim()) && !String.IsNullOrEmpty(txttenkv.Text.Trim()) && !String.IsNullOrEmpty(txtkhoangcach.Text.Trim())
                    && !String.IsNullOrEmpty(txtgia.Text.Trim()))

                {
                    var h = new GIAPHIVANCHUYEN
                    {
                        MAKHUVUC = txtmakv.Text.Trim(),
                        TENKHUVUC = txttenkv.Text.Trim(),
                        KHOANGCACH = int.Parse(txtkhoangcach.Text.Trim()),
                        GIA = int.Parse(txtgia.Text.Trim())
                    };
                    data.GIAPHIVANCHUYENs.Add(h);
                    data.SaveChanges();
                    txtmakv.Text = null;
                    txttenkv.Text = null; 
                    txtgia.Text = null;
                    txtkhoangcach.Text = null;
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
                    var vanchuyen = data.GIAPHIVANCHUYENs.FirstOrDefault(x => x.MAKHUVUC.Contains(txtmakv.Text.Trim()));
                    vanchuyen.TENKHUVUC = txttenkv.Text.Trim();
                    vanchuyen.KHOANGCACH = int.Parse(txtkhoangcach.Text.Trim());
                    vanchuyen.GIA = int.Parse(txtgia.Text.Trim());
                    data.SaveChanges();
                    txtmakv.Text = null;
                    txttenkv.Text = null;
                    txtgia.Text = null;
                    txtkhoangcach.Text = null;
                    flag = true;
                    getData();
                }
            }
        }

        private void getData()
        {
            List<GIAPHIVANCHUYEN> lst = data.GIAPHIVANCHUYENs.ToList();
            int i = 0;
            var v = from t in lst
                    select new
                    {
                        STT = ++i,
                        MaKhuVuc = t.MAKHUVUC,
                        TenKhuVuc = t.TENKHUVUC,
                        KhoangCach = t.KHOANGCACH,
                        Gia = t.GIA
                    };

            dgVanChuyen.DataSource = v.ToList();
            dgVanChuyen.Columns[1].HeaderText = "Mã Khu Vực";
            dgVanChuyen.Columns[2].HeaderText = "Tên Khu Vực";
            dgVanChuyen.Columns[3].HeaderText = "Khoảng Cách(m)";
            dgVanChuyen.Columns[4].HeaderText = "Giá tiền(VNĐ)";
            dgVanChuyen.AutoResizeColumns();
            dgVanChuyen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void frm_DE_VChuyen_Load(object sender, EventArgs e)
        {
            getData();
            init();
        }

        private void init()
        {
            txtgia.Text = "1000";
            txtkhoangcach.Text = "1000";
            btn_DE_delVC.Enabled = false;
        }

        private void dgVanChuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgVanChuyen.Rows[e.RowIndex];
                txtmakv.Text = r.Cells[1].Value.ToString();
                txttenkv.Text = r.Cells[2].Value.ToString();
                txtgia.Text = r.Cells[4].Value.ToString();
                txtkhoangcach.Text = r.Cells[3].Value.ToString();
                flag = false;
                txtmakv.ReadOnly = true;
                btn_DE_delVC.Enabled = true;
            }
        }

        private void btn_DE_delVC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var s = (from t in data.GIAPHIVANCHUYENs
                         where t.MAKHUVUC == txtmakv.Text
                         select t
                          ).SingleOrDefault();
                var vanchuyen_phieudat = data.PHIEUDATs.FirstOrDefault(x => x.MAKHUVUC.Contains(txtmakv.Text));
                if (vanchuyen_phieudat != null)
                {
                    MessageBox.Show("Khu vực này có liên kết dữ liệu với bảng khác không xóa được");
                    txtmakv.Text = null;
                    txttenkv.Text = null;
                    txtgia.Text = null;
                    txtkhoangcach.Text = null;
                }
                else
                {
                    data.GIAPHIVANCHUYENs.Remove(s);
                    data.SaveChanges();
                    getData();
                    txtmakv.Text = null;
                    txttenkv.Text = null;
                    txtgia.Text = null;
                    txtkhoangcach.Text = null;
                }
                btn_DE_delVC.Enabled = false;
                txtmakv.ReadOnly = false;
                flag = true;

            }
        }

        private void btn_DE_cancelVC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtmakv.ReadOnly = false;
            btn_DE_delVC.Enabled = false;
            txtmakv.Text = null;
            txttenkv.Text = null;
            txtgia.Text = null;
            txtkhoangcach.Text = null;
            flag = true;
        }

        private void txtkhoangcach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

            {

                e.Handled = true;

            }
        }

        private void txtgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

            {

                e.Handled = true;

            }
        }
    }
}