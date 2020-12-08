using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DAL
{
   public class StudentDAL
    {
        //查询所有学生信息
        public List<Student> GetStudents()
        {
            string sql = "select * from Student";
            return DBHelper.GetList<Student>(sql);
        }
        //删除单个学生
        public int DeleStudent(int Sid)
        {
            string sql = $"delete from Student where SId = {Sid}";
            return DBHelper.CDU(sql);
        }
        //添加单个学生
        public int AddStudent(Student s)
        {
            string sql = $"insert into Student values('{s.SName}',{s.SAge},'{s.SHome}',{s.ClassInfoIdOut})";
            return DBHelper.CDU(sql);
        }
        //根据Id查询单个学生
        public List<Student> GetStudentSing(int sid)
        {
            string sql = $"select * from Student where SId = {sid}";
            return DBHelper.GetList<Student>(sql);
        }
        //修改学生
        public int UpdateStudent(Student s)
        {
            string sql = $"update Student set SName='{s.SName}',SAge={s.SAge},SHome='{s.SHome}',ClassInfoIdOut={s.ClassInfoIdOut} where SId = {s.SId}";
            return DBHelper.CDU(sql);
        }
        //批量删除学生
        public int DeleteStudents(string ids)
        {
            string sql = $"delete from Student where SId in ({ids})";
            return DBHelper.CDU(sql);
        }
        //查询所有班级
        public List<ClassInfo> GetClassInfos()
        {
            string sql = $"select * from ClassInfo";
            return DBHelper.GetList<ClassInfo>(sql);
        }
    }
}
