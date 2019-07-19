using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10_300757798
{
    public enum AllForm
    {
        START_FORM,
        END_FORM,
        MAIN_FORM
        //NUMBER_FORM
    }
    static class Program
    {
        //public static MainForm mainForm;
        //public static StartForm startForm;
        //public static EndForm endForm;
        ///// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static Dictionary<AllForm, Form> Forms;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //startForm = new StartForm();
            //endForm = new EndForm();
            //mainForm = new MainForm();
            //Application.Run(startForm);
            Forms = new Dictionary<AllForm, Form>();
            Forms.Add(AllForm.START_FORM, new StartForm());
            Forms.Add(AllForm.MAIN_FORM, new MainForm());
            Forms.Add(AllForm.END_FORM, new EndForm());
            Application.Run(Forms[AllForm.START_FORM]);

        }
    }
}
