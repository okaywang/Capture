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
using System.IO; 
using PcapDotNet.Packets.Ethernet;

namespace Capture
{
    public partial class FrmPacketsAll : Form
    {
        private PacketMonitor _monitor;
        private IPresenter<PacketSummary> _presenter;
        private Dictionary<string, CheckBox> _dictCheckBoxes;
        private Dictionary<string, string> _dictIpName = new Dictionary<string, string>();
        public FrmPacketsAll(LivePacketDevice device)
        {
            InitializeComponent();

            _presenter = new DataGridViewPresenter<PacketSummary>();
            var presenterControl = _presenter as Control;
            presenterControl.Dock = DockStyle.Fill;
            this.pnlBody.Controls.Add(presenterControl);

            _monitor = new PacketMonitor(device, PacketCommunicatorMode.Capture);
            _monitor.PacketRecieved += PacketRecievedHanlder;

            //_presenter = Program.kernel.Get<IPresenter>();
            //_presenter.AppendTo(this.Controls);

            //this.Resize += _presenter.ResizePresenter;

            menuStop.Enabled = btnStop.Enabled = false;

          

            _dictIpName.Add("101.226.103.106", "QQ");
            _dictIpName.Add("116.211.115.228", "优酷");
            _dictIpName.Add("180.96.12.1", "京东");
            _dictIpName.Add("61.191.187.241", "淘宝");
            _dictIpName.Add("61.191.187.240", "淘宝");               
            _dictIpName.Add("61.152.103.213", "游戏");
            _dictIpName.Add("210.77.149.28", "炒股");

        }

        public bool CaptureJavascript { get; set; }

        public bool CaptureCss { get; set; }

        public bool CaptureImage { get; set; }

        public bool CaptureAjax { get; set; }

        private void PacketRecievedHanlder(Packet packet)
        {
            if (packet.Ethernet.IpV4 != null)
            {
                if (_dictIpName.ContainsKey(packet.Ethernet.IpV4.Source.ToString()) || _dictIpName.ContainsKey(packet.Ethernet.IpV4.Destination.ToString()))
                {
                    var summary = new PacketSummary();
                    summary.Timestamp = DateTime.Now.ToLongTimeString();
                    summary.Source = packet.Ethernet.IpV4.Source.ToString();
                    summary.Destination = packet.Ethernet.IpV4.Destination.ToString();
                    summary.Length = packet.Length;
                    summary.Type = _dictIpName.ContainsKey(packet.Ethernet.IpV4.Source.ToString()) ? _dictIpName[packet.Ethernet.IpV4.Source.ToString()] : _dictIpName[packet.Ethernet.IpV4.Destination.ToString()];
                    //summary.Memo = packet.ToString();

                    (_presenter as Control).InvokeIfNeeded<PacketSummary>(_presenter.AddLine, summary);
                }
            }
        }

        //private void PacketRecievedHanlder(Packet packet)
        //{
        //    PacketSummary summary = null;
        //    switch (packet.Ethernet.EtherType)
        //    {
        //        case EthernetType.Arp:
        //            summary = ArpReader.Instance.Read(packet);
        //            break;
        //        case EthernetType.IpV4:
        //            summary = IpReader.Instance.Read(packet);
        //            break;
        //        default:
        //            break;
        //    }

        //    if (summary != null)
        //    {
        //        CheckBox control;
        //        this._dictCheckBoxes.TryGetValue(summary.Protocal, out control);
        //        if (control == null || control.Checked)
        //        {
        //            (_presenter as Control).InvokeIfNeeded<PacketSummary>(_presenter.AddLine, summary);
        //        }
        //    }
        //}

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
            menuStart.Enabled = btnStart.Enabled = false;
            menuStop.Enabled = btnStop.Enabled = true;
        }

        private void menuStop_Click(object sender, EventArgs e)
        {
            _monitor.Stop();
            menuStop.Enabled = btnStop.Enabled = false;
            menuStart.Enabled = btnStart.Enabled = true;
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            new FrmAbout().ShowDialog();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            //var frmSetting = new FrmSetting(this);
            //frmSetting.ShowDialog();
        }

        private void menuExport_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog() { Filter = ".txt|.txt", FileName = DateTime.Now.ToString("yyyyMMddhhmmss") })
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var data = _presenter.GetData();
                    var text = data.Aggregate<PacketSummary, string>("", (str, item) => str + item.ToString() + Environment.NewLine);
                    File.WriteAllText(dialog.FileName, text);
                }
            }
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            var control = sender as CheckBox;
            var protocal = control.Text;
            this._presenter.ShowProtocal(protocal, control.Checked);
        }

    }
}
