using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using IBLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using RestSharp;

namespace CoreThree.Controllers
{
    [ApiController]
    public class Home : ControllerBase
    {
        IBLLStudentBLL _bll;
        public Home(IBLLStudentBLL BLL)
        {
            _bll = BLL;
        }
        [RouteAttribute("api/[controller]/GetStudents")]
        [HttpGet]
        public List<Student> GetStudents()
        {
            return _bll.GetStudents();
        }
        [RouteAttribute("api/[controller]/DeleStudent")]
        [HttpGet]
        public int DeleStudent(int Sid)
        {
            return _bll.DeleStudent(Sid);
        }
        [HttpPost]
        [RouteAttribute("api/[controller]/AddStudent")]
        public int AddStudent( [FromForm]Student s)
        {
            return _bll.AddStudent(s);
        }
        [HttpGet]
        [RouteAttribute("api/[controller]/GetStudentSing")]
        public Student GetStudentSing(int sid)
        {
            var List = _bll.GetStudentSing(sid);
            var Student = List.Where(s=>s.SId ==sid).FirstOrDefault();
            return Student;
        }
        [HttpPost]
        [RouteAttribute("api/[controller]/UpdateStudent")]
        public int UpdateStudent([FromForm] Student s)
        {
            return _bll.UpdateStudent(s);
        }
        [HttpGet]
        [RouteAttribute("api/[controller]/DeleteStudents")]
        public int DeleteStudents(string ids)
        {
            return _bll.DeleteStudents(ids);
        }
        [HttpGet]
        [RouteAttribute("api/[controller]/GetClassInfos")]
        public List<ClassInfo> GetClassInfos()
        {
            return _bll.GetClassInfos();
        }
    }
}
