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

        public override string ToString()
        {
            return string.Format("时间：{0},目的Ip：{1}，源Ip：{2}，网站：{3}，url：{4}", this.Timestamp, this.Destination, this.Source, this.WebsiteName, this.Url);
        }
    }


}
