using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        public void storedValues()
        {
            productIDTextBox.Text = firstForm.stroingValues[0];
            conditionTextBox.Text = firstForm.stroingValues[1];
            costTextBox.Text = firstForm.stroingValues[2];
            costTextBox.Text = Double.Parse(costTextBox.Text).ToString("C", CultureInfo.CurrentCulture);
            platformTextBox.Text = firstForm.stroingValues[3];
            osTextBox.Text = firstForm.stroingValues[4];
            manufacturerTextBox.Text = firstForm.stroingValues[5];
            modelTextBox.Text = firstForm.stroingValues[6];
            memoryTextBox.Text = firstForm.stroingValues[7];
            lcdSizeTextBox.Text = firstForm.stroingValues[8];
            hddTextBox.Text = firstForm.stroingValues[9];
            cpuBrandTextBox.Text = firstForm.stroingValues[10];
            cpuNumberTextBox.Text = firstForm.stroingValues[11];
            gpuTypeTextBox.Text = firstForm.stroingValues[12];
            cpuTypeTextBox.Text = firstForm.stroingValues[13];
            cpuSpeedTextBox.Text = firstForm.stroingValues[14];
            webCamTextBox.Text = firstForm.stroingValues[15];
        }

        private void _nextButton_Click(object sender, EventArgs e)
        {
            //1. intantiate 
            OrderForm orderForm = new OrderForm();

            //2. pass a reference
            orderForm.secondForm = this;
            orderForm.firstForm = this.firstForm;
            orderForm.Show();
            this.Hide();
            orderForm.storedValues();
        }
    }
}
