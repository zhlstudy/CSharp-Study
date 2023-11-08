namespace _17_模拟IIS网站管理器
{
    partial class MyIISFrm
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
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Ibport = new System.Windows.Forms.Label();
            this.txtprot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.btuStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ibport
            // 
            this.Ibport.AutoSize = true;
            this.Ibport.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ibport.Location = new System.Drawing.Point(449, 70);
            this.Ibport.Name = "Ibport";
            this.Ibport.Size = new System.Drawing.Size(114, 33);
            this.Ibport.TabIndex = 13;
            this.Ibport.Text = "端口：";
            // 
            // txtprot
            // 
            this.txtprot.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtprot.Location = new System.Drawing.Point(598, 66);
            this.txtprot.Name = "txtprot";
            this.txtprot.Size = new System.Drawing.Size(105, 35);
            this.txtprot.TabIndex = 12;
            this.txtprot.Text = "8088";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(443, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 33);
            this.label2.TabIndex = 11;
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIP.Location = new System.Drawing.Point(218, 68);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(175, 35);
            this.txtIP.TabIndex = 10;
            this.txtIP.Text = "10.12.12.183";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 156);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(1149, 695);
            this.txtLog.TabIndex = 9;
            this.txtLog.Text = "";
            // 
            // btuStart
            // 
            this.btuStart.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btuStart.Location = new System.Drawing.Point(803, 75);
            this.btuStart.Name = "btuStart";
            this.btuStart.Size = new System.Drawing.Size(193, 38);
            this.btuStart.TabIndex = 8;
            this.btuStart.Text = "开户IIS服务";
            this.btuStart.UseVisualStyleBackColor = true;
            this.btuStart.Click += new System.EventHandler(this.btuStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(88, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP地址：";
            // 
            // MyIISFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 904);
            this.Controls.Add(this.Ibport);
            this.Controls.Add(this.txtprot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btuStart);
            this.Controls.Add(this.label1);
            this.Name = "MyIISFrm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ibport;
        private System.Windows.Forms.TextBox txtprot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Button btuStart;
        private System.Windows.Forms.Label label1;
    }
}

