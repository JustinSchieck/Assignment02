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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            SharpAutoForm autoCenterForm = new SharpAutoForm();
            autoCenterForm.previousForm = this;

            this.SplashFormTimer.Enabled = false;
            autoCenterForm.Show();
            this.Hide();
            
        }
    }
}
