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
    public partial class GradeForm : Form
    {
        SqlOperator sql = new SqlOperator();
        SqlDataAdapter dataAdapter;
        BindingSource bindingSource = new BindingSource();

        public GradeForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = bindingSource;
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(toolStripTextBox1.Text);
                GetData(dataGridView1, bindingSource, SqlCombine.getStudentNum(id));
            }
            catch (Exception)
            {
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string sid = dataGridView1.Rows[e.RowIndex].Cells[0].Value as string;
                int cid = int.Parse(toolStripTextBox1.Text);
                double ps, qm;
                if (dataGridView1.Rows[e.RowIndex].Cells[1].Value is DBNull)
                    ps = 0;
                else
                    ps = (double)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                if (dataGridView1.Rows[e.RowIndex].Cells[2].Value is DBNull)
                    qm = 0;
                else
                    qm = (double)dataGridView1.Rows[e.RowIndex].Cells[2].Value;
                string ty = comboBox1.Text;
                

                sql.SetGrade(sid, cid, ps, qm, ty);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
