using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PacketAnalyst.PacketPresenter
{
    class ListBoxPresenter : PresentBase
    {
        private ListBox _listBox = new ListBox();

        public ListBoxPresenter():base()
        {

        }

        public ListBoxPresenter(Position pos, Size size) : base(pos, size) { }

        public override System.Windows.Forms.Control Control
        {
            get { return _listBox; }
        }

        public override void WriteLine(PacketSummary pd)
        {
            if (pd == null)
            {
                return;
            }

            var item = string.Empty;
            var properties = pd.GetType().GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                item += properties[i].GetValue(pd, null) + "\t";
            } 
            this._listBox.Items.Add(item);
        }

        public override void Clear()
        {
            _listBox.Items.Clear();
        }
    }
}
