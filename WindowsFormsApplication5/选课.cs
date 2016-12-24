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

namespace WindowsFormsApplication5
{
    public partial class 选课 : Form
    {
        SqlOperator sql = new SqlOperator();
        SqlDataAdapter dataAdapter;
        BindingSource bs = new BindingSource();

        public 选课()
        {
            InitializeComponent();
            dataGridView1.DataSource = bs;
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

        public void showData()
        {
            GetData(dataGridView1, bs, "select (学号,课程号) from 选课信息表");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (Convert.ToString(dataGridView1.Rows[r].Cells[0].Value) != "" && Convert.ToString(dataGridView1.Rows[r].Cells[1].Value) != "")
            {
                sql.studentChooseCourse(Convert.ToString(dataGridView1.Rows[r].Cells[0].Value), Convert.ToInt32(dataGridView1.Rows[r].Cells[1].Value));
            }
        }
    }
}
