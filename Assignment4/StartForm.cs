///<summary>
///	Name of Programme - Dollar Computers
///	Name - Sahil Verma
///	Student Number - 200335300
///	Date Last Modified or app creation date - April2 , 2017
///	Short revision history - functionality added, structured, gui, splash form
///	Description - the app calculates the cost for the product as per the selection
/// </summary>
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
    public partial class StartForm : Form
    {
        //constructor
        public StartForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// event handler for openeing a new form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _newOrderButton_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm();

            selectForm.previousForm = this;
            selectForm.Show();
            this.Hide();
        }

        /// <summary>
        /// event handler for opening the saved form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _savedOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.Show();
        }

        /// <summary>
        /// event handler to exit the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
