namespace BitmapGray
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.maxBtn = new System.Windows.Forms.RadioButton();
            this.averageBtn = new System.Windows.Forms.RadioButton();
            this.weightedBtn = new System.Windows.Forms.RadioButton();
            this.customizedBtn = new System.Windows.Forms.RadioButton();
            this.RLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GLabel = new System.Windows.Forms.Label();
            this.BLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ReturnColor);
            // 
            // maxBtn
            // 
            this.maxBtn.AutoSize = true;
            this.maxBtn.Location = new System.Drawing.Point(12, 49);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.Size = new System.Drawing.Size(88, 19);
            this.maxBtn.TabIndex = 2;
            this.maxBtn.Text = "最大值法";
            this.maxBtn.UseVisualStyleBackColor = true;
            this.maxBtn.CheckedChanged += new System.EventHandler(this.maxBtn_CheckedChanged);
            // 
            // averageBtn
            // 
            this.averageBtn.AutoSize = true;
            this.averageBtn.Location = new System.Drawing.Point(12, 74);
            this.averageBtn.Name = "averageBtn";
            this.averageBtn.Size = new System.Drawing.Size(88, 19);
            this.averageBtn.TabIndex = 3;
            this.averageBtn.Text = "平均值法";
            this.averageBtn.UseVisualStyleBackColor = true;
            this.averageBtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // weightedBtn
            // 
            this.weightedBtn.AutoSize = true;
            this.weightedBtn.Location = new System.Drawing.Point(12, 99);
            this.weightedBtn.Name = "weightedBtn";
            this.weightedBtn.Size = new System.Drawing.Size(88, 19);
            this.weightedBtn.TabIndex = 4;
            this.weightedBtn.Text = "加权值法";
            this.weightedBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.weightedBtn.UseVisualStyleBackColor = true;
            this.weightedBtn.CheckedChanged += new System.EventHandler(this.weightedBtn_CheckedChanged);
            // 
            // customizedBtn
            // 
            this.customizedBtn.AutoSize = true;
            this.customizedBtn.Location = new System.Drawing.Point(12, 124);
            this.customizedBtn.Name = "customizedBtn";
            this.customizedBtn.Size = new System.Drawing.Size(118, 19);
            this.customizedBtn.TabIndex = 5;
            this.customizedBtn.Text = "自定义灰度值";
            this.customizedBtn.UseVisualStyleBackColor = true;
            this.customizedBtn.CheckedChanged += new System.EventHandler(this.customizedBtn_CheckedChanged);
            // 
            // RLabel
            // 
            this.RLabel.AutoSize = true;
            this.RLabel.Location = new System.Drawing.Point(261, 51);
            this.RLabel.Name = "RLabel";
            this.RLabel.Size = new System.Drawing.Size(15, 15);
            this.RLabel.TabIndex = 6;
            this.RLabel.Text = "R";
            this.RLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(63, 25);
            this.textBox1.TabIndex = 7;
            // 
            // GLabel
            // 
            this.GLabel.AutoSize = true;
            this.GLabel.Location = new System.Drawing.Point(261, 87);
            this.GLabel.Name = "GLabel";
            this.GLabel.Size = new System.Drawing.Size(15, 15);
            this.GLabel.TabIndex = 8;
            this.GLabel.Text = "G";
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Location = new System.Drawing.Point(261, 124);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(15, 15);
            this.BLabel.TabIndex = 9;
            this.BLabel.Text = "B";
            this.BLabel.Click += new System.EventHandler(this.BLabel_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(282, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(63, 25);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(282, 118);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(63, 25);
            this.textBox3.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 253);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.GLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RLabel);
            this.Controls.Add(this.customizedBtn);
            this.Controls.Add(this.weightedBtn);
            this.Controls.Add(this.averageBtn);
            this.Controls.Add(this.maxBtn);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "选择算法";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton maxBtn;
        private System.Windows.Forms.RadioButton averageBtn;
        private System.Windows.Forms.RadioButton weightedBtn;
        private System.Windows.Forms.RadioButton customizedBtn;
        private System.Windows.Forms.Label RLabel;
        private System.Windows.Forms.Label GLabel;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
    }
}