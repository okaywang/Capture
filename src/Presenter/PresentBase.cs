using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PacketAnalyst.PacketPresenter
{
    public abstract class PresentBase : IPresenter
    {
        public PresentBase() : this(new Position(10, 80), new Size(800, 300)) { }

        public PresentBase(Position pos, Size size)
        {
            this.Control.Left = pos.Left;
            this.Control.Top = pos.Top;
        }

        public void ResizePresenter(object sender, EventArgs e)
        {
            this.Control.Width = this.Control.FindForm().Width - this.Control.Left * 4;
            this.Control.Height = this.Control.FindForm().Height - this.Control.Top - 50;
        }

        public void AppendTo(System.Windows.Forms.Control.ControlCollection controls)
        {
            controls.Add(Control);
        }

        public virtual void Clear()
        {
            this.Control.Text = string.Empty;
        }

        public abstract System.Windows.Forms.Control Control { get; }

        public abstract void WriteLine(PacketSummary pd);
    }
}
