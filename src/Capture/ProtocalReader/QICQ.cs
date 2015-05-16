using Capture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capture.ProtocalReader
{
    public class QICQReader : ReaderBase
    {
        public readonly static QICQReader Instance = new QICQReader();
        private QICQReader() { }

        public override PacketSummary Read(PcapDotNet.Packets.Packet packet)
        {
            var ps = base.Read(packet);
            ps.Protocal = "QQ";
            ps.Source = packet.Ethernet.IpV4.Source.ToString();
            ps.Destination = packet.Ethernet.IpV4.Destination.ToString();
            var udp = packet.Ethernet.IpV4.Udp;

            ps.Memo = string.Format("src port:{0,-6}\t,dst port:{1,-6},{2}", udp.SourcePort, udp.DestinationPort, udp.Dns.IsQuery ? "query" : "response");

            return ps;
        }
    }
}
