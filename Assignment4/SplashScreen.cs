using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void splashFormTimer_Tick(object sender, EventArgs e)
        {
            //1. intantiate 
            StartForm selectionForm = new StartForm();

            this.splashFormTimer.Enabled = false;
            selectionForm.Show();
            this.Hide();
        }
    }
}
