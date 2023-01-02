using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFATCC
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
            EffectTime();
        }

        private void EffectTime()
        {
            splashTimer.Interval = 100;
            splashTimer.Tick += new EventHandler(splashTimer_Tick);
            splashTimer.Enabled = true;
            this.Opacity = 1;
        }

        private bool Effect = true;
        private void splashTimer_Tick(object sender, EventArgs e)
        {
            if (Effect)
            {
                this.Opacity -= 0.02D;
            }

            if (this.Opacity == 0)
            {
                Effect = false;
                splashTimer.Enabled = false;
                frmLogin loginFrm = new frmLogin();
                loginFrm.Show();
                this.Hide();
            }
        }
    }
}
