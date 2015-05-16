using Capture;
using PcapDotNet.Packets.IpV4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capture.ProtocalReader
{
    public class IpReader : ReaderBase
    {
        public readonly static IpReader Instance = new IpReader();
        private IpReader() { }

        public override PacketSummary Read(PcapDotNet.Packets.Packet packet)
        {
            PacketSummary summary = null;
            switch (packet.Ethernet.IpV4.Protocol)
            {
                case IpV4Protocol.InternetControlMessageProtocol:
                    summary = ICMPReader.Instance.Read(packet);
                    break;
                case IpV4Protocol.Tcp:
                    summary = TcpReader.Instance.Read(packet);
                    break;
                case IpV4Protocol.Udp:
                    summary = UdpReader.Instance.Read(packet);
                    break;
                default:
                    break;
            }
            return summary;
        }
    }
}
