namespace _15_用Socket实现简易的聊天程序_服务器端
{
    partial class ChatService
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
            this.label1 = new System.Windows.Forms.Label();
            this.btuStart = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtprot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Ibport = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.btnSendShhape = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(34, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP地址：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btuStart
            // 
            this.btuStart.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btuStart.Location = new System.Drawing.Point(749, 95);
            this.btuStart.Name = "btuStart";
            this.btuStart.Size = new System.Drawing.Size(137, 38);
            this.btuStart.TabIndex = 1;
            this.btuStart.Text = "开户服务";
            this.btuStart.UseVisualStyleBackColor = true;
            this.btuStart.Click += new System.EventHandler(this.btuStart_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(89, 165);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(797, 273);
            this.txtLog.TabIndex = 2;
            this.txtLog.Text = "";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIP.Location = new System.Drawing.Point(164, 88);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(175, 35);
            this.txtIP.TabIndex = 3;
            this.txtIP.Text = "10.12.12.183";
            // 
            // txtprot
            // 
            this.txtprot.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtprot.Location = new System.Drawing.Point(482, 92);
            this.txtprot.Name = "txtprot";
            this.txtprot.Size = new System.Drawing.Size(105, 35);
            this.txtprot.TabIndex = 5;
            this.txtprot.Text = "55555";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(389, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 33);
            this.label2.TabIndex = 4;
            // 
            // Ibport
            // 
            this.Ibport.AutoSize = true;
            this.Ibport.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ibport.Location = new System.Drawing.Point(362, 88);
            this.Ibport.Name = "Ibport";
            this.Ibport.Size = new System.Drawing.Size(114, 33);
            this.Ibport.TabIndex = 6;
            this.Ibport.Text = "端口：";
            // 
            // txtMsg
            // 
            this.txtMsg.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMsg.Location = new System.Drawing.Point(98, 516);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(655, 35);
            this.txtMsg.TabIndex = 7;
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSendMsg.Location = new System.Drawing.Point(759, 516);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(144, 36);
            this.btnSendMsg.TabIndex = 9;
            this.btnSendMsg.Text = "发送信息";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // btnSendShhape
            // 
            this.btnSendShhape.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSendShhape.Location = new System.Drawing.Point(176, 579);
            this.btnSendShhape.Name = "btnSendShhape";
            this.btnSendShhape.Size = new System.Drawing.Size(163, 56);
            this.btnSendShhape.TabIndex = 10;
            this.btnSendShhape.Text = "发送闪屏";
            this.btnSendShhape.UseVisualStyleBackColor = true;
            this.btnSendShhape.Click += new System.EventHandler(this.btnSendShhape_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSendFile.Location = new System.Drawing.Point(465, 579);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(157, 56);
            this.btnSendFile.TabIndex = 11;
            this.btnSendFile.Text = "发送文件";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // ChatService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 688);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.btnSendShhape);
            this.Controls.Add(this.btnSendMsg);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.Ibport);
            this.Controls.Add(this.txtprot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btuStart);
            this.Controls.Add(this.label1);
            this.Name = "ChatService";
            this.Text = "简易聊天程序-服务端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btuStart;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtprot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Ibport;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.Button btnSendShhape;
        private System.Windows.Forms.Button btnSendFile;
    }
}

