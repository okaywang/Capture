using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PcapDotNet.Packets;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;
using PcapDotNet.Core;
using PacketAnalyst.PacketPresenter;
using Ninject;
using PacketAnalyst.UI;
using PacketAnalyst.Utility;
using PacketAnalyst.ProtocalReader;

namespace PacketAnalyst
{
    public partial class FrmPacketGrap : Form
    {
        private IPresenter _presenter;
        PacketMonitor _monitor;
          
        public FrmPacketGrap()
        {
            InitializeComponent();

            var device = LivePacketDevice.AllLocalMachine.FirstOrDefault();
            _monitor = new PacketMonitor(device, PacketCommunicatorMode.Capture);
            _monitor.PacketRecieved += DisplayPacket;

            _presenter = Program.kernel.Get<IPresenter>();
            _presenter.AppendTo(this.Controls);

            this.Resize += _presenter.ResizePresenter;
        } 

        private void btnTest_Click(object sender, EventArgs e)
        { 
        }

        private void Form1_Load(object sender, EventArgs e)
        {  
            Control.CheckForIllegalCrossThreadCalls = false;
            _presenter.ResizePresenter(null, null);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _presenter.Clear();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var filter = string.Empty;
            if (this.lblFilterRule.Text != string.Empty)
            {
                filter += this.lblFilterRule.Text; 
            }
            _monitor.SetFilter(filter);
            _monitor.GrabPacket();

            this.btnStart.Enabled = false;
            this.btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _monitor.StopGrab();
            this.btnStop.Enabled = false;
        }

        private void DisplayPacket(Packet packet)
        {
            IpV4Datagram ip = packet.Ethernet.IpV4; 
            PacketSummary digest = null;

            #region switch ethertype
            switch (packet.Ethernet.EtherType)
            { 
                case PcapDotNet.Packets.Ethernet.EthernetType.Arp:
                    digest = ArpReader.Instance.Read(packet);
                    break; 
                case PcapDotNet.Packets.Ethernet.EthernetType.IpV4:
                    digest = GetDigest_IPV4(packet);
                    break; 
                default:
                    break;
            }
            #endregion
            _presenter.WriteLine(digest);
            this.Refresh();
        }

        private PacketSummary GetDigest_IPV4(Packet packet)
        {
            PacketSummary digest = null;
            #region in the payload of IPV4
            switch (packet.Ethernet.IpV4.Protocol)
            { 
                case IpV4Protocol.InternetControlMessageProtocol:
                    digest = ICMPReader.Instance.Read(packet);
                    break; 
                case IpV4Protocol.Tcp:
                    digest = TcpReader.Instance.Read(packet);
                    break; 
                case IpV4Protocol.Udp:
                    digest = UdpReader.Instance.Read(packet);
                    break; 
                default:
                    break;
            }
            #endregion
            return digest;
        }
          
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._monitor.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnRuleSet_Click(object sender, EventArgs e)
        {
            var frmFilter =new FrmFilterSettings();
            frmFilter.FilterRuleChanged += FilterRuleChangedHandler;
            var dr = frmFilter.ShowDialog();
        }

        private void FilterRuleChangedHandler(object sender,FilterRuleEventArgs e)
        {
            this.lblFilterRule.Text = e.Rule.Value;
        }
    }
}
