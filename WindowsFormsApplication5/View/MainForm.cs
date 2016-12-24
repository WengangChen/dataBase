using System;
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
            e.Row.Cells[0].Value = 123;
            e.Row.Cells[1].Value = "";
            e.Row.Cells[2].Value = "";
            e.Row.Cells[3].Value = 0.8;
            e.Row.Cells[4].Value = true;
            e.Row.Cells[5].Value = 1.5;
        }
    }
}
