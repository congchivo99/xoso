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
    public partial class statusbar : UserControl
    {
        public statusbar()
        {
            InitializeComponent();
        }
        public void tao_status(string sdt)
        {
            thamsosql[] thamso = new thamsosql[1];
            thamso[0].ten = "@sdt";
            thamso[0].kieu = SqlDbType.VarChar;
            thamso[0].giatri = sdt;

            DataTable d = XLDL.Doc_bang("tim_nguoichoi", thamso);
            if (d.Rows.Count > 0)
            {
                for(var i = 0; i < d.Columns.Count; i++)
                {
                    ToolStripStatusLabel lbl = new ToolStripStatusLabel(d.Columns[i].ColumnName + ": " + d.Rows[0][i].ToString());
                    lbl.Name = d.Columns[i].ColumnName;
                    statusStrip1.Items.Add(lbl);
                }
            }
        }
        public void remove_status()
        {
            statusStrip1.Items.Clear();
        }
    }
}
