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
    public partial class loginform : UserControl
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void cmd_login_Click(object sender, EventArgs e)
        {
            if (txt_sdt.Text.Length == 0)
            {
                lblThongBao.Text = "Xin nhập số điện thoại";
                return;
            }
            
            //chỉ kiểm tra không rỗng, bỏ qua tính đúng đắn của dữ liệu nhập

            thamsosql[] thamso = new thamsosql[1];
            thamso[0].ten = "@sdt";
            thamso[0].kieu = SqlDbType.VarChar;
            thamso[0].giatri = txt_sdt.Text;
            DataTable taikhoan = XLDL.Doc_bang("dang_nhap", thamso);
            if(taikhoan.Rows.Count > 0)
            {
                if(taikhoan.Rows[0]["ketqua"].ToString() == "1")
                {
                    var parentForm = (this.Parent as Form);

                    ((menu)parentForm.Controls["menu1"]).taikhoan(txt_sdt.Text);

                    //load thanh trạng thái
                    ((statusbar)parentForm.Controls["statusbar1"]).tao_status(txt_sdt.Text);

                    //gỡ form login
                    parentForm.Controls.RemoveByKey("loginform");

                    //hiện form đặt cược

                    var ctrl = new form_datcuoc();
                    ctrl.Left = 12;
                    ctrl.Top = 30;//(parentForm.Height - ctrl.Height) / 2;
                    parentForm.Controls.Add(ctrl);

                    //hiện danh sách
                    var ctrl2 = new danhsachslot();
                    ctrl2.Left = parentForm.Width - ctrl2.Width - 16;
                    ctrl2.Top = 30;
                    parentForm.Controls.Add(ctrl2);
                    ctrl2.get_danhsach(txt_sdt.Text);
                }
                else
                {
                    lblThongBao.Text = "Đăng nhập thất bại";
                }
            }
            else
            {
                lblThongBao.Text = "Lỗi: XLDL.Doc_bang";
            }
        }

        private void cmdDong_Click(object sender, EventArgs e)
        {
            var parentForm = (this.Parent as Form);
            parentForm.Controls.RemoveByKey("loginform");
        }

        private void loginform_Load(object sender, EventArgs e)
        {
            txt_sdt.Focus();
        }

        private void txt_sdt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmd_login.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
