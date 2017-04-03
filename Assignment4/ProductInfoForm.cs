using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
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

        //constructor
        public ProductInfoForm()
        {
            InitializeComponent();

        }

        /// <summary>
        /// event handler for reading the file and inserting the saved data into it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _readFile(Object sender, EventArgs e)
        {

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog.FileName);

                // read the file and insert data into the productInfoForm
                for (int i = 0; i < firstForm.stroingValues.Length; i++)
                {
                    firstForm.stroingValues[i] = sr.ReadLine();
                }

                // fill data to form
                storedValues();

                sr.Close();
            }

            openFileDialog.Filter = "Text Files|*.txt";
            openFileDialog.DefaultExt = "txt";

        }

        /// <summary>
        /// event handler to get back to select form to choose other product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _anotherProductButton_Click(object sender, EventArgs e)
        {
            firstForm.Show();
            this.Hide();
        }

        /// <summary>
        /// event handler to save the file and its value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Saves the Image via a FileStream created by the OpenFile method.  
                StreamWriter fs = new StreamWriter(saveFileDialog.FileName);

                // write to the file 
                for (int i = 0; i < firstForm.stroingValues.Length; i++)
                {
                     fs.WriteLine(firstForm.stroingValues[i]);
                }

                fs.Close();
            }
        }

        /// <summary>
        /// event handler for closing the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// this method will get the values from the stored values in select form and put them in textboxes
        /// </summary>
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

        /// <summary>
        /// event handler to go to the next form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
