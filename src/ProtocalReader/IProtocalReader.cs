using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PcapDotNet.Packets;

namespace PacketAnalyst.ProtocalReader
{
    public interface IProtocalReader
    {
        PacketSummary Read(Packet packet);
    }
}
