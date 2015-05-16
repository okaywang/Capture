using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capture
{
    public class PacketSummary
    {
        [System.ComponentModel.DisplayName("时间戳")]
        public string Timestamp { get; set; }

        [System.ComponentModel.DisplayName("源Ip")]
        public string Source { get; set; }

        [System.ComponentModel.DisplayName("目的Ip")]
        public string Destination { get; set; }

        [System.ComponentModel.DisplayName("协议")]
        public string Protocal { get; set; }

        [System.ComponentModel.DisplayName("长度")]
        public int Length { get; set; }

        [System.ComponentModel.DisplayName("备注")]
        public string Memo { get; set; }
    }
}
