using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentENTITIES;
using StudentSERVİCE.Services;

namespace Stu_dentWeb_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetTeacherById(int id)
        {
            var response = await _teacherService.GetTeacher(id);
            if (response == null) return BadRequest();
            return Ok(response);
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllTeacher()
        {
            var response = await _teacherService.GetAllTeacher();
            if (response == null) return BadRequest();
            return Ok(response);
        }
        [HttpPut("UpdateTeacher")]
        public IActionResult UpdateTeacher(Teacher teacher, int id)
        {
            var response = _teacherService.UpdateTeacher(id, teacher);
            if (response == null) return BadRequest();
            return Ok(response);
        }
        [HttpDelete("DeleteTeacher")]
        public IActionResult DeleteTeacher(int id)
        {
            var response = _teacherService.DeleteTeacher(id);
            if (response == null) return BadRequest();
            return Ok(response);
        }
        [HttpPost("AddTeacher")]
        public IActionResult AddTeacher(Teacher teacher)
        {
            var response = _teacherService.AddTeacher(teacher);
            if (response == null) return BadRequest();
            return Ok(response);
        }

    }
}
