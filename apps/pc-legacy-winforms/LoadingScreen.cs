using System;
using System.Windows.Forms;

namespace TESTBAG
{
    public partial class LoadingScreen : Form
    {
        Timer timer;
        public LoadingScreen()
        {
            InitializeComponent();
            //Method 2. The manual way
            //this.StartPosition = FormStartPosition.Manual;
            //this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            //this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;

            timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            this.Close();
        }
    }
}
