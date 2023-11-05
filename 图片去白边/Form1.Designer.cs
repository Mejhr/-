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
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "选择文件夹";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OpenSelectFilePath);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(594, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "执行去白边";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ExecuteImageWipeOffWhiteEdge);
            // 
            // tbFilePath
            // 
            this.tbFilePath.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbFilePath.Location = new System.Drawing.Point(12, 232);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(506, 26);
            this.tbFilePath.TabIndex = 3;
            // 
            // tbSavePath
            // 
            this.tbSavePath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSavePath.Location = new System.Drawing.Point(12, 286);
            this.tbSavePath.Name = "tbSavePath";
            this.tbSavePath.Size = new System.Drawing.Size(506, 29);
            this.tbSavePath.TabIndex = 4;
            // 
            // 手动输入保存路径
            // 
            this.手动输入保存路径.AutoSize = true;
            this.手动输入保存路径.Location = new System.Drawing.Point(12, 268);
            this.手动输入保存路径.Name = "手动输入保存路径";
            this.手动输入保存路径.Size = new System.Drawing.Size(53, 12);
            this.手动输入保存路径.TabIndex = 5;
            this.手动输入保存路径.Text = "保存位置";
            // 
            // btSetOpenPoint
            // 
            this.btSetOpenPoint.Location = new System.Drawing.Point(12, 12);
            this.btSetOpenPoint.Name = "btSetOpenPoint";
            this.btSetOpenPoint.Size = new System.Drawing.Size(129, 31);
            this.btSetOpenPoint.TabIndex = 6;
            this.btSetOpenPoint.Text = "设置默认打开位置";
            this.btSetOpenPoint.UseVisualStyleBackColor = true;
            this.btSetOpenPoint.Click += new System.EventHandler(this.btSetOpenPoint_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(594, 321);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(150, 23);
            this.OpenFile.TabIndex = 7;
            this.OpenFile.Text = "打开处理后的文件夹";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbText.Location = new System.Drawing.Point(3, 427);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(50, 20);
            this.lbText.TabIndex = 8;
            this.lbText.Text = "label1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(713, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "打开位置";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.btSetOpenPoint);
            this.Controls.Add(this.手动输入保存路径);
            this.Controls.Add(this.tbSavePath);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图片去白边";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}

