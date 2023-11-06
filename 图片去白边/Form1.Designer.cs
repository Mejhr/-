namespace 图片去白边
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.tbSavePath = new System.Windows.Forms.TextBox();
            this.手动输入保存路径 = new System.Windows.Forms.Label();
            this.btSetOpenPoint = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.Button();
            this.lbText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRectangle = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "选择文件夹";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OpenSelectFilePath);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 26);
            this.button2.TabIndex = 1;
            this.button2.Text = "执行去白边";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ExecuteImageWipeOffWhiteEdge);
            // 
            // tbFilePath
            // 
            this.tbFilePath.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbFilePath.Location = new System.Drawing.Point(11, 337);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(506, 26);
            this.tbFilePath.TabIndex = 3;
            // 
            // tbSavePath
            // 
            this.tbSavePath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSavePath.Location = new System.Drawing.Point(11, 391);
            this.tbSavePath.Name = "tbSavePath";
            this.tbSavePath.Size = new System.Drawing.Size(506, 29);
            this.tbSavePath.TabIndex = 4;
            // 
            // 手动输入保存路径
            // 
            this.手动输入保存路径.AutoSize = true;
            this.手动输入保存路径.Location = new System.Drawing.Point(11, 373);
            this.手动输入保存路径.Name = "手动输入保存路径";
            this.手动输入保存路径.Size = new System.Drawing.Size(53, 12);
            this.手动输入保存路径.TabIndex = 5;
            this.手动输入保存路径.Text = "保存位置";
            // 
            // btSetOpenPoint
            // 
            this.btSetOpenPoint.Location = new System.Drawing.Point(9, 433);
            this.btSetOpenPoint.Name = "btSetOpenPoint";
            this.btSetOpenPoint.Size = new System.Drawing.Size(129, 31);
            this.btSetOpenPoint.TabIndex = 6;
            this.btSetOpenPoint.Text = "设置默认打开位置";
            this.btSetOpenPoint.UseVisualStyleBackColor = true;
            this.btSetOpenPoint.Click += new System.EventHandler(this.btSetOpenPoint_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(568, 455);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(141, 29);
            this.OpenFile.TabIndex = 7;
            this.OpenFile.Text = "打开处理后的文件夹";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbText.Location = new System.Drawing.Point(2, 473);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(50, 20);
            this.lbText.TabIndex = 8;
            this.lbText.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "打开位置";
            // 
            // cbRectangle
            // 
            this.cbRectangle.AutoSize = true;
            this.cbRectangle.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbRectangle.Location = new System.Drawing.Point(658, 338);
            this.cbRectangle.Name = "cbRectangle";
            this.cbRectangle.Size = new System.Drawing.Size(58, 24);
            this.cbRectangle.TabIndex = 11;
            this.cbRectangle.Text = "1：1";
            this.cbRectangle.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(375, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(50, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(50, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(187, 18);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(375, 169);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(536, 303);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(84, 16);
            this.checkBox.TabIndex = 17;
            this.checkBox.Text = "是否去主图";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 496);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cbRectangle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.btSetOpenPoint);
            this.Controls.Add(this.手动输入保存路径);
            this.Controls.Add(this.tbSavePath);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图片去白边";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.TextBox tbSavePath;
        private System.Windows.Forms.Label 手动输入保存路径;
        private System.Windows.Forms.Button btSetOpenPoint;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbRectangle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox;
    }
}

