namespace Search_Engine
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Google1 = new System.Windows.Forms.RadioButton();
            this.Ask = new System.Windows.Forms.RadioButton();
            this.Bing = new System.Windows.Forms.RadioButton();
            this.Aol = new System.Windows.Forms.RadioButton();
            this.Yahoo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 25);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(96, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1096, 238);
            this.listBox1.TabIndex = 2;
            // 
            // Google1
            // 
            this.Google1.AutoSize = true;
            this.Google1.Location = new System.Drawing.Point(3, 92);
            this.Google1.Name = "Google1";
            this.Google1.Size = new System.Drawing.Size(58, 17);
            this.Google1.TabIndex = 4;
            this.Google1.TabStop = true;
            this.Google1.Text = "Google";
            this.Google1.UseVisualStyleBackColor = true;
            this.Google1.CheckedChanged += new System.EventHandler(this.Google_CheckedChanged);
            // 
            // Ask
            // 
            this.Ask.AutoSize = true;
            this.Ask.Location = new System.Drawing.Point(3, 115);
            this.Ask.Name = "Ask";
            this.Ask.Size = new System.Drawing.Size(42, 17);
            this.Ask.TabIndex = 5;
            this.Ask.TabStop = true;
            this.Ask.Text = "Ask";
            this.Ask.UseVisualStyleBackColor = true;
            // 
            // Bing
            // 
            this.Bing.AutoSize = true;
            this.Bing.Location = new System.Drawing.Point(3, 138);
            this.Bing.Name = "Bing";
            this.Bing.Size = new System.Drawing.Size(45, 17);
            this.Bing.TabIndex = 6;
            this.Bing.TabStop = true;
            this.Bing.Text = "Bing";
            this.Bing.UseVisualStyleBackColor = true;
            // 
            // Aol
            // 
            this.Aol.AutoSize = true;
            this.Aol.Location = new System.Drawing.Point(3, 161);
            this.Aol.Name = "Aol";
            this.Aol.Size = new System.Drawing.Size(40, 17);
            this.Aol.TabIndex = 7;
            this.Aol.TabStop = true;
            this.Aol.Text = "Aol";
            this.Aol.UseVisualStyleBackColor = true;
            // 
            // Yahoo
            // 
            this.Yahoo.AutoSize = true;
            this.Yahoo.Location = new System.Drawing.Point(3, 184);
            this.Yahoo.Name = "Yahoo";
            this.Yahoo.Size = new System.Drawing.Size(55, 17);
            this.Yahoo.TabIndex = 8;
            this.Yahoo.TabStop = true;
            this.Yahoo.Text = "Yahoo";
            this.Yahoo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 335);
            this.Controls.Add(this.Yahoo);
            this.Controls.Add(this.Aol);
            this.Controls.Add(this.Bing);
            this.Controls.Add(this.Ask);
            this.Controls.Add(this.Google1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Search Engine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public  System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        public  System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton Google1;
        private System.Windows.Forms.RadioButton Ask;
        private System.Windows.Forms.RadioButton Bing;
        private System.Windows.Forms.RadioButton Aol;
        private System.Windows.Forms.RadioButton Yahoo;
    }
}

