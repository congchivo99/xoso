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
    public partial class dangkyform : UserControl
    {
        public dangkyform()
        {
            InitializeComponent();
        }

        private void cmdDangKy_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text.Length == 0)
            {
                lblThongBao.Text = "Số điện thoại rỗng. Xin hãy nhập vào";
                txtSDT.Focus();
                return;
            }
            if (txtHoTen.Text.Length == 0)
            {
                lblThongBao.Text = "Họ tên rỗng. Xin hãy nhập vào";
                txtHoTen.Focus();
                return;
            }

            //bỏ qua kiểm tra tính đúng đắn của dữ liệu nhập, định đạng ngày tháng

            thamsosql[] thamso = new thamsosql[3];
            thamso[0].ten = "@sdt";
            thamso[0].kieu = SqlDbType.VarChar;
            thamso[0].giatri = txtSDT.Text;

            thamso[1].ten = "@hoten";
            thamso[1].kieu = SqlDbType.NVarChar;
            thamso[1].giatri = txtHoTen.Text;

            thamso[2].ten = "@ngaysinh";
            thamso[2].kieu = SqlDbType.Date;
            thamso[2].giatri = dateTimePickerNgaySinh.Text;

            //lưu xuống
            DataTable taikhoan = XLDL.Doc_bang("luu_nguoichoi", thamso);
            if (taikhoan.Rows.Count > 0)
            {
                if (taikhoan.Rows[0]["ketqua"].ToString() == "1")
                {
                    //thành công
                    lblThongBao.Text = "Lưu thành công. Hãy đóng form này và đăng nhập.";
                }
                else
                {
                    lblThongBao.Text = "Xin lỗi. Không thể lưu thông tin. Hãy thử đăng nhập.";
                    return;
                }
            }
            else
            {
                lblThongBao.Text = "Lỗi xử lý XLDL.Doc_bang";
            }
        }

        private void cmdDong_Click(object sender, EventArgs e)
        {
            var parentForm = (this.Parent as Form);
            parentForm.Controls.RemoveByKey("dangkyform");
        }
    }
}
