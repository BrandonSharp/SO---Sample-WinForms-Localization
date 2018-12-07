using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("de-DE");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de-DE");

            Application.Run(new Form1());
        }
    }
}
