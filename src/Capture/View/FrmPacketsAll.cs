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
using Capture.ProtocalReader;
using PcapDotNet.Packets.Ethernet;

namespace Capture
{
    public partial class FrmPacketsAll : Form
    {
        private PacketMonitor _monitor;
        private IPresenter<PacketSummary> _presenter;
        private Dictionary<string, CheckBox> _dictCheckBoxes;
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

            this.CaptureImage = false;
            this.CaptureCss = false;
            this.CaptureJavascript = false;
            this.CaptureAjax = false;

            _dictCheckBoxes = new Dictionary<string, CheckBox>();
            foreach (var item in this.pnlCheckBoxes.Controls)
            {
                var control = item as CheckBox;
                this._dictCheckBoxes.Add(control.Text, control);
            }
        }

        public bool CaptureJavascript { get; set; }

        public bool CaptureCss { get; set; }

        public bool CaptureImage { get; set; }

        public bool CaptureAjax { get; set; }

        private void PacketRecievedHanlder(Packet packet)
        {
            PacketSummary summary = null;
            switch (packet.Ethernet.EtherType)
            {
                case EthernetType.Arp:
                    summary = ArpReader.Instance.Read(packet);
                    break;
                case EthernetType.IpV4:
                    summary = IpReader.Instance.Read(packet);
                    break;
                default:
                    break;
            }

            if (summary != null)
            {
                CheckBox control;
                this._dictCheckBoxes.TryGetValue(summary.Protocal, out control);
                if (control == null || control.Checked)
                {
                    (_presenter as Control).InvokeIfNeeded<PacketSummary>(_presenter.AddLine, summary);
                }
            }
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
