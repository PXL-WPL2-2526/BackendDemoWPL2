using Demo.Application.Services;
using Demo.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentService _service;

        public StudentsController()
        {
            _service = new StudentService();
        }

        [HttpGet]
        public ActionResult<List<Student>> Get()
        {
            return Ok(_service.GetStudents());
        }
    }
}
