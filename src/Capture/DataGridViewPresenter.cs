using System;
using System.Collections.Generic;
using System.Data;
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

            var properties = typeof(PacketSummary).GetProperties();
            foreach (var item in properties)
            {
                this.Columns.Add(item.Name, item.Name);
            }

            //this.Columns.Add("time", "上网时间");
            //this.Columns.Add("destIp", "目的ip");
            //this.Columns.Add("srcIp", "源ip");
            //this.Columns.Add("host", "网站名");
            //this.Columns.Add("url", "Url");
        }

        public void ShowProtocal(string protocal,bool visible)
        {
            for (int i = 0; i < this.Rows.Count; i++)
            {
                var row = this.Rows[i];
                if (row.IsNewRow)
                {
                    break;
                }
                if (row.Cells["Protocal"].Value.ToString() == protocal)
                {
                    row.Visible = visible;
                }
            }
        }

        public void AddLine(PacketSummary pd)
        {
            if (pd == null)
            {
                return;
            }
            var row = (DataGridViewRow)this.Rows[0].Clone();


            var properties = typeof(PacketSummary).GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                row.Cells[i].Value = properties[i].GetValue(pd).ToString();
            }


            this.Rows.Add(row);

        }

        public void Clear()
        {
            this.Rows.Clear();
        }

        public List<PacketSummary> GetData()
        {
            var result = new List<PacketSummary>();
            for (int i = 0; i < this.Rows.Count; i++)
            {
                var row = this.Rows[i];
                if (row.IsNewRow)
                {
                    break;
                }
                var summary = new PacketSummary();
                summary.Timestamp = row.Cells[0].Value.ToString();
                summary.Destination = row.Cells[1].Value.ToString();
                summary.Source = row.Cells[2].Value.ToString();
                //summary.WebsiteName = row.Cells[3].Value.ToString();
                //summary.Url = row.Cells[4].Value.ToString();
                result.Add(summary);
            }
            return result;
        }
    }
}
