using Capture;
using PcapDotNet.Packets.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capture.ProtocalReader
{
    public class HttpReader : ReaderBase
    {
        public readonly static HttpReader Instance = new HttpReader();
        private HttpReader() { }

        public override PacketSummary Read(PcapDotNet.Packets.Packet packet)
        { 
            var ps = base.Read(packet);

            ps.Protocal = "HTTP";
            ps.Source = packet.Ethernet.IpV4.Source.ToString();
            ps.Destination = packet.Ethernet.IpV4.Destination.ToString();

            var datagram = packet.Ethernet.IpV4.Tcp;
            ps.Memo = string.Format("src port:{0,-6}\t,dst port:{1,-6}\t,{2}", datagram.SourcePort, datagram.DestinationPort, datagram.Http.IsRequest ? "request" : "response");

            return ps;
        }
    }
}
