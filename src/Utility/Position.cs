using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacketAnalyst
{
    public class Position
    {
        public Position(int l,int t)
        {
            this.Left = l;
            this.Top = t;
        }
        public int Left { get; set; }
        public int Top { get; set; }
    }
}
