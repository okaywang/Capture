using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PacketAnalyst.Utility;

namespace PacketAnalyst.DataAccess
{
    interface IPersistence
    {
        void CreateRule(FilterRule rule);
        void DeleteRule(int id);
        FilterRule[] GetAllRules();
    }
}
