using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10_300757798
{
    public partial class StartForm : Form
    {  
        
        public StartForm()
        {
            InitializeComponent();
        }

        private void startForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;

        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            Program.Forms[AllForm.MAIN_FORM].Show();
            Hide();
        }
    }
}
