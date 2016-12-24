using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class AddStudentForm : Form
    {
        ShowForm showMainFrom = null;
        ReadyToAddStu addStudentList;
        public AddStudentForm(ShowForm showFromFunction)
        {
            InitializeComponent();
            showMainFrom = showFromFunction;
            addStudentList = new WindowsFormsApplication5.ReadyToAddStu();
            addStudentList.Show();
        }

        private void AddStudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            showMainFrom();
            addStudentList.Close();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            addStudentList.addStudent(studentNo.Text, studentName.Text, major.Text, studentClass.Text);
            using (SqlOperator conn = new SqlOperator())
            {
                conn.addStudent(studentNo.Text, studentName.Text, studentClass.Text, major.Text);
            }
        }
    }
}
