using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacketAnalyst
{
    public class PacketSummary
    {
        public string Source { get; set; }
        public string Destination { get; set; }
        public string Protocal { get; set; }
        public int Length { get; set; }
        public string Memo { get; set; }
    }
}
