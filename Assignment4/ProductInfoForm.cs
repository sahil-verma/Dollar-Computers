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
    public partial class ProductInfoForm : Form
    {
        //3. create a reference to the previous form
        public SelectForm firstForm;


        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void _anotherProductButton_Click(object sender, EventArgs e)
        {
            firstForm.Show();
            this.Hide();
        }

        private void _saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void _cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _nextButton_Click(object sender, EventArgs e)
        {
            //1. intantiate 
            OrderForm orderForm = new OrderForm();

            //2. pass a reference
            orderForm.secondForm = this;
            orderForm.Show();
            this.Hide();
        }
    }
}
