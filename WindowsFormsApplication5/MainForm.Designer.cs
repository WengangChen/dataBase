namespace WindowsFormsApplication5
{
    partial class MainForm
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
            this.addStudent = new System.Windows.Forms.Button();
            this.removeStudent = new System.Windows.Forms.Button();
            this.modifyStudent = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(27, 36);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(86, 26);
            this.addStudent.TabIndex = 0;
            this.addStudent.Text = "加人";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // removeStudent
            // 
            this.removeStudent.Location = new System.Drawing.Point(27, 83);
            this.removeStudent.Name = "removeStudent";
            this.removeStudent.Size = new System.Drawing.Size(86, 27);
            this.removeStudent.TabIndex = 1;
            this.removeStudent.Text = "删除学生信息";
            this.removeStudent.UseVisualStyleBackColor = true;
            // 
            // modifyStudent
            // 
            this.modifyStudent.Location = new System.Drawing.Point(27, 139);
            this.modifyStudent.Name = "modifyStudent";
            this.modifyStudent.Size = new System.Drawing.Size(86, 24);
            this.modifyStudent.TabIndex = 2;
            this.modifyStudent.Text = "修改学生信息";
            this.modifyStudent.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.modifyStudent);
            this.Controls.Add(this.removeStudent);
            this.Controls.Add(this.addStudent);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Button removeStudent;
        private System.Windows.Forms.Button modifyStudent;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

