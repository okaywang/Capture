using Capture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capture.ProtocalReader
{
    public abstract class ReaderBase : IProtocalReader
    { 
        public virtual PacketSummary Read(PcapDotNet.Packets.Packet packet)
        {
            var ps = new PacketSummary();
            ps.Timestamp = DateTime.Now.ToLongTimeString();
            ps.Source = packet.Ethernet.Source.ToString();
            ps.Destination = packet.Ethernet.Destination.ToString();
            ps.Length = packet.Length;
            ps.Protocal = packet.Ethernet.EtherType.ToString();
            ps.Memo = packet.ToString();
            return ps;
        }
    }
}
