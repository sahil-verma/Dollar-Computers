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
    public partial class OrderForm : Form
    {
        //3. create a reference to the previous form
        public ProductInfoForm secondForm;

        public OrderForm()
        {
            InitializeComponent();
        }

        private void _aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderAboutBox aboutApp = new orderAboutBox();
            aboutApp.ShowDialog();
        }

        private void _printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("your selection will start printing", "About",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void _backButton_Click(object sender, EventArgs e)
        {
            secondForm.Show();
            this.Hide();
        }

        private void _cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _finishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks  for  doing  business  with  us  and  your  order  will  be  processed  in  7 - 10  business  days", "About",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
            this.Close();
        }
    }
}
