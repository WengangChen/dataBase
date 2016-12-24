using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication5
{
    public class SqlOperator
    {
        System.Data.SqlClient.SqlConnection connection;
        public SqlOperator()
        {
            //Data Source=DESKTOP-1TVQMNU\SQLEXPRESS
            SqlConnectionStringBuilder cstr = new SqlConnectionStringBuilder();
            cstr.DataSource = Config.server;
            cstr.InitialCatalog = "DataBase";
            cstr.UserID = "admin";
            cstr.Password = "12345678";
            cstr.NetworkLibrary = "DBMSSOCN";
            string connectionString = cstr.ToString();
            connection = new SqlConnection(connectionString);
        //    connection.Open();
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        ~SqlOperator()
        {
            try
            {
                connection.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        // private IPAddress addr;
        public void addStudent(string number, string name, string studentClass, string major)
        {
            try
            {
                string x = SqlCombine.addStudent(number, name, studentClass, major);
                SqlCommand p = new SqlCommand(x);
                p.Connection = connection;
                p.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void removeStudent(string number)
        {
            try
            {
                string x = SqlCombine.removeStudent(number);
                SqlCommand p = new SqlCommand(x);
                p.Connection = connection;
                p.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void addCourse(int courseNumber, string name, string teacherName, double b, bool canResit = false)
        {
            try
            {
                string x = SqlCombine.addCourse(courseNumber, name, teacherName, b, canResit);
                SqlCommand p = new SqlCommand(x);
                p.Connection = connection;
                p.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        public void removeCourse(int courseNumber)
        {
            try
            {
                string x = SqlCombine.removeCourse(courseNumber);
                SqlCommand p = new SqlCommand(x);
                p.Connection = connection;
                p.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void studentChooseCourse(string studentId, int courseId)
        {
            string x = SqlCombine.studentChooseCourse(studentId, courseId);
            SqlCommand p = new SqlCommand(x);
            p.Connection = connection;
            p.ExecuteReader();
        }
        public void SetGrade(string studentID, int courseId, double pingshi, double qimo)
        {
            try
            {

                string selc = SqlCombine.getBi(courseId);
                SqlCommand p = new SqlCommand(selc);
                p.Connection = connection;
                SqlDataReader result = p.ExecuteReader();
                if (!result.HasRows)
                    throw new Exception("找不到该课程");
                //课程信息
                double b = result.GetFloat(0);
                double xf = result.GetFloat(1);
                //
                string x = "select 学分 from 学生信息表 where 学号='" + studentID + "';";
                p.CommandText = x;
                result = p.ExecuteReader();
                //当前的学分
                double y = result.GetFloat(0);

                x = "select 总评 from 选课成绩表 where (学号='" + studentID + "'and 课程号 = " + Convert.ToString(courseId) + ");";
                p.CommandText = x;
                result = p.ExecuteReader();
                //获得学分
                if (result.GetFloat(0) < 60 && qimo * b + (1 - b) * pingshi >= 60)
                {
                    x = "update 学生信息表 set 学分 = " + Convert.ToString(y) + "where 学号='" + studentID + "';";
                    p.CommandText = x;
                    p.ExecuteReader();
                }
                x = SqlCombine.ModefyGrade(studentID, courseId, pingshi, qimo, b);
                p.CommandText = x;
                p.Connection = connection;
                p.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
    }
}
