namespace MergingData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnInputDirectory = new System.Windows.Forms.Button();
            this.fbdInput = new System.Windows.Forms.FolderBrowserDialog();
            this.tbxInputDirectory = new System.Windows.Forms.TextBox();
            this.btnOutputDirectory = new System.Windows.Forms.Button();
            this.tbxOutputDirectory = new System.Windows.Forms.TextBox();
            this.fbdOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.btnMerginData = new System.Windows.Forms.Button();
            this.grpSelectPath = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSelectPath.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInputDirectory
            // 
            this.btnInputDirectory.Location = new System.Drawing.Point(500, 47);
            this.btnInputDirectory.Name = "btnInputDirectory";
            this.btnInputDirectory.Size = new System.Drawing.Size(75, 23);
            this.btnInputDirectory.TabIndex = 0;
            this.btnInputDirectory.Text = "输入文件夹";
            this.btnInputDirectory.UseVisualStyleBackColor = true;
            this.btnInputDirectory.Click += new System.EventHandler(this.btnInputDirectory_Click);
            // 
            // tbxInputDirectory
            // 
            this.tbxInputDirectory.Location = new System.Drawing.Point(19, 49);
            this.tbxInputDirectory.Name = "tbxInputDirectory";
            this.tbxInputDirectory.Size = new System.Drawing.Size(454, 21);
            this.tbxInputDirectory.TabIndex = 1;
            // 
            // btnOutputDirectory
            // 
            this.btnOutputDirectory.Location = new System.Drawing.Point(500, 97);
            this.btnOutputDirectory.Name = "btnOutputDirectory";
            this.btnOutputDirectory.Size = new System.Drawing.Size(75, 23);
            this.btnOutputDirectory.TabIndex = 2;
            this.btnOutputDirectory.Text = "输出文件夹";
            this.btnOutputDirectory.UseVisualStyleBackColor = true;
            this.btnOutputDirectory.Click += new System.EventHandler(this.btnOutputDirectory_Click);
            // 
            // tbxOutputDirectory
            // 
            this.tbxOutputDirectory.Location = new System.Drawing.Point(19, 98);
            this.tbxOutputDirectory.Name = "tbxOutputDirectory";
            this.tbxOutputDirectory.Size = new System.Drawing.Size(454, 21);
            this.tbxOutputDirectory.TabIndex = 3;
            // 
            // btnMerginData
            // 
            this.btnMerginData.Location = new System.Drawing.Point(272, 206);
            this.btnMerginData.Name = "btnMerginData";
            this.btnMerginData.Size = new System.Drawing.Size(75, 23);
            this.btnMerginData.TabIndex = 4;
            this.btnMerginData.Text = "合并数据";
            this.btnMerginData.UseVisualStyleBackColor = true;
            this.btnMerginData.Click += new System.EventHandler(this.btnMerginData_Click);
            // 
            // grpSelectPath
            // 
            this.grpSelectPath.AutoSize = true;
            this.grpSelectPath.Controls.Add(this.tbxInputDirectory);
            this.grpSelectPath.Controls.Add(this.btnInputDirectory);
            this.grpSelectPath.Controls.Add(this.tbxOutputDirectory);
            this.grpSelectPath.Controls.Add(this.btnOutputDirectory);
            this.grpSelectPath.Location = new System.Drawing.Point(12, 40);
            this.grpSelectPath.Name = "grpSelectPath";
            this.grpSelectPath.Size = new System.Drawing.Size(595, 144);
            this.grpSelectPath.TabIndex = 5;
            this.grpSelectPath.TabStop = false;
            this.grpSelectPath.Text = "选择路径";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.hToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            this.hToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.hToolStripMenuItem.Text = "&Help";
            this.hToolStripMenuItem.Click += new System.EventHandler(this.hToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 251);
            this.Controls.Add(this.grpSelectPath);
            this.Controls.Add(this.btnMerginData);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MerginData";
            this.grpSelectPath.ResumeLayout(false);
            this.grpSelectPath.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInputDirectory;
        private System.Windows.Forms.FolderBrowserDialog fbdInput;
        private System.Windows.Forms.TextBox tbxInputDirectory;
        private System.Windows.Forms.Button btnOutputDirectory;
        private System.Windows.Forms.TextBox tbxOutputDirectory;
        private System.Windows.Forms.FolderBrowserDialog fbdOutput;
        private System.Windows.Forms.Button btnMerginData;
        private System.Windows.Forms.GroupBox grpSelectPath;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hToolStripMenuItem;
    }
}

