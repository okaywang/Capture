using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PacketAnalyst.PacketPresenter
{
    public  interface IPresenter
    {
        Control Control { get; }
        void AppendTo(System.Windows.Forms.Control.ControlCollection controlCollection);
        void WriteLine(PacketSummary pd);
        void Clear();

        void ResizePresenter(object sender, EventArgs e);
    }
}
