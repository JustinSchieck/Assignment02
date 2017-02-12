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

namespace Assignment02
{
    public partial class OptionsForm : Form
    {

       //Instance Variables
        private String _formLayout;
        private String _color;
         

        public OptionsForm()
        {
            InitializeComponent();
        }

        public string AutoFormLayout { get; set; }

        public String Color { get; set; }

        public SharpAutoForm PreviousForm { get; set; }

        private void _CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _AcceptButton_Click(object sender, EventArgs e)
        {
            this.PreviousForm.AutoFormLayout = this.AutoFormLayout;
            this.Close();
        }

        private void _FontButton_Click(object sender, EventArgs e)
        {
            FormFontDialog.ShowDialog();

        }

        private void _FormLayoutRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton autoFormRadioButton = sender as RadioButton;
            this.AutoFormLayout = autoFormRadioButton.Text;
            Debug.WriteLine(this.AutoFormLayout);
        }

    }
}
