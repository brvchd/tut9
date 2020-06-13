using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tut9.Models;

namespace tut9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollStudentController : ControllerBase
    {
        private s18963Context _context;
        public EnrollStudentController(s18963Context context)
        {
            _context = context;
        }
    }
}
