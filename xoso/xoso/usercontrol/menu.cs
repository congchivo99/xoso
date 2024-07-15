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
    public partial class menu : UserControl
    {
        public menu()
        {
            InitializeComponent();
        }

        private void MenuItemdangnhap_Click(object sender, EventArgs e)
        {
            var ctrl = new xoso.usercontrol.loginform();
            var parentForm = (this.Parent as Form);

            ctrl.Left = (this.Parent.ClientSize.Width - ctrl.Width) / 2;
            ctrl.Top = (this.Parent.ClientSize.Height - ctrl.Height) / 2;
            
            parentForm.Controls.Add(ctrl);
            
        }
        public void taikhoan(string sdt)
        {
            menuStrip1.Items["MenuItemuser"].Text = sdt;
        }
        public string get_taikhoan()
        {
            return menuStrip1.Items["MenuItemuser"].Text;
        }

        private void MenuItemdangky_Click(object sender, EventArgs e)
        {
            var ctr = new xoso.usercontrol.dangkyform();
            var parentForm = (this.Parent as Form);

            ctr.Left = (parentForm.Width - ctr.Width) / 2;
            ctr.Top = (parentForm.Height - ctr.Height) / 2;

            parentForm.Controls.Add(ctr);
        }

        private void MenuItemLogout_Click(object sender, EventArgs e)
        {
            thamsosql[] ts = new thamsosql[1];
            ts[0].ten = "@sdt";
            ts[0].kieu = SqlDbType.VarChar;
            ts[0].giatri = menuStrip1.Items["MenuItemuser"].Text;
            DataTable d = XLDL.Doc_bang("xoa_userlog", ts);

            taikhoan("Chưa đăng nhập");
            var parentForm = (this.Parent as Form);
            parentForm.Controls.RemoveByKey("form_datcuoc");
            parentForm.Controls.RemoveByKey("danhsachslot");
            ((statusbar)parentForm.Controls["statusbar1"]).remove_status();


        }
    }
}
