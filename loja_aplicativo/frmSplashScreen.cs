using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loja_aplicativo
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Width = this.BackgroundImage.Width;
            this.Height = this.BackgroundImage.Height;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbCarregar.Value < 100)
            {
                pbCarregar.Value = pbCarregar.Value + 2;

            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;
                this.Close();
            }
        }
    }
}
