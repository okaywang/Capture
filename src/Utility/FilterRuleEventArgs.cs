using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacketAnalyst.Utility
{
    public class FilterRuleEventArgs:EventArgs
    {
        public FilterRule Rule { get; set; }
    }
}
