using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacketAnalyst
{
    public class Size
    {
        public Size(int w,int h)
        {
            this.Width = w;
            this.Height = h;
        }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
