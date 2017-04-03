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
        public string[] stroingValues = new string[16];
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

        public void _storingValue()
        {
            int rowindex = productsDataGridView.CurrentCell.RowIndex;

            stroingValues[0] = productsDataGridView.Rows[rowindex].Cells[0].Value.ToString();
            stroingValues[1] = productsDataGridView.Rows[rowindex].Cells[14].Value.ToString();
            stroingValues[2] = productsDataGridView.Rows[rowindex].Cells[1].Value.ToString();
            stroingValues[3] = productsDataGridView.Rows[rowindex].Cells[16].Value.ToString();
            stroingValues[4] = productsDataGridView.Rows[rowindex].Cells[15].Value.ToString();
            stroingValues[5] = productsDataGridView.Rows[rowindex].Cells[2].Value.ToString();
            stroingValues[6] = productsDataGridView.Rows[rowindex].Cells[3].Value.ToString();
            stroingValues[7] = productsDataGridView.Rows[rowindex].Cells[5].Value.ToString();
            stroingValues[8] = productsDataGridView.Rows[rowindex].Cells[7].Value.ToString();
            stroingValues[9] = productsDataGridView.Rows[rowindex].Cells[17].Value.ToString();
            stroingValues[10] = productsDataGridView.Rows[rowindex].Cells[10].Value.ToString();
            stroingValues[11] = productsDataGridView.Rows[rowindex].Cells[13].Value.ToString();
            stroingValues[12] = productsDataGridView.Rows[rowindex].Cells[19].Value.ToString();
            stroingValues[13] = productsDataGridView.Rows[rowindex].Cells[11].Value.ToString();
            stroingValues[14] = productsDataGridView.Rows[rowindex].Cells[12].Value.ToString();
            stroingValues[15] = productsDataGridView.Rows[rowindex].Cells[30].Value.ToString();
        }
        private void _cancelButton_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

        }

        private void _nextButton_Click(object sender, EventArgs e)
        {
            //1. intantiate 
            ProductInfoForm productInfoForm = new ProductInfoForm();

            //2. pass a reference
            productInfoForm.firstForm = this;
            _storingValue();

            productInfoForm.Show();
            this.Hide();
            productInfoForm.storedValues();
        }
    }
}
