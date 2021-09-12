using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC470_P2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void seeFish_bt_Click(object sender, EventArgs e)
        {
            if (crappieSelected_rbt.Checked)
            {
                FormSeeFish frmSF = new FormSeeFish("Crappie");
                frmSF.Show();
            } else if (perchSelected_rbt.Checked) {

                FormSeeFish frmSF = new FormSeeFish("Perch");
                frmSF.Show();

            } else
            {
                FormSeeFish frmSF = new FormSeeFish("Walleye");
                frmSF.Show();
            }
        }


    }
}
