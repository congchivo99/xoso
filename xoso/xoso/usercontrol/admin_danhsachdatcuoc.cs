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
    public partial class admin_danhsachdatcuoc : UserControl
    {
        public admin_danhsachdatcuoc()
        {
            InitializeComponent();
        }
        public void get_danhsach()
        {
            DataTable d = XLDL.Doc_bang2("tim_admin_danhsach_ketqua_datcuoc");
            danhsach_kq.DataSource = d;
        }

        private void admin_danhsachdatcuoc_Load(object sender, EventArgs e)
        {
            get_danhsach();
        }
    }
}
