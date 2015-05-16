using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capture
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            //AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);



            var frmDevices = new FrmDevices();
            var dialogResult = frmDevices.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                var device = frmDevices.SelectedDevice;
                //Application.Run(new FrmPacketsHttp(device));
                Application.Run(new FrmPacketsAll(device));
            }
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            LogHelper.Log(e.ExceptionObject as Exception);
            new FrmError().ShowDialog();
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            LogHelper.Log(e.Exception);
            new FrmError().ShowDialog();
        }
    }
}
