using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Payment.Api.Services.StudentPaymentService;

namespace Payment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentPaymentController : ControllerBase
    {
        private readonly IstudentPaymentService _studentPaymentService;
        public StudentPaymentController(IstudentPaymentService studentPaymentService)
        {
            _studentPaymentService = studentPaymentService;
        }

        [HttpGet(Name = "Get-All")]
        public IEnumerable<StudentPayment> Get()
        {
            return _studentPaymentService.Get();
        }
    }
}
