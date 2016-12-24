namespace WindowsFormsApplication5.View
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.要补考的ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.要重修的ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.评优的ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.courseTable = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.studentTable = new System.Windows.Forms.DataGridView();
            this.选课ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.录入成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseTable)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.查看ToolStripMenuItem,
            this.选课ToolStripMenuItem,
            this.录入成绩ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(406, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.serverToolStripMenuItem.Text = "&Server";
            this.serverToolStripMenuItem.Click += new System.EventHandler(this.serverToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.refreshToolStripMenuItem.Text = "&Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.要补考的ToolStripMenuItem,
            this.要重修的ToolStripMenuItem,
            this.评优的ToolStripMenuItem});
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.查看ToolStripMenuItem.Text = "查看";
            // 
            // 要补考的ToolStripMenuItem
            // 
            this.要补考的ToolStripMenuItem.Name = "要补考的ToolStripMenuItem";
            this.要补考的ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.要补考的ToolStripMenuItem.Text = "要补考的";
            this.要补考的ToolStripMenuItem.Click += new System.EventHandler(this.要补考的ToolStripMenuItem_Click);
            // 
            // 要重修的ToolStripMenuItem
            // 
            this.要重修的ToolStripMenuItem.Name = "要重修的ToolStripMenuItem";
            this.要重修的ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.要重修的ToolStripMenuItem.Text = "要重修的";
            this.要重修的ToolStripMenuItem.Click += new System.EventHandler(this.要重修的ToolStripMenuItem_Click);
            // 
            // 评优的ToolStripMenuItem
            // 
            this.评优的ToolStripMenuItem.Name = "评优的ToolStripMenuItem";
            this.评优的ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.评优的ToolStripMenuItem.Text = "评优的";
            this.评优的ToolStripMenuItem.Click += new System.EventHandler(this.评优的ToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(406, 251);
            this.splitContainer1.SplitterDistance = 134;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.courseTable);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "课程信息";
            // 
            // courseTable
            // 
            this.courseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseTable.Location = new System.Drawing.Point(3, 17);
            this.courseTable.Name = "courseTable";
            this.courseTable.Size = new System.Drawing.Size(128, 231);
            this.courseTable.TabIndex = 0;
            this.courseTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseTable_CellEndEdit);
            this.courseTable.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.courseTable_DefaultValuesNeeded);
            this.courseTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.courseTable_RowsAdded);
            this.courseTable.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.courseTable_RowsRemoved);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.studentTable);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 251);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "学生信息";
            // 
            // studentTable
            // 
            this.studentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentTable.Location = new System.Drawing.Point(3, 17);
            this.studentTable.Name = "studentTable";
            this.studentTable.Size = new System.Drawing.Size(262, 231);
            this.studentTable.TabIndex = 0;
            this.studentTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentTable_CellEndEdit);
            this.studentTable.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.studentTable_DefaultValuesNeeded);
            this.studentTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.studentTable_RowsAdded);
            this.studentTable.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.studentTable_RowsRemoved);
            // 
            // 选课ToolStripMenuItem
            // 
            this.选课ToolStripMenuItem.Name = "选课ToolStripMenuItem";
            this.选课ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.选课ToolStripMenuItem.Text = "选课";
            this.选课ToolStripMenuItem.Click += new System.EventHandler(this.选课ToolStripMenuItem_Click);
            // 
            // 录入成绩ToolStripMenuItem
            // 
            this.录入成绩ToolStripMenuItem.Name = "录入成绩ToolStripMenuItem";
            this.录入成绩ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.录入成绩ToolStripMenuItem.Text = "录入成绩";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(406, 276);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "成绩管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.courseTable)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView courseTable;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView studentTable;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 要补考的ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 要重修的ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 评优的ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选课ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 录入成绩ToolStripMenuItem;
    }
}

