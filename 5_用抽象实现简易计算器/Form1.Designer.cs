namespace _5_用抽象实现简易计算器
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
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbType.Location = new System.Drawing.Point(208, 64);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(92, 32);
            this.cmbType.TabIndex = 0;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(479, 63);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(81, 21);
            this.btnCount.TabIndex = 1;
            this.btnCount.Text = "=";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = true;
            this.txtResult.Location = new System.Drawing.Point(603, 72);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(22, 24);
            this.txtResult.TabIndex = 2;
            this.txtResult.Text = "0";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(344, 63);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 35);
            this.txtNum2.TabIndex = 1;
            this.txtNum2.Text = "0";

            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(87, 64);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(90, 35);
            this.txtNum1.TabIndex = 0;
            this.txtNum1.Text = "0";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(882, 229);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.cmbType);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        
       
       
        
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label txtResult;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
    }
}

