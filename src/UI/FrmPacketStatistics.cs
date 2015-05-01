using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PcapDotNet.Core;
using PacketAnalyst.UI;
using PacketAnalyst.Utility;

namespace PacketAnalyst
{
    public partial class FrmPacketStatistics : Form
    {
        PacketMonitor _monitor;
        public FrmPacketStatistics()
        {
            InitializeComponent();

            var device = LivePacketDevice.AllLocalMachine.FirstOrDefault();
            _monitor = new PacketMonitor(device, PacketCommunicatorMode.Statistics);
            _monitor.StatisticsRecieved += DisplayStatistics;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _monitor.StatisticsTraffic();

            this.btnStart.Enabled = false;
        }
        private static DateTime _lastTimestamp;
        private void DisplayStatistics(PacketSampleStatistics statistics)
        {
            DateTime currentTimestamp = statistics.Timestamp;

            DateTime previousTimestamp = _lastTimestamp;

            _lastTimestamp = currentTimestamp;

            if (previousTimestamp == DateTime.MinValue)
                return;

            double delayInSeconds = (currentTimestamp - previousTimestamp).TotalSeconds;

            int bitsPerSecond = (Int32)(statistics.AcceptedBytes / delayInSeconds);

            int packetsPerSecond = (Int32)(statistics.AcceptedPackets / delayInSeconds);

            var line = string.Format("{0}\t BPS:{1,-8}\tPPS:{2,-8}", statistics.Timestamp, bitsPerSecond, packetsPerSecond);

            this.InvokeIfNeeded((str) => { this.lstStatistics.Items.Add(str); this.lstStatistics.SelectedIndex = this.lstStatistics.Items.Count - 1; }, line);
        } 
    }
}
