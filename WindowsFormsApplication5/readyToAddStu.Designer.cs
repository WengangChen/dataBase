namespace WindowsFormsApplication5
{
    partial class ReadyToAddStu
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
            this.addStudentFormView = new System.Windows.Forms.ListView();
            this.waste = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.学号 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.姓名 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.专业 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.班级 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeThisStudent = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addStudentFormView
            // 
            this.addStudentFormView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.waste,
            this.学号,
            this.姓名,
            this.专业,
            this.班级});
            this.addStudentFormView.FullRowSelect = true;
            this.addStudentFormView.Location = new System.Drawing.Point(12, 13);
            this.addStudentFormView.MultiSelect = false;
            this.addStudentFormView.Name = "addStudentFormView";
            this.addStudentFormView.Size = new System.Drawing.Size(705, 111);
            this.addStudentFormView.TabIndex = 0;
            this.addStudentFormView.UseCompatibleStateImageBehavior = false;
            this.addStudentFormView.View = System.Windows.Forms.View.Details;
            this.addStudentFormView.SelectedIndexChanged += new System.EventHandler(this.addStudentFormView_SelectedIndexChanged);
            // 
            // waste
            // 
            this.waste.Text = " ";
            this.waste.Width = 5;
            // 
            // 学号
            // 
            this.学号.Text = "学号";
            this.学号.Width = 127;
            // 
            // 姓名
            // 
            this.姓名.Text = "姓名";
            this.姓名.Width = 196;
            // 
            // 专业
            // 
            this.专业.Text = "专业";
            this.专业.Width = 148;
            // 
            // 班级
            // 
            this.班级.Text = "班级";
            this.班级.Width = 176;
            // 
            // removeThisStudent
            // 
            this.removeThisStudent.Location = new System.Drawing.Point(592, 339);
            this.removeThisStudent.Name = "removeThisStudent";
            this.removeThisStudent.Size = new System.Drawing.Size(99, 26);
            this.removeThisStudent.TabIndex = 1;
            this.removeThisStudent.Text = "删除这个人";
            this.removeThisStudent.UseVisualStyleBackColor = true;
            this.removeThisStudent.Click += new System.EventHandler(this.removeThisStudent_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(711, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "学号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "专业";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "班级";
            this.Column4.Name = "Column4";
            // 
            // 准备添加的学生
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 378);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.removeThisStudent);
            this.Controls.Add(this.addStudentFormView);
            this.Name = "准备添加的学生";
            this.Text = "准备添加的学生";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView addStudentFormView;
        private System.Windows.Forms.ColumnHeader 学号;
        private System.Windows.Forms.ColumnHeader 姓名;
        private System.Windows.Forms.ColumnHeader 专业;
        private System.Windows.Forms.ColumnHeader 班级;
        private System.Windows.Forms.ColumnHeader waste;
        private System.Windows.Forms.Button removeThisStudent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}