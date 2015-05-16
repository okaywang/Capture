using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PcapDotNet.Packets;
using Capture;

namespace Capture.ProtocalReader
{
    public interface IProtocalReader
    {
        PacketSummary Read(Packet packet);
    }
}
