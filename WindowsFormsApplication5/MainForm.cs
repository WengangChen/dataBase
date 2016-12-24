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
    public delegate void ShowForm();
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void addStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new WindowsFormsApplication5.AddStudentForm(this.Show);
            this.Hide();
            addStudentForm.Show();
        }
    }
}
