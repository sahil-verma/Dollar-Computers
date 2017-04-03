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

        private void _newOrderButton_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm();

            selectForm.previousForm = this;
            selectForm.Show();
            this.Hide();
        }

        private void _savedOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.Show();
        }

        private void _exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
