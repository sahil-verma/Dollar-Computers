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

        private void _productsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productsDataGridView.SelectedCells.Count > 0)
            {
                selectionTextBox.Text = productsDataGridView.Rows[e.RowIndex].Cells[2].FormattedValue.ToString() + " " + productsDataGridView.Rows[e.RowIndex].Cells[3].FormattedValue.ToString() + " Priced at: $" + productsDataGridView.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            }
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

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

        }

        private void productsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
