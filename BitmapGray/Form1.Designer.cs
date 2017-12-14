namespace BitmapGray
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
            this.upFile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.changeGray = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // upFile
            // 
            this.upFile.Location = new System.Drawing.Point(332, 12);
            this.upFile.Name = "upFile";
            this.upFile.Size = new System.Drawing.Size(127, 39);
            this.upFile.TabIndex = 0;
            this.upFile.Text = "选择图片";
            this.upFile.UseVisualStyleBackColor = true;
            this.upFile.Click += new System.EventHandler(this.upFile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-11, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(518, 458);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(531, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(552, 458);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // changeGray
            // 
            this.changeGray.Location = new System.Drawing.Point(575, 12);
            this.changeGray.Name = "changeGray";
            this.changeGray.Size = new System.Drawing.Size(127, 39);
            this.changeGray.TabIndex = 3;
            this.changeGray.Text = "灰度转换\r\n";
            this.changeGray.UseVisualStyleBackColor = true;
            this.changeGray.Click += new System.EventHandler(this.changeGray_Click);
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(932, 0);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(106, 32);
            this.saveFile.TabIndex = 4;
            this.saveFile.Text = "保存图像";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 499);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.changeGray);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.upFile);
            this.Name = "Form1";
            this.Text = "灰度转换";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button upFile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button changeGray;
        private System.Windows.Forms.Button saveFile;
    }
}

