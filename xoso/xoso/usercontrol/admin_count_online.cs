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
    public partial class admin_count_online : UserControl
    {
        public admin_count_online()
        {
            InitializeComponent();
        }
        public void get_danhsach()
        {
            DataTable d = XLDL.Doc_bang2("tim_danhsachuserlog");
            luoitk.DataSource = d;
        }

        private void admin_count_online_Load(object sender, EventArgs e)
        {
            get_danhsach();
        }
    }
}
