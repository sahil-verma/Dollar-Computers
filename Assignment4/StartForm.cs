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
    public partial class StartForm : Form
    {

        public StartForm()
        {
            InitializeComponent();
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm();

            selectForm.previousForm = this;
            selectForm.Show();
            this.Hide();
        }

        private void savedOrderButton_Click(object sender, EventArgs e)
        {
            //1. intantiate 
            SelectForm selectForm = new SelectForm();

            //2. pass a reference
            selectForm.previousForm = this;

            selectForm.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
