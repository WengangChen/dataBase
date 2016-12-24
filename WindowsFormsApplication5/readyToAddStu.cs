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
    
    public partial class ReadyToAddStu : Form
    {
        public ReadyToAddStu()
        {
            InitializeComponent();
        }
        public void addStudent(string number, string name, string studentClass, string major)
        {
            ListViewItem tmp = new ListViewItem();
            tmp.SubItems.Add(number);
            tmp.SubItems.Add(name);
            tmp.SubItems.Add(studentClass);
            tmp.SubItems.Add(major);
            addStudentFormView.Items.Add(tmp);
        }

        private void addStudentFormView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void removeThisStudent_Click(object sender, EventArgs e)
        {
            if (addStudentFormView.SelectedIndices.Count != 0)
            {
                var tmp = addStudentFormView.SelectedItems[0];
                string studentNumber = tmp.SubItems[1].Text;
                addStudentFormView.Items.Remove(addStudentFormView.SelectedItems[0]);
                using (SqlOperator conn = new SqlOperator())
                {
                    conn.removeStudent(studentNumber);
                }
            }
        }
    }
}
