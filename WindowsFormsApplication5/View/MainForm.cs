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

        public MainForm()
        {
            InitializeComponent();
        }

        private void GetStuData(string selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, sql.Connection);
                
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
                
                studentTable.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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

        private void courseTable_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[0].Value = "0000";
            e.Row.Cells[1].Value = "unknown";
            e.Row.Cells[2].Value = "fuck";
            e.Row.Cells[3].Value = "0";
            e.Row.Cells[4].Value = "1";
            e.Row.Cells[5].Value = "100";
        }

        private void serverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentTable.DataSource = bindingSource1;
            GetStuData("select * from 学生信息表");
        }
    }
}
