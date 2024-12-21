using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student.Api.Services.StudentService;

namespace Student.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IEnumerable<MyStudent> Get()
        {
            return _studentService.Get();
        }
    }
}
