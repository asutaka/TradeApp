using System;
using System.Windows.Forms;
using TheLast.Common;
using TheLast.GUI;

namespace TradeApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            0.InitBasicJson();
            0.InitAdvanceJson();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
