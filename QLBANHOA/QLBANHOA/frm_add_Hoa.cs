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
    public partial class frm_add_Hoa : Form
    {
        QLBANHOAEntities6 data = new QLBANHOAEntities6();
        bool flag = true;
        public frm_add_Hoa()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(flag )
            {
                if (int.Parse(txtGiaHoa.Text.Trim()) < 0)
                {
                    MessageBox.Show("Vui lòng nhập giá lớn hơn 0 !!!", "Thông Báo");
                }
                else if (!String.IsNullOrEmpty(txtMaHoa.Text.Trim()) && !String.IsNullOrEmpty(txtTenHoa.Text.Trim()) && !String.IsNullOrEmpty(txtMau.Text.Trim())
                    && !String.IsNullOrEmpty(txtGiaHoa.Text.Trim()))

                {
                    var h = new DM_HOA
                    {
                        MAHOA = txtMaHoa.Text.Trim(),
                        TENHOA = txtTenHoa.Text.Trim(),
                        MAUSAC = txtMau.Text.Trim(),
                        GIA = int.Parse(txtGiaHoa.Text.Trim())
                    };
                    data.DM_HOA.Add(h);
                    data.SaveChanges();
                    txtMaHoa.Clear();
                    txtTenHoa.Clear();
                    txtMau.Clear();
                    txtGiaHoa.Clear();
                    txtGiaHoa.Text = "1000";
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
                               where t.MAHOA == txtMaHoa.Text
                               select t).SingleOrDefault();
                    hoa.TENHOA = txtTenHoa.Text.Trim();
                    hoa.MAUSAC = txtMau.Text.Trim();
                    hoa.GIA = int.Parse(txtGiaHoa.Text.Trim());
                    data.SaveChanges();
                    txtMaHoa.Clear();
                    txtTenHoa.Clear();
                    txtMau.Clear();
                    txtGiaHoa.Clear();
                    txtGiaHoa.Text = "1000";
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

        private void frm_add_Hoa_Load(object sender, EventArgs e)
        {
            getData();
            toolTip1.SetToolTip(txtGiaHoa, "Đơn vị tiền tệ là VNĐ");
            txtGiaHoa.Text = "1000";
            delHoa.Enabled = false;
         
        }

        private void txtGiaHoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

            {

                e.Handled = true;

            }
        }

        private void dgHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgHoa.Rows[e.RowIndex];
                txtMaHoa.Text = r.Cells[1].Value.ToString();
                txtTenHoa.Text = r.Cells[2].Value.ToString();
                txtGiaHoa.Text = r.Cells[4].Value.ToString();
                txtMau.Text = r.Cells[3].Value.ToString();
                flag = false;
                txtMaHoa.ReadOnly = true;
                delHoa.Enabled = true;
            }
        }

        private void delHoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa không ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                var s = (from t in data.DM_HOA
                         where t.MAHOA == txtMaHoa.Text
                         select t
                          ).SingleOrDefault();
                var hoa_phieudat = data.PHIEUDATs.FirstOrDefault(x => x.MAHOA.Contains(txtMaHoa.Text));
                if (hoa_phieudat != null)
                {
                    MessageBox.Show("Hoa này có liên kết dữ liệu với bảng khác không xóa được");
                    txtMaHoa.Clear();
                    txtTenHoa.Clear();
                    txtMau.Clear();
                    txtGiaHoa.Clear();
                    txtGiaHoa.Text = "1000";
                }
                else
                {
                    data.DM_HOA.Remove(s);
                    data.SaveChanges();
                    getData();
                    txtMaHoa.Clear();
                    txtTenHoa.Clear();
                    txtMau.Clear();
                    txtGiaHoa.Clear();
                    txtGiaHoa.Text = "1000";
                }
                flag = true;
                delHoa.Enabled = false;
                txtMaHoa.ReadOnly = false;
            }
        }

        private void cancelHoa_Click(object sender, EventArgs e)
        {
            txtMaHoa.ReadOnly = false;
            delHoa.Enabled = false;
            txtMaHoa.Clear();
            txtTenHoa.Clear();
            txtMau.Clear();
            flag = true;
            txtGiaHoa.Clear();
        }
    }
}
