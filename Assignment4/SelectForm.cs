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
    public partial class SelectForm : Form
    {
        //3. create a reference to the previous form
        public StartForm previousForm;

        public SelectForm()
        {
            InitializeComponent();
        }

        private void _productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _storingValue()
        {

        }

        private void _cancelButton_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _nextButton_Click(object sender, EventArgs e)
        {
            //1. intantiate 
            ProductInfoForm productInfoForm = new ProductInfoForm();

            //2. pass a reference
            productInfoForm.firstForm = this;

            productInfoForm.Show();
            this.Hide();
        }

    }
}
