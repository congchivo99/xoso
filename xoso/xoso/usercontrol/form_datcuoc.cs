using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xoso.usercontrol
{
    public partial class form_datcuoc : UserControl
    {
        public form_datcuoc()
        {
            InitializeComponent();
        }

        private void logout_user(object sender, EventArgs e)
        {
            string val = ((menu)Parent.Controls["menu1"]).get_taikhoan();
            thamsosql[] thamso = new thamsosql[1];

            thamso[0].ten = "@sdt";
            thamso[0].kieu = SqlDbType.VarChar;
            thamso[0].giatri = val;
            DataTable d = XLDL.Doc_bang("xoa_userlog", thamso);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            lblThoiGian.Text = "Thời gian còn lại = " + (60 - now.Minute).ToString("00") + ":" + (60 - now.Second).ToString("00");
        }

        private void form_datcuoc_Load(object sender, EventArgs e)
        {
            this.HandleDestroyed += logout_user;
            //
            var now = DateTime.Now;
            lblThoiGian.Text = "Thời gian còn lại = " + (60 - now.Minute).ToString("00") + ":" + (60 - now.Second).ToString("00");

            var parentForm = (this.Parent as Form);
            string val = ((xoso.usercontrol.menu)parentForm.Controls["menu1"]).get_taikhoan();
            lblUser.Text = val;
            txtChonSo.Focus();
        }

        private void cmdDat_Click(object sender, EventArgs e)
        {
            var parentForm = (this.Parent as Form);
            string val = ((menu)parentForm.Controls["menu1"]).get_taikhoan();
            thamsosql[] thamso = new thamsosql[2];

            thamso[0].ten = "@sdt";
            thamso[0].kieu = SqlDbType.VarChar;
            thamso[0].giatri = val;
            
            thamso[1].ten = "@chonso";
            thamso[1].kieu = SqlDbType.Int;
            thamso[1].giatri = txtChonSo.Value.ToString();

            DataTable taikhoan = XLDL.Doc_bang("luu_datcuoc", thamso);
            if (taikhoan.Rows.Count > 0)
            {
                if (taikhoan.Rows[0]["ketqua"].ToString() == "1")
                {
                    lblThongBao.Text = "Đã lưu slot đặt cược. Số của bạn = " + txtChonSo.Value.ToString();

                    //refresh bảng
                    ((danhsachslot)parentForm.Controls["danhsachslot"]).get_danhsach(val);
                }
                else
                {
                    lblThongBao.Text = "Bạn đã đặt slot này rồi. Xin chờ giờ tiếp theo.";
                }
            }
            else
            {
                lblThongBao.Text = "Lỗi khi thực thi XLDL.Doc_bang";
            }
        }

        private void txtChonSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmdDat.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        
    }
}
