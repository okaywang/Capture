using Capture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capture.ProtocalReader
{
    public class TcpReader : ReaderBase
    {
        public readonly static TcpReader Instance = new TcpReader();
        private TcpReader() { }

        public override PacketSummary Read(PcapDotNet.Packets.Packet packet)
        {
            if (packet.Ethernet.IpV4.Tcp.SourcePort == 80 || packet.Ethernet.IpV4.Tcp.DestinationPort == 80)
            {
                return HttpReader.Instance.Read(packet);
            }

            var ps = base.Read(packet);

            ps.Protocal = "TCP";
            ps.Source = packet.Ethernet.IpV4.Source.ToString();
            ps.Destination = packet.Ethernet.IpV4.Destination.ToString();

            var datagram = packet.Ethernet.IpV4.Tcp;
            ps.Memo = string.Format("src port:{0,-6}\t,dst port:{1,-6}\t,seq No:{2,-6}\t,ack No:{3,-6}", datagram.SourcePort, datagram.DestinationPort, datagram.SequenceNumber, datagram.AcknowledgmentNumber);

            return ps;
        }
    }
}
