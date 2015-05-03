using PcapDotNet.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capture
{
    public partial class FrmDevices : Form
    {
        private int _deviceIndex;
        public FrmDevices()
        {
            InitializeComponent();
        }

        private void FrmDevices_Load(object sender, EventArgs e)
        {
            var devices = LivePacketDevice.AllLocalMachine;
            for (int i = 0; i < devices.Count; i++)
            {
                var device = devices[i];
                var rb = new RadioButton();
                rb.Name = i.ToString();
                rb.AutoSize = false;
                rb.Height = 50;
                var ip = device.Addresses.FirstOrDefault(p => p.Address.Family == SocketAddressFamily.Internet);
                rb.Text = string.Format("{0}\r\n{1}\r\nIP:{2}", device.Description, device.Name, ip.ToString());
                rb.Dock = DockStyle.Top;
                rb.Padding = new Padding(20, 2, 20, 2);
                rb.Click += RadioButton_Click;
                if (i == 0)
                {
                    rb.Checked = true;
                }
                this.pnlDevices.Controls.Add(rb);
            }
        }

        public LivePacketDevice SelectedDevice
        {
            get
            {
                return LivePacketDevice.AllLocalMachine[_deviceIndex];
            }
        }

        private void RadioButton_Click(object sender, EventArgs e)
        {
            _deviceIndex = int.Parse((sender as Control).Name);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
