namespace WindowsFormsApplication5
{
    partial class AddStudentForm
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
            this.studentNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.studentClass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.major = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentNo
            // 
            this.studentNo.Location = new System.Drawing.Point(35, 37);
            this.studentNo.Name = "studentNo";
            this.studentNo.Size = new System.Drawing.Size(79, 21);
            this.studentNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(50, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "学号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(50, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名";
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(35, 80);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(79, 21);
            this.studentName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(50, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "班级";
            // 
            // studentClass
            // 
            this.studentClass.Location = new System.Drawing.Point(35, 166);
            this.studentClass.Name = "studentClass";
            this.studentClass.Size = new System.Drawing.Size(79, 21);
            this.studentClass.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(50, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "专业";
            // 
            // major
            // 
            this.major.Location = new System.Drawing.Point(35, 123);
            this.major.Name = "major";
            this.major.Size = new System.Drawing.Size(79, 21);
            this.major.TabIndex = 7;
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(164, 37);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(80, 40);
            this.Enter.TabIndex = 8;
            this.Enter.Text = "添加这个人";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.major);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.studentClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentNo);
            this.Name = "AddStudentForm";
            this.Text = "addStudentForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddStudentForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox studentClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox major;
        private System.Windows.Forms.Button Enter;
    }
}