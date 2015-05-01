namespace PacketAnalyst.UI
{
    partial class FrmFilterSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddRule = new System.Windows.Forms.Button();
            this.txtFilterRule = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRules = new System.Windows.Forms.DataGridView();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colApply = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddRule
            // 
            this.btnAddRule.Location = new System.Drawing.Point(616, 26);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(75, 46);
            this.btnAddRule.TabIndex = 0;
            this.btnAddRule.Text = "保存";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // txtFilterRule
            // 
            this.txtFilterRule.Location = new System.Drawing.Point(83, 26);
            this.txtFilterRule.Name = "txtFilterRule";
            this.txtFilterRule.Size = new System.Drawing.Size(251, 20);
            this.txtFilterRule.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "过滤规则:";
            // 
            // dgvRules
            // 
            this.dgvRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colValue,
            this.colDescription,
            this.colDelete,
            this.colApply});
            this.dgvRules.Location = new System.Drawing.Point(15, 103);
            this.dgvRules.Name = "dgvRules";
            this.dgvRules.Size = new System.Drawing.Size(676, 242);
            this.dgvRules.TabIndex = 3;
            this.dgvRules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRules_CellClick);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(83, 52);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(251, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "描述:";
            // 
            // colId
            // 
            this.colId.HeaderText = "Column1";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colValue
            // 
            this.colValue.HeaderText = "过滤规则";
            this.colValue.Name = "colValue";
            this.colValue.Width = 200;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "描述";
            this.colDescription.Name = "colDescription";
            this.colDescription.Width = 200;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "删除";
            this.colDelete.Name = "colDelete";
            this.colDelete.Text = "delete";
            this.colDelete.UseColumnTextForLinkValue = true;
            // 
            // colApply
            // 
            this.colApply.HeaderText = "使用";
            this.colApply.Name = "colApply";
            this.colApply.Text = "Apply";
            this.colApply.UseColumnTextForLinkValue = true;
            // 
            // FrmFilterSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 428);
            this.Controls.Add(this.dgvRules);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtFilterRule);
            this.Controls.Add(this.btnAddRule);
            this.Name = "FrmFilterSettings";
            this.Text = "过滤规则设置";
            this.Load += new System.EventHandler(this.FrmFilterSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.TextBox txtFilterRule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRules;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewLinkColumn colDelete;
        private System.Windows.Forms.DataGridViewLinkColumn colApply;
    }
}