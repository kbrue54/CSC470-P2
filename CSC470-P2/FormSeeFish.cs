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
    public partial class FormSeeFish : Form
    {
        public FormSeeFish(string fish)
        {
            InitializeComponent();
            CenterToScreen();

            label1.Text = fish;
        }
    }
}
