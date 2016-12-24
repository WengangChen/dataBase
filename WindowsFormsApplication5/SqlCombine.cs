using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    //用于拼接形成sql 语句
    //人间自有真情在
    //不要注入最可爱
    public class SqlCombine
    {
        public static string addStudent(string number, string name, string studentClass, string major)
        {
            return "insert into 学生信息表 (学号,姓名,班级,专业) values('" + number + "','" + name + "','" + studentClass + "','" + major + "');";
        }
        public static string removeStudent(string number)
        {
            return "delete from 学生信息表 where " +"学号 = '"+ number +"'";
        }
        public static string addCourse(int courseNumber,string name, string teacherName,double b,bool canResit=false)
        {
            return "insert into 课程信息表 (课程号,课程名字,任课老师,期末成绩占总成绩比,允许补考) values("
                + Convert.ToString(courseNumber) + ",'" + name + "','" + teacherName + "','" + Convert.ToString(b) + (canResit ? "1" : "0");
        }
        public static string removeCourse(int courseNumber)
        {
            return "delete from 学生信息表 where (课程号="+ Convert.ToString(courseNumber)+")";
        }
        public static string studentChooseCourse(string studentId,int courseId)
        {
            return "insert into 选课成绩表(学号,课程号) values ('" + studentId + "'," + Convert.ToString(courseId) + ")";
        }
        public static string ModefyGrade(string studentID,int courseId,double pingshichengji,double qimochengji,double b)
        {
            return "update 选课成绩表 set 平时成绩 = " + Convert.ToString(pingshichengji) + " where(学号 = '" + studentID + "' and 课程号 = " + Convert.ToString(courseId) + ");\n" +
                    "update 选课成绩表 set 期末成绩 = " + Convert.ToString(pingshichengji) + " where(学号 = '" + studentID + "' and 课程号 = " + Convert.ToString(courseId) + ");\n" +
                    "update 选课成绩表 set 总评 = " + Convert.ToString(pingshichengji * (1 - b) + qimochengji * b) + " where(学号 = '" + studentID + "' and 课程号 = " + Convert.ToString(courseId) + ");\n";
        }
        public static string getBi(int courseId)
        {
            return "select 期末成绩占总成绩比 from 课程信息表 where (课程号= " + Convert.ToString(courseId) + ")";
        }
    }
}
