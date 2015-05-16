using Capture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capture.ProtocalReader
{
    public class UdpReader : ReaderBase
    {
        public readonly static UdpReader Instance = new UdpReader();
        private UdpReader() { }

        public override PacketSummary Read(PcapDotNet.Packets.Packet packet)
        {
            var udp = packet.Ethernet.IpV4.Udp;
            if (udp.SourcePort == 53 || udp.DestinationPort == 53)
            {
                return DnsReader.Instance.Read(packet);
            }

            if (udp.SourcePort == 8000 || udp.DestinationPort == 8000)
            {
                return QICQReader.Instance.Read(packet);
            }

            var ps = base.Read(packet);
            ps.Protocal = "UDP";
            ps.Source = packet.Ethernet.IpV4.Source.ToString();
            ps.Destination = packet.Ethernet.IpV4.Destination.ToString();
            var datagram = packet.Ethernet.IpV4.Udp;
            ps.Memo = string.Format("src port:{0,-6}\t,dst port:{1,-6}", datagram.SourcePort, datagram.DestinationPort);

            return ps;
        }
    }
}
