using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capture
{
    public interface IPresenter
    {
        void ShowProtocal(string protocal,bool visible);
        void AddLine(PacketSummary summary);
        void Clear();

        List<PacketSummary> GetData();
    }
}
