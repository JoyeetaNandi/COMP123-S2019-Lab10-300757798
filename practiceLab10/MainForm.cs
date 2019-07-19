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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

       


        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Hide();
            Program.Forms[AllForm.END_FORM].Show();            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
