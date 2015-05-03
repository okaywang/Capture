
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capture.Extensions
{
    public static class ControlExtension
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
