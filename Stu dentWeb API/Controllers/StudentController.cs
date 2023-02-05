using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentENTITIES;
using StudentSERVİCE.Services;

namespace Stu_dentWeb_API.Controllers
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

        [HttpGet("GetById")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var response = await _studentService.GetStudent(id);
            if (response == null) return BadRequest();
            return Ok(response);
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllStudent()
        {
            var response = await _studentService.GetAllStudent();
            if (response == null) return BadRequest();
            return Ok(response);
        }
        [HttpPost("AddStudent")]
        public IActionResult AddStudent(Student student)
        {
            var response = _studentService.AddStudent(student);
            if (response == null) return BadRequest();
            return Ok(response);
        }
        [HttpPut("UpdateStudent")]
        public IActionResult UpdateStudent(Student student,int id)
        {
            var response = _studentService.UpdateStudent(id,student);
            if (response == null) return BadRequest();
            return Ok(response);
        }
        [HttpDelete("DeleteStudent")]
        public IActionResult DeleteStudent( int id)
        {
            var response = _studentService.DeleteStudent(id);
            if (response == null) return BadRequest();
            return Ok(response);
        }
        [HttpPut("GetIsActive")]
        public IActionResult UpdateStudentIsActive(int id,ActiveType type)
        {
            var response = _studentService.UpdateStudenById(id,type);
            if (response == null) return BadRequest();
            return Ok(response);
        }
        [HttpGet("GetActiveTypeList")]
        public IActionResult UpdateStudentIsActive(ActiveType type)
        {
            var response = _studentService.GetAllActiveTypeStudents(type);
            if (response == null) return BadRequest();
            return Ok(response);
        }
    }
}
