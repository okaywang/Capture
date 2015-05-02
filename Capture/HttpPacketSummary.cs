using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capture
{
    public class HttpPacketSummary : PacketSummary
    {
        public string HttpMethod { get; set; }

        public string Url { get; set; }

        public string WebsiteName { get; set; }
    }
}
