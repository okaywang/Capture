using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PacketAnalyst.DataAccess;
using Ninject;
using PacketAnalyst.Utility;

namespace PacketAnalyst.UI
{
    public partial class FrmFilterSettings : Form
    {
        private IPersistence _persistence;

        public event Action<object, FilterRuleEventArgs> FilterRuleChanged;

        public FrmFilterSettings()
        {
            InitializeComponent();

            _persistence = Program.kernel.Get<IPersistence>();
        }

        private void FrmFilterSettings_Load(object sender, EventArgs e)
        {

            this.dgvRules.Columns["colId"].DataPropertyName = "Id";
            this.dgvRules.Columns["colValue"].DataPropertyName = "Value";
            this.dgvRules.Columns["colDescription"].DataPropertyName = "Description";

            this.dgvRules.AutoGenerateColumns = false;

            this.LoadRulesData();
        }

        private void dgvRules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = this.dgvRules.Columns[e.ColumnIndex].Name;
            var id = Int32.Parse(this.dgvRules.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (colName == "colDelete")
            {
                _persistence.DeleteRule(id);
                this.LoadRulesData();
            }
            else if (colName == "colApply")
            {
                var ruleValue = this.dgvRules.Rows[e.RowIndex].Cells[1].Value.ToString();
                var rule = new FilterRule
                {
                    Id = id,
                    Value = ruleValue
                };
                var eArgs = new FilterRuleEventArgs();
                eArgs.Rule = rule;
                OnFilterRuleChanged(eArgs);
                this.Close();
            }
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            var ruleText = this.txtFilterRule.Text.Trim();
            if (ruleText == string.Empty)
            {
                MessageBox.Show("请输入过滤规则");
                return;
            }
            var model = new FilterRule();
            model.Value = this.txtFilterRule.Text;
            model.Description = this.txtDescription.Text;
            _persistence.CreateRule(model);

            this.txtFilterRule.Clear();
            this.txtDescription.Clear();
            this.LoadRulesData();
        }


        private void OnFilterRuleChanged(FilterRuleEventArgs e)
        {
            if (FilterRuleChanged != null)
            {
                FilterRuleChanged(this, e);
            }
        }

        private void LoadRulesData()
        {
            var rules = _persistence.GetAllRules();
            this.dgvRules.DataSource = rules;
        }
    }
}
