using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiPlatormApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string errsmg = "";
            if (YAPI.RegisterHub("usb", ref errsmg) == YAPI.SUCCESS)
                Application.Run(new Form1());
            else
                MessageBox.Show("Init error:" + errsmg);

            Application.Run(new Form1());
        }
    }
}