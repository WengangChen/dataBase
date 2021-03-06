﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication5.Helper;

namespace WindowsFormsApplication5.View
{
    public partial class MainForm : Form
    {
        SqlOperator sql = new SqlOperator();
        SqlDataAdapter dataAdapter;
        BindingSource stuBindingSource = new BindingSource();
        BindingSource couBindingSource = new BindingSource();

        public MainForm()
        {
            InitializeComponent();
            courseTable.DataSource = couBindingSource;
            studentTable.DataSource = stuBindingSource;
        }

        private void GetData(DataGridView view, BindingSource binding, string selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, sql.Connection);

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                binding.DataSource = table;

                view.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (SqlException)
            {
            }
        }

        private void courseTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Console.WriteLine(e.RowIndex);
        }

        private void courseTable_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Console.WriteLine(e.RowIndex);
        }

        private void studentTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Console.WriteLine(e.RowIndex);
        }

        private void studentTable_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Console.WriteLine(e.RowIndex);
        }

        private void serverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigForm win = new ConfigForm();
            win.ShowDialog();
            sql.Dispose();
            sql = new SqlOperator();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetData(courseTable, couBindingSource, "select * from 课程信息表");
            GetData(studentTable, stuBindingSource, "select * from 学生信息表");
        }
        
        private void courseTable_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[0].Value = GetNextID();
            e.Row.Cells[1].Value = "";
            e.Row.Cells[2].Value = "";
            e.Row.Cells[3].Value = 0.8;
            e.Row.Cells[4].Value = true;
            e.Row.Cells[5].Value = 1.5;
        }

        private int GetNextID()
        {
            int max = -1;
            foreach (DataGridViewRow item in courseTable.Rows)
                max = Math.Max(max, (int)(item.Cells[0].Value ?? -1));
            return max + 1;
        }

        private void studentTable_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[0].Value = "3114000000";
            e.Row.Cells[1].Value = "";
            e.Row.Cells[2].Value = "";
            e.Row.Cells[3].Value = "";
            e.Row.Cells[4].Value = "";
        }

        private void courseTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // update
            for(int i=0;i<courseTable.ColumnCount;i++)
            {
                if (Convert.ToString(courseTable.Rows[e.RowIndex].Cells[i].Value) == "")
                    return;
            }
            var r = e.RowIndex;
            sql.addCourse(Convert.ToInt32(courseTable.Rows[r].Cells[0].Value),
                Convert.ToString(courseTable.Rows[r].Cells[1].Value),
                Convert.ToString(courseTable.Rows[r].Cells[2].Value),
                Convert.ToDouble(courseTable.Rows[r].Cells[3].Value),
                Convert.ToBoolean(courseTable.Rows[r].Cells[4].Value),
                Convert.ToDouble(courseTable.Rows[r].Cells[5].Value));
            
        }

        private void studentTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // update
            for (int i = 0; i < studentTable.ColumnCount-1; i++)
            {
                if (Convert.ToString(studentTable.Rows[e.RowIndex].Cells[i].Value) == "")
                    return;
            }
            var r = e.RowIndex;
            sql.addStudent(Convert.ToString(studentTable.Rows[r].Cells[0].Value),
                Convert.ToString(studentTable.Rows[r].Cells[1].Value),
                Convert.ToString(studentTable.Rows[r].Cells[3].Value),
                Convert.ToString(studentTable.Rows[r].Cells[2].Value));
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void 要补考的ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            要补考的 form1 = new 要补考的();
            form1.Show();
            form1.showData();
        }

        private void 评优的ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            评优的 form1 = new 评优的();
            form1.Show();
            form1.showData();
        }

        private void 选课ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            选课 form1 = new 选课();
            form1.Show();
            form1.showData();
        }

        private void 要重修的ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            要重修的 form1 = new View.要重修的();
            form1.Show();
            form1.showData();
        }

        private void 登记成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GradeForm form = new GradeForm();
            form.Show();
        }

        private void courseTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
