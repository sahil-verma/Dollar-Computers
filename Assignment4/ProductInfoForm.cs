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

            SaveFileDialog openFileDialog = new SaveFileDialog();
            openFileDialog.Filter = "Text Files | *.txt";
            openFileDialog.DefaultExt = "txt";
            
        }

        private void _anotherProductButton_Click(object sender, EventArgs e)
        {
            firstForm.Show();
            this.Hide();
        }

        private void _saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image  
            // assigned to Button2.  
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files | *.txt";
            saveFileDialog1.Title = "Save a File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.  
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog1.OpenFile();

                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        this.productIDLabel.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        this.productIDLabel.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        this.productIDLabel.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }
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
