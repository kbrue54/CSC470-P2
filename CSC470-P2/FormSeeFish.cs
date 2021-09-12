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
        public string userSelection;
        public FormSeeFish(string fish)
        {

            InitializeComponent();
            CenterToScreen();
            pictureBoxFish.SizeMode = PictureBoxSizeMode.Zoom;

            switch (fish)
            {
                case "Crappie":
                    pictureBoxFish.Image = Properties.Resources.Crappie;
                    break;

                case "Perch":
                    pictureBoxFish.Image = Properties.Resources.Perch;
                    break;

                case "Walleye":
                    pictureBoxFish.Image = Properties.Resources.Walleye;
                    break;
            }

        }

        private void cancel_bt_Click(object sender, EventArgs e)
        {
            userSelection = "Decision canceled";
            Close();
        }

        private void throwItBack_bt_Click(object sender, EventArgs e)
        {
            userSelection = "Decision is to throw it back.";
            Close();
        }

        private void keepIt_bt_Click(object sender, EventArgs e)
        {
            userSelection = "Decision is to keep it.";
            Close();
        }
    }
}
