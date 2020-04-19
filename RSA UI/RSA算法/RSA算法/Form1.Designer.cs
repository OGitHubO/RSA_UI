namespace RSA算法
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
    {
        this.StrBox = new System.Windows.Forms.TextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.PubKeyBox = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.PrvKeyBox = new System.Windows.Forms.TextBox();
        this.label3 = new System.Windows.Forms.Label();
        this.EncrypeBox = new System.Windows.Forms.TextBox();
        this.label4 = new System.Windows.Forms.Label();
        this.label5 = new System.Windows.Forms.Label();
        this.Str2Box = new System.Windows.Forms.TextBox();
        this.CrypeBtn = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // StrBox
        // 
        this.StrBox.Location = new System.Drawing.Point(153, 15);
        this.StrBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        this.StrBox.Name = "StrBox";
        this.StrBox.Size = new System.Drawing.Size(343, 25);
        this.StrBox.TabIndex = 0;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(15, 22);
        this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(97, 15);
        this.label1.TabIndex = 1;
        this.label1.Text = "Plaintext";
        // 
        // PubKeyBox
        // 
        this.PubKeyBox.Location = new System.Drawing.Point(153, 98);
        this.PubKeyBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        this.PubKeyBox.Multiline = true;
        this.PubKeyBox.Name = "PubKeyBox";
        this.PubKeyBox.Size = new System.Drawing.Size(343, 92);
        this.PubKeyBox.TabIndex = 2;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(15, 109);
        this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(37, 15);
        this.label2.TabIndex = 3;
        this.label2.Text = "PublicKey";
        // 
        // PrvKeyBox
        // 
        this.PrvKeyBox.Location = new System.Drawing.Point(153, 198);
        this.PrvKeyBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        this.PrvKeyBox.Multiline = true;
        this.PrvKeyBox.Name = "PrvKeyBox";
        this.PrvKeyBox.Size = new System.Drawing.Size(343, 159);
        this.PrvKeyBox.TabIndex = 4;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(17, 209);
        this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(127, 15);
        this.label3.TabIndex = 5;
        this.label3.Text = "PrivateKey";
        // 
        // EncrypeBox
        // 
        this.EncrypeBox.Location = new System.Drawing.Point(153, 365);
        this.EncrypeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        this.EncrypeBox.Name = "EncrypeBox";
        this.EncrypeBox.Size = new System.Drawing.Size(343, 25);
        this.EncrypeBox.TabIndex = 6;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(19, 374);
        this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(37, 15);
        this.label4.TabIndex = 7;
        this.label4.Text = "Ciphertext";
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(19, 411);
        this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(97, 15);
        this.label5.TabIndex = 8;
        this.label5.Text = "New Plaintext";
        // 
        // Str2Box
        // 
        this.Str2Box.Location = new System.Drawing.Point(153, 400);
        this.Str2Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        this.Str2Box.Name = "Str2Box";
        this.Str2Box.Size = new System.Drawing.Size(343, 25);
        this.Str2Box.TabIndex = 9;
        // 
        // CrypeBtn
        // 
        this.CrypeBtn.Location = new System.Drawing.Point(156, 54);
        this.CrypeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        this.CrypeBtn.Name = "CrypeBtn";
        this.CrypeBtn.Size = new System.Drawing.Size(139, 29);
        this.CrypeBtn.TabIndex = 10;
        this.CrypeBtn.Text = "Execute";
        this.CrypeBtn.UseVisualStyleBackColor = true;
        this.CrypeBtn.Click += new System.EventHandler(this.CrypeBtn_Click);
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(513, 441);
        this.Controls.Add(this.CrypeBtn);
        this.Controls.Add(this.Str2Box);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.EncrypeBox);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.PrvKeyBox);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.PubKeyBox);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.StrBox);
        this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        this.Name = "Form1";
        this.Text = "RSA";
        this.ResumeLayout(false);
        this.PerformLayout();

    }
    #endregion
    private System.Windows.Forms.TextBox StrBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox PubKeyBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox PrvKeyBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox EncrypeBox;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox Str2Box;
    private System.Windows.Forms.Button CrypeBtn;
    }
}

