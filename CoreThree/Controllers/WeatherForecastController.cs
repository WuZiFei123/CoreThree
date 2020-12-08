using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using IBLL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model;

namespace CoreThree.Controllers
{
    [ApiController]
    //[Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        IBLLStudentBLL bll = new StudentBLL();
        [RouteAttribute("api/[controller]/GetStudents")]
        [HttpGet] 
        public List<Student> GetStudents()
        {
            return bll.GetStudents();
        }
    }
}
