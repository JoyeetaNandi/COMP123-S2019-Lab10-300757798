using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practiceLab10
{
    public partial class EndForm : Form
    {
        
        public EndForm()
        {
            InitializeComponent();
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            Program.Forms[AllForm.MAIN_FORM].Show();
        }

        private void EndForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
