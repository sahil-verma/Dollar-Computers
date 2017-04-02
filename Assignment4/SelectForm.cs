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

        private void _storingValue()
        {

        }

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            else
            {
                selectionTextBox.Text = productsDataGridView.SelectedRows.ToString();
            }

            int index = e.RowIndex;
            productsDataGridView.Rows[index].Selected = true;
            nextButton.Enabled = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm productInfoForm = new ProductInfoForm();

            productInfoForm.firstForm = this;
            productInfoForm.Show();
            this.Close();
        }
    }
}
