using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capture
{
    public class HttpPacketSummary : PacketSummary
    {
        [System.ComponentModel.DisplayName("http方法")]
        public string HttpMethod { get; set; }

        [System.ComponentModel.DisplayName("Url")]
        public string Url { get; set; }

        [System.ComponentModel.DisplayName("网站名")]
        public string WebsiteName { get; set; }

        public override string ToString()
        {
            return string.Format("时间：{0},目的Ip：{1}，源Ip：{2}，网站：{3}，url：{4}", this.Timestamp, this.Destination, this.Source, this.WebsiteName, this.Url);
        }
    } 
}
