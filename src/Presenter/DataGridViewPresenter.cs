using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PacketAnalyst.Utility;

namespace PacketAnalyst.PacketPresenter
{
    class DataGridViewPresenter : PresentBase
    {
        private DataGridView _dgv = new DataGridView();

        public DataGridViewPresenter():base()
        {

        }

        public DataGridViewPresenter(Position pos, Size size) : base(pos, size)
        {
           _dgv.AllowUserToResizeRows = false;
           _dgv.ReadOnly = true;
           _dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           _dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            var properties = typeof(PacketSummary).GetProperties();
            foreach (var item in properties)
            {
                this._dgv.Columns.Add(item.Name, item.Name);
            } 
        }

        public override System.Windows.Forms.Control Control
        {
            get { return _dgv; }
        }

        public override void WriteLine(PacketSummary pd)
        {
            _dgv.InvokeIfNeeded(AddLine,pd);
        } 

        public void AddLine(PacketSummary pd)
        {
            if (pd == null)
            {
                return;
            }

            var row = (DataGridViewRow)this._dgv.Rows[0].Clone();

            var properties = pd.GetType().GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                row.Cells[i].Value = properties[i].GetValue(pd, null);
            }

            _dgv.Rows.Add(row); 
        }


        public override void Clear()
        {
            _dgv.Rows.Clear();
        }
    }
}
