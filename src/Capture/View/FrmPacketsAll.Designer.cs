namespace Capture
{
    partial class FrmPacketsAll
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            _monitor.Dispose();
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlCheckBoxes = new System.Windows.Forms.Panel();
            this.chkQQ = new System.Windows.Forms.CheckBox();
            this.chkDns = new System.Windows.Forms.CheckBox();
            this.chkUdp = new System.Windows.Forms.CheckBox();
            this.chkTcp = new System.Windows.Forms.CheckBox();
            this.chkArp = new System.Windows.Forms.CheckBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.监控ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.pnlHeader.SuspendLayout();
            this.pnlCheckBoxes.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.pnlCheckBoxes);
            this.pnlHeader.Controls.Add(this.btnStop);
            this.pnlHeader.Controls.Add(this.btnClear);
            this.pnlHeader.Controls.Add(this.btnStart);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 24);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(844, 74);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlCheckBoxes
            // 
            this.pnlCheckBoxes.Controls.Add(this.chkQQ);
            this.pnlCheckBoxes.Controls.Add(this.chkDns);
            this.pnlCheckBoxes.Controls.Add(this.checkBox2);
            this.pnlCheckBoxes.Controls.Add(this.chkUdp);
            this.pnlCheckBoxes.Controls.Add(this.checkBox1);
            this.pnlCheckBoxes.Controls.Add(this.chkTcp);
            this.pnlCheckBoxes.Controls.Add(this.chkArp);
            this.pnlCheckBoxes.Location = new System.Drawing.Point(3, 36);
            this.pnlCheckBoxes.Name = "pnlCheckBoxes";
            this.pnlCheckBoxes.Size = new System.Drawing.Size(391, 32);
            this.pnlCheckBoxes.TabIndex = 2;
            // 
            // chkQQ
            // 
            this.chkQQ.AutoSize = true;
            this.chkQQ.Checked = true;
            this.chkQQ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkQQ.Location = new System.Drawing.Point(341, 10);
            this.chkQQ.Name = "chkQQ";
            this.chkQQ.Size = new System.Drawing.Size(42, 17);
            this.chkQQ.TabIndex = 1;
            this.chkQQ.Text = "QQ";
            this.chkQQ.UseVisualStyleBackColor = true;
            this.chkQQ.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // chkDns
            // 
            this.chkDns.AutoSize = true;
            this.chkDns.Checked = true;
            this.chkDns.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDns.Location = new System.Drawing.Point(286, 10);
            this.chkDns.Name = "chkDns";
            this.chkDns.Size = new System.Drawing.Size(49, 17);
            this.chkDns.TabIndex = 1;
            this.chkDns.Text = "DNS";
            this.chkDns.UseVisualStyleBackColor = true;
            this.chkDns.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // chkUdp
            // 
            this.chkUdp.AutoSize = true;
            this.chkUdp.Checked = true;
            this.chkUdp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUdp.Location = new System.Drawing.Point(228, 10);
            this.chkUdp.Name = "chkUdp";
            this.chkUdp.Size = new System.Drawing.Size(52, 17);
            this.chkUdp.TabIndex = 1;
            this.chkUdp.Text = "ICMP";
            this.chkUdp.UseVisualStyleBackColor = true;
            this.chkUdp.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // chkTcp
            // 
            this.chkTcp.AutoSize = true;
            this.chkTcp.Checked = true;
            this.chkTcp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTcp.Location = new System.Drawing.Point(112, 10);
            this.chkTcp.Name = "chkTcp";
            this.chkTcp.Size = new System.Drawing.Size(55, 17);
            this.chkTcp.TabIndex = 1;
            this.chkTcp.Text = "HTTP";
            this.chkTcp.UseVisualStyleBackColor = true;
            this.chkTcp.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // chkArp
            // 
            this.chkArp.AutoSize = true;
            this.chkArp.Checked = true;
            this.chkArp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkArp.Location = new System.Drawing.Point(5, 10);
            this.chkArp.Name = "chkArp";
            this.chkArp.Size = new System.Drawing.Size(48, 17);
            this.chkArp.TabIndex = 1;
            this.chkArp.Text = "ARP";
            this.chkArp.UseVisualStyleBackColor = true;
            this.chkArp.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(719, 13);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 45);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "暂停";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(454, 21);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 37);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "清空列表";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(587, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 45);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 98);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(844, 309);
            this.pnlBody.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.监控ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExport,
            this.menuClear,
            this.toolStripMenuItem2,
            this.menuExit});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // menuExport
            // 
            this.menuExport.Name = "menuExport";
            this.menuExport.Size = new System.Drawing.Size(116, 22);
            this.menuExport.Text = "导出(&S)";
            this.menuExport.Click += new System.EventHandler(this.menuExport_Click);
            // 
            // menuClear
            // 
            this.menuClear.Name = "menuClear";
            this.menuClear.Size = new System.Drawing.Size(116, 22);
            this.menuClear.Text = "清空(&C)";
            this.menuClear.Click += new System.EventHandler(this.menuClear_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(113, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(116, 22);
            this.menuExit.Text = "退出(&E)";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // 监控ToolStripMenuItem
            // 
            this.监控ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStart,
            this.menuStop});
            this.监控ToolStripMenuItem.Name = "监控ToolStripMenuItem";
            this.监控ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.监控ToolStripMenuItem.Text = "监控";
            // 
            // menuStart
            // 
            this.menuStart.Name = "menuStart";
            this.menuStart.Size = new System.Drawing.Size(152, 22);
            this.menuStart.Text = "开始(&B)";
            this.menuStart.Click += new System.EventHandler(this.menuStart_Click);
            // 
            // menuStop
            // 
            this.menuStop.Name = "menuStop";
            this.menuStop.Size = new System.Drawing.Size(152, 22);
            this.menuStop.Text = "暂停(&S)";
            this.menuStop.Click += new System.EventHandler(this.menuStop_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(155, 22);
            this.menuAbout.Text = "关于本系统(&A)";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(59, 10);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(47, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "TCP";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(173, 10);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(49, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "UDP";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // FrmPacketsAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 407);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPacketsAll";
            this.Text = "网络连接监控";
            this.pnlHeader.ResumeLayout(false);
            this.pnlCheckBoxes.ResumeLayout(false);
            this.pnlCheckBoxes.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuExport;
        private System.Windows.Forms.ToolStripMenuItem menuClear;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem 监控ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStart;
        private System.Windows.Forms.ToolStripMenuItem menuStop;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.CheckBox chkUdp;
        private System.Windows.Forms.CheckBox chkTcp;
        private System.Windows.Forms.CheckBox chkArp;
        private System.Windows.Forms.Panel pnlCheckBoxes;
        private System.Windows.Forms.CheckBox chkQQ;
        private System.Windows.Forms.CheckBox chkDns;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;

    }
}

