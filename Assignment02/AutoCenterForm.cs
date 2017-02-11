using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment02
{
    public partial class AutoCenterForm : Form
    {
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


        public object FormFontDialog { get; private set; }

        public AutoCenterForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void _exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Creates the form
            //AboutForm aboutForm = new AboutForm();

            //Show the about form with showDialog(a modal method to display the form)
            //aboutForm.ShowDialog();
        }

        //Check box calculations, uses private varibales for prices
        private void StereoSystem_CheckedChanged(object sender, EventArgs e)
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

        private void LeatherInt_CheckedChanged(object sender, EventArgs e)
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

        private void ComputerNav_CheckedChanged(object sender, EventArgs e)
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

        private void StandardButton_CheckedChanged(object sender, EventArgs e)
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

        private void PearlizedButton_CheckedChanged(object sender, EventArgs e)
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

        private void CustomizedDetailingButton_CheckedChanged(object sender, EventArgs e)
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

        private void CalculateButton_Click(object sender, EventArgs e)
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

        private void ClearButton_Click(object sender, EventArgs e)
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

