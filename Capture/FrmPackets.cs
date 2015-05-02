using PcapDotNet.Core;
using PcapDotNet.Packets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capture.Extensions;
using PcapDotNet.Packets.Http;

namespace Capture
{
    public partial class FrmPackets : Form
    {
        private PacketMonitor _monitor;
        private IPresenter _presenter;
        public FrmPackets(LivePacketDevice device)
        {
            InitializeComponent();

            _presenter = new DataGridViewPresenter();
            var presenterControl = _presenter as Control;
            presenterControl.Dock = DockStyle.Fill;
            this.pnlBody.Controls.Add(presenterControl);

            _monitor = new PacketMonitor(device, PacketCommunicatorMode.Capture);
            _monitor.PacketRecieved += PacketRecievedHanlder;

            //_presenter = Program.kernel.Get<IPresenter>();
            //_presenter.AppendTo(this.Controls);

            //this.Resize += _presenter.ResizePresenter;

            btnStop.Enabled = false;
        }

        private void PacketRecievedHanlder(Packet packet)
        {
            //throw new NotImplementedException();
            if (packet.Ethernet.IpV4 == null)
            {
                return;
            }

            if (packet.Ethernet.IpV4.Tcp == null)
            {
                return;
            }
            if (packet.Ethernet.IpV4.Tcp.DestinationPort == 443)
            {

            }

            if (packet.Ethernet.IpV4.Tcp.Http == null)
            {
                return;
            }
            if (packet.Ethernet.IpV4.Tcp.Http.Version == null)
            {
                return;
            }
            if (packet.Ethernet.IpV4.Tcp.Http.IsRequest == false)
            {
                return;
            }
            var httpDatagram = packet.Ethernet.IpV4.Tcp.Http as HttpRequestDatagram;
            var summary = new HttpPacketSummary();
            summary.Timestamp = DateTime.Now;
            summary.Source = packet.Ethernet.IpV4.Source.ToString();
            summary.Destination = packet.Ethernet.IpV4.Destination.ToString();

            summary.HttpMethod = httpDatagram.Method.KnownMethod.ToString();
            summary.WebsiteName = httpDatagram.Header["host"].ValueString;
            summary.Url = httpDatagram.Uri.ToString();


            (_presenter as Control).InvokeIfNeeded<HttpPacketSummary>(_presenter.AddLine, summary);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _monitor.Start();

            menuStart.Enabled = btnStart.Enabled = false;
            menuStop.Enabled = btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _monitor.Stop();
            menuStop.Enabled = btnStop.Enabled = false;
            menuStart.Enabled = btnStart.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _presenter.Clear();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuClear_Click(object sender, EventArgs e)
        {
            _presenter.Clear();
        }

        private void menuStart_Click(object sender, EventArgs e)
        {
            _monitor.Start();
        }

        private void menuStop_Click(object sender, EventArgs e)
        {
            _monitor.Stop();
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            new FrmAbout().ShowDialog();
        }

    }
}
