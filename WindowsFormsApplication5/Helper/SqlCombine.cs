using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5.Helper
{
    //用于拼接形成sql 语句
    //人间自有真情在
    //不要注入最可爱
    public class SqlCombine
    {
        public static string addStudent(string number, string name, string studentClass, string major)
        {
            return $"insert into 学生信息表 (学号,姓名,班级,专业) values('{number}','{name}','{studentClass}','{major}');";
        }
        public static string removeStudent(string number)
        {
            return $"delete form 学生信息表 where (学号='{number}')";
        }
        public static string addCourse(int courseNumber, string name, string teacherName, double b, bool canResit,double xuefen)
        {
            return $"insert into 课程信息表 (课程号,课程名字,任课老师,期末成绩占总成绩比,允许补考,学分)" +
                $" values({courseNumber},'{name}','{teacherName}',{b},{(canResit ? 1 : 0)},{xuefen})";
        }
        public static string removeCourse(int courseNumber)
        {
            return $"delete form 学生信息表 where (课程号={courseNumber})";
        }
        public static string studentChooseCourse(string studentId, int courseId)
        {
            return $"insert into 选课成绩表(学号,课程号) values ('{studentId}',{courseId})";
        }
        public static string ModefyGrade(string studentID, int courseId, double pingshichengji, double qimochengji, double b,string type)
        {
            return
                $"update 选课成绩表 set 平时成绩 = {pingshichengji} where(学号 = '{studentID}' and 课程号 = {courseId});\n" +
                $"update 选课成绩表 set 期末成绩 = {qimochengji} where(学号 = '{studentID}' and 课程号 = {courseId});\n" +
                $"update 选课成绩表 set 总评 = {pingshichengji * (1 - b) + qimochengji * b} where(学号 = '{studentID}' and 课程号 = {courseId});\n" +
                $"update 选课成绩表 set 成绩类型 = '{type}' where(学号 = '{studentID}' and 课程号 = {courseId});";

        }
        public static string getBi(int courseId)
        {
            return "select 期末成绩占总成绩比 from 课程信息表 where (课程号= " + Convert.ToString(courseId) + ")";
        }
        public static string getGreatStudent()
        {
            string x = "select 学号,姓名,班级 from 学生信息表 where 学号 not in(select 学号 from 选课成绩表 where 成绩类型 !='" + "正常'" + "or 总评<=" + Convert.ToString(85) + "); ";
            return x;
        }
        //获取需要补考的名单
        public static string getResitCourse(string studentId)
        {
            string x="select 学号, 课程号 into #a from 选课成绩表 where 总评>=60;" + "\n";
            string y = "select 选课成绩表.学号,选课成绩表.课程号 into #b from 选课成绩表,#a where not (选课成绩表.学号=#a.学号 and 选课成绩表.课程号=#a.课程号);" + "\n";
            string z="select 学号, 课程号 into #c from #b where 课程号 in (select 课程号 from 课程信息表 where 允许补考=1);"+"\n";
            string xx = "select #c.学号,学生信息表.姓名,#c.课程号 into #d from #c left join 学生信息表 on #c.学号=学生信息表.学号;\n";
            string yy= "select #d.学号,#d.姓名,#d.课程号,课程信息表.课程名字 from #d left join 课程信息表 on #d.课程号=课程信息表.课程号;";
            return x + y + z+xx+yy;
        }
        //获取重修的名单
        public static string getCantResitCourse(string studentId)
        {
            string x = "select 学号, 课程号 into #a from 选课成绩表 where 总评>=60;" + "\n";
            string y = "select 选课成绩表.学号,选课成绩表.课程号 into #b from 选课成绩表,#a where not (选课成绩表.学号=#a.学号 and 选课成绩表.课程号=#a.课程号);" + "\n";
            string z = "select 学号, 课程号 from #b where 课程号 in (select 课程号 from 课程信息表 where 允许补考=0);" + "\n";
            string xx = "select #c.学号,学生信息表.姓名,#c.课程号 into #d from #c left join 学生信息表 on #c.学号=学生信息表.学号;\n";
            string yy = "select #d.学号,#d.姓名,#d.课程号,课程信息表.课程名字 from #d left join 课程信息表 on #d.课程号=课程信息表.课程号;";
            return x + y + z + xx + yy;
        }
        //打印补考的成绩
        public static string printResitGrade()
        {
            string x = "select 学号,课程号,总评 from 选课成绩表 where 成绩类型 = '补考'; ";
            return x;
        }
        //打印重修的成绩
        public static string printCantResitGrade()
        {
            string x = "select 学号, 课程号, 总评 from 选课成绩表 where 成绩类型 = '重修'; ";
            return x;
        }
        //获取选该课的人
        public static string getStudentNum(int courseNumber)
        {
            return $"select 学号,平时成绩,期末成绩,成绩类型 from 选课成绩表 where 课程号={courseNumber};";
        }
    }
}
