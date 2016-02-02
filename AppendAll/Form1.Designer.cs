namespace AppendAll
{
    partial class appendall
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.prefix = new System.Windows.Forms.TextBox();
            this.前缀 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.suffix = new System.Windows.Forms.TextBox();
            this.body = new System.Windows.Forms.TextBox();
            this.convert = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.RadioButton();
            this.java = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // prefix
            // 
            this.prefix.Location = new System.Drawing.Point(77, 34);
            this.prefix.Name = "prefix";
            this.prefix.Size = new System.Drawing.Size(171, 21);
            this.prefix.TabIndex = 2;
            this.prefix.Text = "sql.append(\" ";
            // 
            // 前缀
            // 
            this.前缀.AutoSize = true;
            this.前缀.Location = new System.Drawing.Point(32, 37);
            this.前缀.Name = "前缀";
            this.前缀.Size = new System.Drawing.Size(29, 12);
            this.前缀.TabIndex = 1;
            this.前缀.Text = "前缀";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "后缀";
            // 
            // suffix
            // 
            this.suffix.Location = new System.Drawing.Point(332, 34);
            this.suffix.Name = "suffix";
            this.suffix.Size = new System.Drawing.Size(171, 21);
            this.suffix.TabIndex = 3;
            this.suffix.Text = "\");";
            // 
            // body
            // 
            this.body.Location = new System.Drawing.Point(12, 108);
            this.body.Multiline = true;
            this.body.Name = "body";
            this.body.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.body.Size = new System.Drawing.Size(542, 470);
            this.body.TabIndex = 0;
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(375, 70);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(75, 23);
            this.convert.TabIndex = 1;
            this.convert.Text = "转换&&复制";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(456, 70);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 7;
            this.clear.Text = "清除";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(77, 76);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(35, 16);
            this.c.TabIndex = 8;
            this.c.TabStop = true;
            this.c.Text = "C#";
            this.c.UseVisualStyleBackColor = true;
            this.c.CheckedChanged += new System.EventHandler(this.c_CheckedChanged);
            // 
            // java
            // 
            this.java.AutoSize = true;
            this.java.Location = new System.Drawing.Point(129, 76);
            this.java.Name = "java";
            this.java.Size = new System.Drawing.Size(47, 16);
            this.java.TabIndex = 9;
            this.java.TabStop = true;
            this.java.Text = "Java";
            this.java.UseVisualStyleBackColor = true;
            this.java.CheckedChanged += new System.EventHandler(this.java_CheckedChanged);
            // 
            // appendall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 590);
            this.Controls.Add(this.java);
            this.Controls.Add(this.c);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.body);
            this.Controls.Add(this.suffix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.前缀);
            this.Controls.Add(this.prefix);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "appendall";
            this.Text = "AppendAll";
            this.Load += new System.EventHandler(this.appendall_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prefix;
        private System.Windows.Forms.Label 前缀;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox suffix;
        private System.Windows.Forms.TextBox body;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.RadioButton c;
        private System.Windows.Forms.RadioButton java;
    }
}

