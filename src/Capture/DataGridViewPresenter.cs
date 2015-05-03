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

            //var properties = typeof(HttpPacketSummary).GetProperties();
            //foreach (var item in properties)
            //{
            //    this.Columns.Add(item.Name, item.Name);
            //}

            this.Columns.Add("time", "上网时间");
            this.Columns.Add("destIp", "目的ip");
            this.Columns.Add("srcIp", "源ip");
            this.Columns.Add("host", "网站名");
            this.Columns.Add("url", "Url");
        }
        public void AddLine(HttpPacketSummary pd)
        {
            if (pd == null)
            {
                return;
            }
            var row = (DataGridViewRow)this.Rows[0].Clone();

            row.Cells[0].Value = pd.Timestamp.ToString("yyyy-MM-dd hh:mm:ss");
            row.Cells[1].Value = pd.Destination;
            row.Cells[2].Value = pd.Source;
            row.Cells[3].Value = pd.WebsiteName;
            row.Cells[4].Value = pd.Url;

            this.Rows.Add(row);

        }

        public void Clear()
        {
            this.Rows.Clear();
        }

        public List<HttpPacketSummary> GetData()
        {
            var result = new List<HttpPacketSummary>();
            for (int i = 0; i < this.Rows.Count; i++)
            {
                var row = this.Rows[i];
                if (row.IsNewRow)
                {
                    break;
                }
                var summary = new HttpPacketSummary();
                summary.Timestamp = DateTime.Parse(row.Cells[0].Value.ToString());
                summary.Destination = row.Cells[1].Value.ToString();
                summary.Source = row.Cells[2].Value.ToString();
                summary.WebsiteName = row.Cells[3].Value.ToString();
                summary.Url = row.Cells[4].Value.ToString();
                result.Add(summary);
            }
            return result;
        }
    }
}
