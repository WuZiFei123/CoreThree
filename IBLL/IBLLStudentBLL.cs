using Model;
using System;
using System.Collections.Generic;

namespace IBLL
{
    public interface IBLLStudentBLL
    {
        List<Student> GetStudents();
        int DeleStudent(int Sid);
        int AddStudent(Student ssss);  
        List<Student> GetStudentSing(int sid);
        int UpdateStudent(Student s);
        int DeleteStudents(string ids);
        List<ClassInfo> GetClassInfos();
    }
}
