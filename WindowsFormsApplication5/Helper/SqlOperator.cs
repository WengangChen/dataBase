﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication5.Helper
{
    public class SqlOperator : IDisposable
    {
        public SqlConnection Connection { private set; get; }
        
        public SqlOperator()
        {
            SqlConnectionStringBuilder cstr = new SqlConnectionStringBuilder();
            cstr.DataSource = Config.Server;
            cstr.InitialCatalog = "DataBase";
            cstr.UserID = "admin";
            cstr.Password = "12345678";
            cstr.NetworkLibrary = "DBMSSOCN";
            string connectionString = cstr.ToString();
            Connection = new SqlConnection(connectionString);
            try
            {
                Connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void addStudent(string number, string name, string studentClass, string major)
        {
            try
            {
                string x = SqlCombine.addStudent(number, name, studentClass, major);
                SqlCommand p = new SqlCommand(x);
                p.Connection = Connection;
                p.ExecuteNonQuery();
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
                p.Connection = Connection;
                p.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void addCourse(int courseNumber, string name, string teacherName, double b, bool canResit,double xuefen)
        {
            try
            {
                string x = SqlCombine.addCourse(courseNumber, name, teacherName, b, canResit,xuefen);
                SqlCommand p = new SqlCommand(x);
                p.Connection = Connection;
                p.ExecuteNonQuery();
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
                p.Connection = Connection;
                p.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void studentChooseCourse(string studentId, int courseId)
        {
            try
            {
                string x = SqlCombine.studentChooseCourse(studentId, courseId);
                SqlCommand p = new SqlCommand(x);
                p.Connection = Connection;
                p.ExecuteNonQuery();
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void SetGrade(string studentID, int courseId, double pingshi, double qimo)
        {
            try
            {
                string selc = SqlCombine.getBi(courseId);
                SqlCommand p = new SqlCommand(selc);
                p.Connection = Connection;
                SqlDataReader result = p.ExecuteReader();
                if (!result.HasRows)
                    throw new Exception("找不到该课程");
                double b = result.GetDouble(0);
                string x = SqlCombine.ModefyGrade(studentID, courseId, pingshi, qimo, b);
                p.CommandText = x;
                p.Connection = Connection;
                p.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        public DataSet getGreatStudent()
        {
            string x = "select (学号,姓名，班级) from 学生信息表 where 学号 not in(select 学号 from 选课成绩表 where 成绩类型 !='" + "普通" + "or 成绩<=" + Convert.ToString(85) + "); ";
            DataSet xx = new DataSet();
            SqlDataAdapter p = new SqlDataAdapter(x, Connection);
            p.Fill(xx);
            return xx;
        }
        
        public void Dispose()
        {
            try
            {
                Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}