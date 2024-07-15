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
    public partial class admin_danhsachnguoichoi : UserControl
    {
        public admin_danhsachnguoichoi()
        {
            InitializeComponent();
        }

        private void admin_danhsachnguoichoi_Load(object sender, EventArgs e)
        {
            get_danhsach();
        }
        public void get_danhsach()
        {
            DataTable d = XLDL.Doc_bang2("tim_admin_danhsachnguoichoi");
            dgv_nguoichoi.DataSource = d;
        }

        private void dgv_nguoichoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
