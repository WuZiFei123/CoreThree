using IBLL;
using Model;
using System;
using System.Collections.Generic;
using DAL;

namespace BLL
{
    public class StudentBLL : IBLLStudentBLL
    {
        StudentDAL dal = new StudentDAL();
        //添加单个学生
        public int AddStudent(Student s)
        {
            return dal.AddStudent(s);
        }

        //删除单个学生
        public int DeleStudent(int Sid)
        {
            return dal.DeleStudent(Sid);
        }
        //根据Id查询单个学生
        public List<Student> GetStudentSing(int sid)
        {
            return dal.GetStudentSing(sid);
        }

        //查询所有学生
        public List<Student> GetStudents()
        {
            return dal.GetStudents();
        }
        //修改学生
        public int UpdateStudent(Student s)
        {
            return dal.UpdateStudent(s);
        }
        //批量删除学生
        public int DeleteStudents(string ids)
        {
            return dal.DeleteStudents(ids);
        }
        //查询所有班级
        public List<ClassInfo> GetClassInfos()
        {
            return dal.GetClassInfos();
        }
    }
}
