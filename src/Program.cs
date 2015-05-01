using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Ninject;
using PacketAnalyst.PacketPresenter;
using PacketAnalyst.UI;
using PacketAnalyst.DataAccess;
using PacketAnalyst.Utility;
using PcapDotNet.Packets;
using PcapDotNet.Packets.Ethernet;
using System.Text;

namespace PacketAnalyst
{
    static class Program
    {
        public static IKernel kernel = new StandardKernel(new MyNinjectModule());

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new FrmFilterSettings());
            //return;
            var frmMode = new FrmMode();
            var dialogResult = frmMode.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                Application.Run(new FrmPacketGrap());
            }
            else if (dialogResult == DialogResult.Yes)
            {
                Application.Run(new FrmPacketStatistics());
            }
            else
            {
                Application.Exit();
            }
        }

    }
}
