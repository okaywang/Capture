using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacketAnalyst.ProtocalReader
{
    public abstract class ReaderBase : IProtocalReader
    { 
        public virtual PacketSummary Read(PcapDotNet.Packets.Packet packet)
        {
            var ps = new PacketSummary();
            ps.Source = packet.Ethernet.Source.ToString();
            ps.Destination = packet.Ethernet.Destination.ToString();
            ps.Length = packet.Length;
            ps.Protocal = packet.Ethernet.EtherType.ToString();
            ps.Memo = packet.ToString();
            return ps;
        }
    }
}
