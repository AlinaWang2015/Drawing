namespace Training
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
            this.txtshow = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.btnopen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtshow
            // 
            this.txtshow.Location = new System.Drawing.Point(49, 109);
            this.txtshow.Multiline = true;
            this.txtshow.Name = "txtshow";
            this.txtshow.Size = new System.Drawing.Size(325, 280);
            this.txtshow.TabIndex = 8;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(137, 41);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(227, 21);
            this.txtaddress.TabIndex = 7;
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(34, 41);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(75, 23);
            this.btnopen.TabIndex = 6;
            this.btnopen.Text = "打开";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 417);
            this.Controls.Add(this.txtshow);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.btnopen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtshow;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Button btnopen;
    }
}

