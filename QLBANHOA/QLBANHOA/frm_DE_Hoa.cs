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
    public partial class frm_DE_Hoa : DevExpress.XtraEditors.XtraForm
    {
        QLBANHOAEntities6 data = new QLBANHOAEntities6();
        bool flag = true;

        public frm_DE_Hoa()
        {
            InitializeComponent();
        }

        private void frm_DE_Hoa_Load(object sender, EventArgs e)
        {
            getData();
            
        }

        private void btn_DE_saveHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (flag)
            {
                if (int.Parse(txt_GiaHoa.Text.Trim()) < 0)
                {
                    MessageBox.Show("Vui lòng nhập giá lớn hơn 0 !!!", "Thông Báo");
                }
                else if (!String.IsNullOrEmpty(txt_MaHoa.Text.Trim()) && !String.IsNullOrEmpty(txt_TenHoa.Text.Trim()) && !String.IsNullOrEmpty(txt_MauHoa.Text.Trim())
                    && !String.IsNullOrEmpty(txt_GiaHoa.Text.Trim()))

                {
                    var h = new DM_HOA
                    {
                        MAHOA = txt_MaHoa.Text.Trim(),
                        TENHOA = txt_TenHoa.Text.Trim(),
                        MAUSAC = txt_MauHoa.Text.Trim(),
                        GIA = int.Parse(txt_GiaHoa.Text.Trim())
                    };
                    data.DM_HOA.Add(h);
                    data.SaveChanges();
                    txt_MaHoa.Text = null;
                    txt_TenHoa.Text = null;
                    txt_MauHoa.Text = null;
                    txt_GiaHoa.Text = null;
                    
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
                    var hoa = (from t in data.DM_HOA
                               where t.MAHOA == txt_MaHoa.Text
                               select t).SingleOrDefault();
                    hoa.TENHOA = txt_TenHoa.Text.Trim();
                    hoa.MAUSAC = txt_MauHoa.Text.Trim();
                    hoa.GIA = int.Parse(txt_GiaHoa.Text.Trim());
                    data.SaveChanges();
                    txt_MaHoa.Text = null;
                    txt_TenHoa.Text = null;
                    txt_MauHoa.Text = null;
                    txt_GiaHoa.Text = null;
                    txt_GiaHoa.Text = "1000";
                    getData();
                    flag = true;
                }
            }
        }

        private void getData()
        {
            List<DM_HOA> lst = data.DM_HOA.ToList();
            int i = 0;
            var v = from t in lst
                    select new
                    {
                        STT = ++i,
                        MaHoa = t.MAHOA,
                        TenHoa = t.TENHOA,
                        MauSac = t.MAUSAC,
                        Gia = t.GIA
                    };

            dgHoa.DataSource = v.ToList();
            dgHoa.Columns[1].HeaderText = "Mã Hoa";
            dgHoa.Columns[2].HeaderText = "Tên Hoa";
            dgHoa.Columns[3].HeaderText = "Màu Sắc";
            dgHoa.Columns[4].HeaderText = "Giá tiền";
            dgHoa.AutoResizeColumns();
            dgHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgHoa.Rows[e.RowIndex];
                txt_MaHoa.Text = r.Cells[1].Value.ToString();
                txt_TenHoa.Text = r.Cells[2].Value.ToString();
                txt_GiaHoa.Text = r.Cells[4].Value.ToString();
                txt_MauHoa.Text = r.Cells[3].Value.ToString();
                flag = false;
                txt_MaHoa.ReadOnly = true;
                btn_DE_delHoa.Enabled = true;
            }
        }

        private void btn_DE_delHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var s = (from t in data.DM_HOA
                         where t.MAHOA == txt_MaHoa.Text
                         select t
                          ).SingleOrDefault();
                var hoa_phieudat = data.PHIEUDATs.FirstOrDefault(x => x.MAHOA.Contains(txt_MaHoa.Text));
                if (hoa_phieudat != null)
                {
                    MessageBox.Show("Hoa này có liên kết dữ liệu với bảng khác không xóa được");
                    txt_MaHoa.Text = null;
                    txt_TenHoa.Text = null;
                    txt_MauHoa.Text = null;
                    txt_GiaHoa.Text = null;
                    txt_GiaHoa.Text = "1000";
                }
                else
                {
                    data.DM_HOA.Remove(s);
                    data.SaveChanges();
                    getData();
                    txt_MaHoa.Text = null;
                    txt_TenHoa.Text = null;
                    txt_MauHoa.Text = null;
                    txt_GiaHoa.Text = null;
                    txt_GiaHoa.Text = "1000";
                }
                flag = true;
                btn_DE_delHoa.Enabled = false;
                txt_MaHoa.ReadOnly = false;
            }
        }

        private void btn_DE_cancelHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txt_MaHoa.ReadOnly = false;
            btn_DE_delHoa.Enabled = false;
            txt_MaHoa.Text = null;
            txt_TenHoa.Text = null;
            txt_MauHoa.Text = null;
            txt_GiaHoa.Text = null;
            flag = true;
        }

        private void txt_GiaHoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

            {

                e.Handled = true;

            }
        }
    }
}