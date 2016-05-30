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
            this.combine = new System.Windows.Forms.Button();
            this.combine_address = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtshow
            // 
            this.txtshow.Location = new System.Drawing.Point(34, 137);
            this.txtshow.Multiline = true;
            this.txtshow.Name = "txtshow";
            this.txtshow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtshow.Size = new System.Drawing.Size(340, 350);
            this.txtshow.TabIndex = 8;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(137, 47);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(227, 20);
            this.txtaddress.TabIndex = 7;
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(34, 44);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(75, 25);
            this.btnopen.TabIndex = 6;
            this.btnopen.Text = "打开文件";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // combine
            // 
            this.combine.Location = new System.Drawing.Point(34, 89);
            this.combine.Name = "combine";
            this.combine.Size = new System.Drawing.Size(75, 23);
            this.combine.TabIndex = 9;
            this.combine.Text = "合并文件";
            this.combine.UseVisualStyleBackColor = true;
            // 
            // combine_address
            // 
            this.combine_address.Location = new System.Drawing.Point(137, 89);
            this.combine_address.Name = "combine_address";
            this.combine_address.Size = new System.Drawing.Size(227, 20);
            this.combine_address.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(430, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 397);
            this.panel1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "绘制地图";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(578, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "清除画笔格式";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(734, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "清除画布格式";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 536);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.combine_address);
            this.Controls.Add(this.combine);
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
        private System.Windows.Forms.Button combine;
        private System.Windows.Forms.TextBox combine_address;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

