using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tut9.Models;
using tut9.Services;

namespace tut9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentDbService _service;
         
        public StudentController(IStudentDbService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult StudentList()
        {
            return Ok(_service.Student.ToList());
        }

       

    }
}
