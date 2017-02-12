using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Program: Sharp Auto Center
/// Name: Justin Schieck
/// StudentID: 200328630
/// App Creation Date: Feb 02, 2013
/// App Desc: Calculates the amount due from new or used car and choices.
/// </summary>
namespace Assignment02
{
    public partial class SharpAutoForm : Form
    {

        //Private Instance Variables
        private decimal _StereoSystemPrice = 500.00m;
        private decimal _LeatherIntPrice = 1502.99m;
        private decimal _ComputerNavPrice = 1241.23m;
        private decimal _StandardPrice = 0.0m;
        private decimal _PearlizedPrice = 895.72m;
        private decimal _CustomDetailingPrice = 803.97m;
        private decimal _additionalPrice;
        private decimal _basePrice;
        private decimal _subTotal;
        private decimal _taxRate = 0.13m;
        private decimal _taxes;
        private decimal _total;
        private decimal _tradeInValue;
        private decimal _amountDue;
        private string _autoFormLayout;

        //Public splashform variable.
        public SplashForm previousForm;

       

        public SharpAutoForm()
        {
            InitializeComponent();
            //sets default layout on startup
            this.AutoFormLayout = "Classic";
        }


        //get and set for the form layout
        public object FormFontDialog { get; private set; }
        public string AutoFormLayout {

            get
            {
                return this._autoFormLayout;
            }

            set
            {
                this.AutoFormLayout = value;
                Debug.WriteLine("Auto Labels Changed");
            }
                
           }



        //Check box calculations, uses private varibales for prices
        private void _StereoSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (StereoSystem.Checked)
            {
                _additionalPrice += _StereoSystemPrice;
                AdditionalPrice.Text = Convert.ToString("$" + _additionalPrice);
            }
            if (!StereoSystem.Checked)
            {
                _additionalPrice -= _StereoSystemPrice;
                AdditionalPrice.Text = Convert.ToString("$" + _additionalPrice);
            }
        }

        private void _LeatherInt_CheckedChanged(object sender, EventArgs e)
        {
            if (LeatherInt.Checked)
            {
                _additionalPrice += _LeatherIntPrice;
                AdditionalPrice.Text = Convert.ToString("$" + _additionalPrice);
            }
            if (!LeatherInt.Checked)
            {
                _additionalPrice -= _LeatherIntPrice;
                AdditionalPrice.Text = Convert.ToString("$" + _additionalPrice);
            }


        }

        private void _ComputerNav_CheckedChanged(object sender, EventArgs e)
        {
             if (ComputerNav.Checked)
            {
                _additionalPrice += _ComputerNavPrice;
                AdditionalPrice.Text = Convert.ToString("$" + _additionalPrice);
            }
            if (!ComputerNav.Checked)
            {
                _additionalPrice -= _ComputerNavPrice;
                AdditionalPrice.Text = Convert.ToString("$" + _additionalPrice);
            }
        }

        private void _StandardButton_CheckedChanged(object sender, EventArgs e)
        {
            if (StandardButton.Checked)
            {
                _additionalPrice += _StandardPrice;
                AdditionalPrice.Text = Convert.ToString("$" + _additionalPrice);
            }
            if (!StandardButton.Checked)
            {
                _additionalPrice -= _StandardPrice;
                AdditionalPrice.Text = Convert.ToString("$" + _additionalPrice);
            }
        }

        private void _PearlizedButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PearlizedButton.Checked)
            {
                _additionalPrice += _PearlizedPrice;
                AdditionalPrice.Text = Convert.ToString("$" + _additionalPrice);
            }
            if (!PearlizedButton.Checked)
            {
                _additionalPrice -= _PearlizedPrice;
                AdditionalPrice.Text = Convert.ToString("$" + _additionalPrice);
            }
        }

        private void _CustomizedDetailingButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomizedDetailingButton.Checked)
            {
                _additionalPrice += _CustomDetailingPrice;
                AdditionalPrice.Text = Convert.ToString("$" + _additionalPrice);
            }
            if (!CustomizedDetailingButton.Checked)
            {
                _additionalPrice -= _CustomDetailingPrice;
                AdditionalPrice.Text = Convert.ToString("$" + _additionalPrice);
            }
        }

        private void _CalculateButton_Click(object sender, EventArgs e)
        {
            //adds total price before tax
            _basePrice = Convert.ToDecimal(BasePriceTextBox.Text);
            _subTotal = _basePrice + _additionalPrice;
            SubtotalTextBox.Text = _subTotal.ToString("C2");

            //Calculate tax on order
            _taxes = _taxRate * _subTotal;
            SalesTaxBox.Text = _taxes.ToString("C2");

            //Calculates total and posts it
            _total = _taxes + _subTotal;
            TotalTextBox.Text = _total.ToString("C2");

            //Calculate total with trade in value
            _tradeInValue = Convert.ToDecimal(TradeTextBox.Text);
            _amountDue = _total - _tradeInValue;
            AmountDueTextBox.Text = _amountDue.ToString("C2");
            }

        // sets all textboxs and options to clear or beginning positions.
        private void _ClearButton_Click(object sender, EventArgs e)
        {
            BasePriceTextBox.Text = "";
            AdditionalPrice.Text = "";
            SubtotalTextBox.Text = "";
            SalesTaxBox.Text = "";
            TotalTextBox.Text = "";
            TradeTextBox.Text = "";
            AmountDueTextBox.Text = "";
            StereoSystem.Checked = false;
            LeatherInt.Checked = false;
            ComputerNav.Checked = false;
            StandardButton.Checked = true;
            PearlizedButton.Checked = false;
            CustomizedDetailingButton.Checked = false;
        }

        /// <summary>
        /// about form button handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Creates the form
            AboutForm aboutForm = new AboutForm();

            //Show the about form with showDialog(a modal method to display the form)
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Close event handler. asks if sure you want to close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _AutoCenterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if(result == DialogResult.OK)
            {
                this.previousForm.Close();
                
            }
            else
            {
                e.Cancel = true;
            }

        }

        /// <summary>
        /// Exit button in menu event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
                   
        }

        /// <summary>
        /// Options tool menu handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _OptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creates a dialog container for debug
            DialogResult result;

            //creates a new form - option form
            OptionsForm optionsForm = new OptionsForm();

            //sets a reference to previous form property
            optionsForm.PreviousForm = this;

            optionsForm.AutoFormLayout = this.AutoFormLayout;

            //Shows the result dialog
            result = optionsForm.ShowDialog();

            //For debugging
            Debug.WriteLine(result.ToString());
        }


    }
}

