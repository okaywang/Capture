using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacketAnalyst.ProtocalReader
{
    public class ArpReader : ReaderBase
    {
        public readonly static ArpReader Instance = new ArpReader();
        private ArpReader() { }

        public override PacketSummary Read(PcapDotNet.Packets.Packet packet)
        {
            var ps = base.Read(packet);
            var arpDatagram = packet.Ethernet.Arp;
            if (arpDatagram.Operation == PcapDotNet.Packets.Arp.ArpOperation.Request)
            {
                ps.Memo = string.Format("request:who has {0},tell {1}", arpDatagram.TargetProtocolIpV4Address, arpDatagram.SenderProtocolIpV4Address);
            }
            else if (arpDatagram.Operation == PcapDotNet.Packets.Arp.ArpOperation.Reply)
            {
                ps.Memo = string.Format("reply:mac address of {0} is {1}", arpDatagram.SenderProtocolIpV4Address, packet.Ethernet.Source);
            }
            return ps;
        }
    }
}
