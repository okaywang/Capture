﻿namespace PacketAnalyst
{
    partial class FrmPacketStatistics
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lstStatistics = new System.Windows.Forms.ListBox();
            this.lblFilterRule = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(592, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 40);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstStatistics
            // 
            this.lstStatistics.FormattingEnabled = true;
            this.lstStatistics.Location = new System.Drawing.Point(45, 73);
            this.lstStatistics.Name = "lstStatistics";
            this.lstStatistics.Size = new System.Drawing.Size(622, 238);
            this.lstStatistics.TabIndex = 1;
            // 
            // lblFilterRule
            // 
            this.lblFilterRule.AutoSize = true;
            this.lblFilterRule.Location = new System.Drawing.Point(132, 48);
            this.lblFilterRule.Name = "lblFilterRule";
            this.lblFilterRule.Size = new System.Drawing.Size(0, 13);
            this.lblFilterRule.TabIndex = 6;
            // 
            // FrmPacketStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 360);
            this.Controls.Add(this.lblFilterRule);
            this.Controls.Add(this.lstStatistics);
            this.Controls.Add(this.btnStart);
            this.Name = "FrmPacketStatistics";
            this.Text = "网络流量统计";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstStatistics;
        private System.Windows.Forms.Label lblFilterRule;
    }
}