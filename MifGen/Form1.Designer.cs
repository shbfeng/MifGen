namespace MifGen
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
            this.radio_button_sin = new System.Windows.Forms.RadioButton();
            this.radio_button_square = new System.Windows.Forms.RadioButton();
            this.radio_button_tri = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radio_button_sin
            // 
            this.radio_button_sin.AutoSize = true;
            this.radio_button_sin.Location = new System.Drawing.Point(31, 18);
            this.radio_button_sin.Name = "radio_button_sin";
            this.radio_button_sin.Size = new System.Drawing.Size(59, 16);
            this.radio_button_sin.TabIndex = 0;
            this.radio_button_sin.TabStop = true;
            this.radio_button_sin.Text = "正弦波";
            this.radio_button_sin.UseVisualStyleBackColor = true;
            this.radio_button_sin.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radio_button_square
            // 
            this.radio_button_square.AutoSize = true;
            this.radio_button_square.Location = new System.Drawing.Point(31, 62);
            this.radio_button_square.Name = "radio_button_square";
            this.radio_button_square.Size = new System.Drawing.Size(59, 16);
            this.radio_button_square.TabIndex = 1;
            this.radio_button_square.TabStop = true;
            this.radio_button_square.Text = "方  波";
            this.radio_button_square.UseVisualStyleBackColor = true;
            // 
            // radio_button_tri
            // 
            this.radio_button_tri.AutoSize = true;
            this.radio_button_tri.Location = new System.Drawing.Point(31, 40);
            this.radio_button_tri.Name = "radio_button_tri";
            this.radio_button_tri.Size = new System.Drawing.Size(59, 16);
            this.radio_button_tri.TabIndex = 2;
            this.radio_button_tri.TabStop = true;
            this.radio_button_tri.Text = "三角波";
            this.radio_button_tri.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "生成MIF文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(208, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "精度（bit)";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radio_button_tri);
            this.Controls.Add(this.radio_button_square);
            this.Controls.Add(this.radio_button_sin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_button_sin;
        private System.Windows.Forms.RadioButton radio_button_square;
        private System.Windows.Forms.RadioButton radio_button_tri;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

