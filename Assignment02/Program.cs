
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment02
{
    public static class Program
    {
        public static SplashForm MySplashForm;

    
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
         public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            Program.MySplashForm = new SplashForm();

            Application.Run(Program.MySplashForm);
            //Application.Run(Program.AutoCenter);
        }
    }
}
