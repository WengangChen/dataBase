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
    public partial class 评优的 : Form
    {
        SqlOperator sql = new SqlOperator();
        SqlDataAdapter dataAdapter;
        BindingSource bs = new BindingSource();
        public 评优的()
        {
            InitializeComponent();
            dataGridView2.DataSource = bs;
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void showData()
        {
            GetData(dataGridView2, bs, SqlCombine.getGreatStudent());
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
