namespace Capture
{
    partial class FrmSetting
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
            this.chkCss = new System.Windows.Forms.CheckBox();
            this.chkJs = new System.Windows.Forms.CheckBox();
            this.chkImage = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAjax = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkCss
            // 
            this.chkCss.AutoSize = true;
            this.chkCss.Location = new System.Drawing.Point(47, 20);
            this.chkCss.Name = "chkCss";
            this.chkCss.Size = new System.Drawing.Size(117, 17);
            this.chkCss.TabIndex = 0;
            this.chkCss.Text = "样式文件（.css）";
            this.chkCss.UseVisualStyleBackColor = true;
            // 
            // chkJs
            // 
            this.chkJs.AutoSize = true;
            this.chkJs.Location = new System.Drawing.Point(47, 60);
            this.chkJs.Name = "chkJs";
            this.chkJs.Size = new System.Drawing.Size(108, 17);
            this.chkJs.TabIndex = 0;
            this.chkJs.Text = "脚步文件（.js）";
            this.chkJs.UseVisualStyleBackColor = true;
            // 
            // chkImage
            // 
            this.chkImage.AutoSize = true;
            this.chkImage.Location = new System.Drawing.Point(47, 96);
            this.chkImage.Name = "chkImage";
            this.chkImage.Size = new System.Drawing.Size(174, 17);
            this.chkImage.TabIndex = 0;
            this.chkImage.Text = "图片文件（.jpg，.png，.gif）";
            this.chkImage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 2);
            this.label1.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(221, 241);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(91, 32);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkJs);
            this.groupBox1.Controls.Add(this.chkCss);
            this.groupBox1.Controls.Add(this.chkImage);
            this.groupBox1.Location = new System.Drawing.Point(31, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 127);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件类型";
            // 
            // chkAjax
            // 
            this.chkAjax.AutoSize = true;
            this.chkAjax.Location = new System.Drawing.Point(78, 42);
            this.chkAjax.Name = "chkAjax";
            this.chkAjax.Size = new System.Drawing.Size(122, 17);
            this.chkAjax.TabIndex = 5;
            this.chkAjax.Text = "是否捕获异步请求";
            this.chkAjax.UseVisualStyleBackColor = true;
            // 
            // FrmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 286);
            this.Controls.Add(this.chkAjax);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Name = "FrmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "捕获设置";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkCss;
        private System.Windows.Forms.CheckBox chkJs;
        private System.Windows.Forms.CheckBox chkImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAjax;
    }
}