using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capture
{
    public interface IPresenter<T> where T : PacketSummary
    {
        void ShowProtocal(string protocal,bool visible);
        void HideColumn(string columnName);
        void AddLine(T summary);
        void Clear();

        List<T> GetData();
    }
}
