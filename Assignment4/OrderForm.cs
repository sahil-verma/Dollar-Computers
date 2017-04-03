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

        public OrderForm()
        {
            InitializeComponent();
        }

        public void storedValues()
        {
            conditionTextBox.Text = firstForm.stroingValues[1];
            platformTextBox.Text = firstForm.stroingValues[3];
            manufacturerTextBox.Text = firstForm.stroingValues[5];
            modelTextBox.Text = firstForm.stroingValues[6];

            componentsListBox.Items.Add(firstForm.stroingValues[8]);
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
            totalTextBox.Text = Double.Parse(totalTextBox.Text).ToString("C", CultureInfo.CurrentCulture);
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
