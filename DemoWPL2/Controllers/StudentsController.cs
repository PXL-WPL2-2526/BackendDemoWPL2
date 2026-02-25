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

        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {
            _service.AddStudent(student.FirstName, student.LastName);
            return Ok();
        }

        [HttpPost("delete")]
        public IActionResult Delete(int id)
        {
            _service.DeleteStudent(id);
            return Ok();
        }
    }
}
