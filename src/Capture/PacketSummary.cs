using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capture
{
    public class PacketSummary
    {
        public DateTime Timestamp { get; set; }

        public string Source { get; set; }

        public string Destination { get; set; }

        public string Protocal { get; set; }
    }
}
