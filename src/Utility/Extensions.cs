using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PacketAnalyst.Utility
{
    public static class Extensions
    {
        public static void InvokeIfNeeded<T>(this Control ctl, Action<T> act, T args)
        {
            if (ctl.InvokeRequired)
            {
                ctl.Invoke(act, args);
            }
            else
            {
                act(args);
            }
        }
    }
}
