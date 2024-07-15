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
    public partial class danhsachslot : UserControl
    {
        public danhsachslot()
        {
            InitializeComponent();
        }
        public void get_danhsach(string sdt)
        {
            thamsosql[] thamso = new thamsosql[1];
            thamso[0].ten = "@sdt";
            thamso[0].kieu = SqlDbType.VarChar;
            thamso[0].giatri = sdt;

            luoiDL.AutoGenerateColumns = true;
            DataTable d= XLDL.Doc_bang("tim_danhsachdatcuoc", thamso);
            luoiDL.DataSource = d;
            
        }

        private void danhsachslot_Load(object sender, EventArgs e)
        {

        }
    }
}
