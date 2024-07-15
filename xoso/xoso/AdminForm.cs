using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xoso
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            //add danh sách người chơi đã đăng ký
            usercontrol.admin_danhsachnguoichoi ctr = new usercontrol.admin_danhsachnguoichoi();
            ctr.Dock = DockStyle.Left;
            ctr.Width = 280;
            this.Controls.Add(ctr);
            ctr.BringToFront();

            //add các kết quả đã lưu
            usercontrol.admin_danhsachdatcuoc ctr2 = new usercontrol.admin_danhsachdatcuoc();
            ctr2.Top = ctr.Top;
            ctr2.Left = ctr.Width + 6;
            ctr2.Height = ctr.Height;
            ctr2.Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left;
            this.Controls.Add(ctr2);

            usercontrol.admin_count_online ctr3 = new usercontrol.admin_count_online();
            ctr3.Top = ctr.Top;
            ctr3.Left = ctr2.Width + ctr2.Left + 6;
            Controls.Add(ctr3);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int m = DateTime.Now.Minute;
            
            usercontrol.admin_danhsachnguoichoi ctr = (usercontrol.admin_danhsachnguoichoi)this.Controls["admin_danhsachnguoichoi"];
            ctr.get_danhsach();

            usercontrol.admin_danhsachdatcuoc ctr2 = (usercontrol.admin_danhsachdatcuoc)Controls["admin_danhsachdatcuoc"];
            ctr2.get_danhsach();

            usercontrol.admin_count_online ctr3 = (usercontrol.admin_count_online)Controls["admin_count_online"];
            ctr3.get_danhsach();

            toolStripStatusLabel1.Text = "Đã refresh lúc " + DateTime.Now.ToLongTimeString();

            //kiểm tra phút, nếu đến 00 thì lưu 1 số vào database
            if (m == 0)
            {
                //gọi store 
                DataTable d = XLDL.Doc_bang2("luu_ketqua");
                if (d.Rows.Count > 0)
                {
                    if (d.Rows[0]["ketqua"].ToString() == "1")
                        toolStripStatusLabel1.Text = "Đã lưu 1 con số vào lúc: " + DateTime.Now.ToLongTimeString();
                }
            }
        }
    }
}
