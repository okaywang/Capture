using Capture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capture.ProtocalReader
{
    public class ICMPReader:ReaderBase
    {
        public readonly static ICMPReader Instance = new ICMPReader();
        private ICMPReader() { }

        public override PacketSummary Read(PcapDotNet.Packets.Packet packet)
        {
            var ps = base.Read(packet);

            ps.Protocal = "ICMP";

            ps.Source = packet.Ethernet.IpV4.Source.ToString();
            ps.Destination = packet.Ethernet.IpV4.Destination.ToString();

            var datagram =packet.Ethernet.IpV4.Icmp;
            if (datagram.MessageType == PcapDotNet.Packets.Icmp.IcmpMessageType.Echo)
            {
                ps.Memo = string.Format("request,code={0},ttl={1}",datagram.Code,packet.Ethernet.IpV4.Ttl);
            }
            else if (datagram.MessageType == PcapDotNet.Packets.Icmp.IcmpMessageType.EchoReply)
            {
                ps.Memo = string.Format("reply,code={0},ttl={1}", datagram.Code, packet.Ethernet.IpV4.Ttl);
            }
            else if (datagram.MessageType == PcapDotNet.Packets.Icmp.IcmpMessageType.TimeExceeded)
            {
                ps.Memo = string.Format("time exceeded,code={0},ttl={1}", datagram.Code, packet.Ethernet.IpV4.Ttl);
            }
            else if (datagram.MessageType == PcapDotNet.Packets.Icmp.IcmpMessageType.DestinationUnreachable)
            {
                ps.Memo = string.Format("destination unreachable,code={0},ttl={1}", datagram.Code, packet.Ethernet.IpV4.Ttl);
            }
            else
            {
                ps.Memo = string.Empty;
            }
            return ps;
        }
    }
}
