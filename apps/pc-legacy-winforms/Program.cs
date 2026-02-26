using System;
using System.Windows.Forms;

namespace TESTBAG
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LoadingScreen());
            frmMain mainForm = new frmMain();
            mainForm.Hide();
            Application.Run(mainForm);
        }
    }
}
