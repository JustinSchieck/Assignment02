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
/// 
namespace Assignment02
{
    public partial class OptionsForm : Form
    {

       //Instance Variables for color change and layout
        private String _formLayout;
        private String _color;
         

        public OptionsForm()
        {
            InitializeComponent();
        }

        //Getters and Setters for form layouts
        public string AutoFormLayout { get; set; }

        public String Color { get; set; }

        public SharpAutoForm PreviousForm { get; set; }


        //Closes the tools menu
        private void _CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Accepts the changes for the Tools menu
        private void _AcceptButton_Click(object sender, EventArgs e)
        {
            this.PreviousForm.AutoFormLayout = this.AutoFormLayout;
            this.Close();
        }

        //Font button for showing the font screen
        private void _FontButton_Click(object sender, EventArgs e)
        {
            FormFontDialog.ShowDialog();

        }

        //changes form layout, unfinished...
        private void _FormLayoutRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton autoFormRadioButton = sender as RadioButton;
            this.AutoFormLayout = autoFormRadioButton.Text;
            Debug.WriteLine(this.AutoFormLayout);
        }



    }
}
