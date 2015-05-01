namespace PacketAnalyst
{
    partial class FrmPacketGrap
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRuleSet = new System.Windows.Forms.Button();
            this.lblFilterRule = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(654, 11);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(65, 45);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "规则:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(337, 22);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "清空列表";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnRuleSet
            // 
            this.btnRuleSet.Location = new System.Drawing.Point(233, 22);
            this.btnRuleSet.Name = "btnRuleSet";
            this.btnRuleSet.Size = new System.Drawing.Size(75, 23);
            this.btnRuleSet.TabIndex = 4;
            this.btnRuleSet.Text = "设置过滤规则";
            this.btnRuleSet.UseVisualStyleBackColor = true;
            this.btnRuleSet.Click += new System.EventHandler(this.btnRuleSet_Click);
            // 
            // lblFilterRule
            // 
            this.lblFilterRule.AutoSize = true;
            this.lblFilterRule.Location = new System.Drawing.Point(74, 52);
            this.lblFilterRule.Name = "lblFilterRule";
            this.lblFilterRule.Size = new System.Drawing.Size(0, 13);
            this.lblFilterRule.TabIndex = 5;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(725, 11);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(65, 45);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // FrmPacketGrap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 446);
            this.Controls.Add(this.lblFilterRule);
            this.Controls.Add(this.btnRuleSet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "FrmPacketGrap";
            this.Text = "数据包捕获";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRuleSet;
        private System.Windows.Forms.Label lblFilterRule;
        private System.Windows.Forms.Button btnStop;
    }
}

