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
    public partial class OrderForm : Form
    {
        //3. create a reference to the previous form
        public ProductInfoForm secondForm;
        public SelectForm firstForm;

        /// <summary>
        /// constructor
        /// </summary>
        public OrderForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this method will get the values from the stored method in select form an put them in textboxes and listbox
        /// </summary>
        public void storedValues()
        {
            conditionTextBox.Text = firstForm.stroingValues[1];
            platformTextBox.Text = firstForm.stroingValues[3];
            manufacturerTextBox.Text = firstForm.stroingValues[5];
            modelTextBox.Text = firstForm.stroingValues[6];

            componentsListBox.Items.Add(firstForm.stroingValues[8]);
            //to give space betweeen the items
            componentsListBox.Items.Add("");
            componentsListBox.Items.Add(firstForm.stroingValues[7]);
            componentsListBox.Items.Add("");
            componentsListBox.Items.Add(firstForm.stroingValues[10]);
            componentsListBox.Items.Add("");
            componentsListBox.Items.Add(firstForm.stroingValues[13]);
            componentsListBox.Items.Add("");
            componentsListBox.Items.Add(firstForm.stroingValues[11]);
            componentsListBox.Items.Add("");
            componentsListBox.Items.Add(firstForm.stroingValues[14]);
            componentsListBox.Items.Add("");
            componentsListBox.Items.Add(firstForm.stroingValues[9]);
            componentsListBox.Items.Add("");
            componentsListBox.Items.Add(firstForm.stroingValues[12]);
            componentsListBox.Items.Add("");
            componentsListBox.Items.Add(firstForm.stroingValues[15]);
            componentsListBox.Items.Add("");
            componentsListBox.Items.Add(firstForm.stroingValues[4]);

            priceTextBox.Text = double.Parse(firstForm.stroingValues[2]).ToString();
            taxTextBox.Text = (double.Parse(priceTextBox.Text) * 0.13).ToString();
            totalTextBox.Text = (double.Parse(priceTextBox.Text) + double.Parse(taxTextBox.Text)).ToString();
            //addding a dollar sign
            totalTextBox.Text = Double.Parse(totalTextBox.Text).ToString("C", CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// event handler for the decription of the project
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderAboutBox aboutApp = new orderAboutBox();
            aboutApp.ShowDialog();
        }

        /// <summary>
        /// event handler to print the selection deon by the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("your selection will start printing", "About",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        /// <summary>
        /// event handler to back to the productInfoForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _backButton_Click(object sender, EventArgs e)
        {
            secondForm.Show();
            this.Hide();
        }


        /// <summary>
        /// event handler to close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// event handler for giving the final selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _finishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks  for  doing  business  with  us  and  your  order  will  be  processed  in  7 - 10  business  days", "About",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
            this.Close();
        }
    }
}
