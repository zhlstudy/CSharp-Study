namespace _15_用Socket实现简易的聊天程序_客户端
{
    partial class Form1
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
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.Ibport = new System.Windows.Forms.Label();
            this.txtserprot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSerIP = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.btuConn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSendMsg.Location = new System.Drawing.Point(819, 461);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(144, 36);
            this.btnSendMsg.TabIndex = 20;
            this.btnSendMsg.Text = "发送信息";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMsg.Location = new System.Drawing.Point(158, 461);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(655, 35);
            this.txtMsg.TabIndex = 19;
            // 
            // Ibport
            // 
            this.Ibport.AutoSize = true;
            this.Ibport.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ibport.Location = new System.Drawing.Point(522, 49);
            this.Ibport.Name = "Ibport";
            this.Ibport.Size = new System.Drawing.Size(160, 24);
            this.Ibport.TabIndex = 18;
            this.Ibport.Text = "服务器端口：";
            // 
            // txtserprot
            // 
            this.txtserprot.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtserprot.Location = new System.Drawing.Point(688, 44);
            this.txtserprot.Name = "txtserprot";
            this.txtserprot.Size = new System.Drawing.Size(105, 35);
            this.txtserprot.TabIndex = 17;
            this.txtserprot.Text = "55555";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(449, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 33);
            this.label2.TabIndex = 16;
            // 
            // txtSerIP
            // 
            this.txtSerIP.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSerIP.Location = new System.Drawing.Point(338, 43);
            this.txtSerIP.Name = "txtSerIP";
            this.txtSerIP.Size = new System.Drawing.Size(175, 35);
            this.txtSerIP.TabIndex = 15;
            this.txtSerIP.Text = "10.12.12.183";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(149, 110);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(797, 300);
            this.txtLog.TabIndex = 14;
            this.txtLog.Text = "";
            // 
            // btuConn
            // 
            this.btuConn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btuConn.Location = new System.Drawing.Point(809, 47);
            this.btuConn.Name = "btuConn";
            this.btuConn.Size = new System.Drawing.Size(137, 38);
            this.btuConn.TabIndex = 13;
            this.btuConn.Text = "连接服务器";
            this.btuConn.UseVisualStyleBackColor = true;
            this.btuConn.Click += new System.EventHandler(this.btuConn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(121, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "服务器端IP地址：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 664);
            this.Controls.Add(this.btnSendMsg);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.Ibport);
            this.Controls.Add(this.txtserprot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSerIP);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btuConn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "简易聊天程序-客户端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Label Ibport;
        private System.Windows.Forms.TextBox txtserprot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSerIP;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Button btuConn;
        private System.Windows.Forms.Label label1;
    }
}

