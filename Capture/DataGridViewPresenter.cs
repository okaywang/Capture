using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capture
{
    public class DataGridViewPresenter : DataGridView, IPresenter
    {
        public DataGridViewPresenter()
        {
            this.AllowUserToResizeRows = false;
            this.ReadOnly = true;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            var properties = typeof(HttpPacketSummary).GetProperties();
            foreach (var item in properties)
            {
                this.Columns.Add(item.Name, item.Name);
            }
        }
        public void AddLine(HttpPacketSummary pd)
        {
            if (pd == null)
            {
                return;
            }
            var row = (DataGridViewRow)this.Rows[0].Clone();

            var properties = pd.GetType().GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                row.Cells[i].Value = properties[i].GetValue(pd, null);
            }

            this.Rows.Add(row);
        }

        public void Clear()
        {
            this.Rows.Clear();
        }
    }
}
