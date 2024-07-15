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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void cmdClient_Click(object sender, EventArgs e)
        {
            FormCollection all_form = Application.OpenForms;
            foreach (Form frm in all_form)
            {
                if (frm.Name == "ClientForm")
                {
                    frm.BringToFront();
                    frm.WindowState = FormWindowState.Normal;
                    return;
                }
            }
            var cf = new ClientForm();
            //cf.ShowDialog(this);
            cf.Name = "ClientForm";
            cf.Show();
        }

        private void cmdAdmin_Click(object sender, EventArgs e)
        {
            FormCollection all_form = Application.OpenForms;
            foreach (Form frm in all_form)
            {
                if (frm.Name == "AdminForm")
                {
                    frm.BringToFront();
                    frm.WindowState = FormWindowState.Normal;
                    return;
                }
            }
            var af = new AdminForm();
            //af.ShowDialog(this);
            af.Name = "AdminForm";
            af.Show();
        }
    }
}
