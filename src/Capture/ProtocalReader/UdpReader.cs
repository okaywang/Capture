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
            var ps = base.Read(packet);
            ps.Protocal = "upd";
            ps.Source = packet.Ethernet.IpV4.Source.ToString();
            ps.Destination = packet.Ethernet.IpV4.Destination.ToString();
            ps.Protocal = packet.Ethernet.IpV4.Protocol.ToString();
            var datagram = packet.Ethernet.IpV4.Udp;
            ps.Memo = string.Format("src port:{0,-6}\t,dst port:{1,-6}", datagram.SourcePort, datagram.DestinationPort);

            return ps;
        }
    }
}
