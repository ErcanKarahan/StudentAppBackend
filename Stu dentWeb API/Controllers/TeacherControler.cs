using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentENTITIES;
using StudentSERVİCE.Services;

namespace Stu_dentWeb_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherControler : ControllerBase
    {
        private readonly ITeacherService _teacherService;

        public TeacherControler(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetTeacherById(int id)
        {
            var response = await _teacherService.GetTeacher(id);
            if (response == null) return BadRequest();
            return Ok(response);
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAllTeacher()
        {
            var response = await _teacherService.GetAllTeacher();
            if (response == null) return BadRequest();
            return Ok(response);
        }
        [HttpPut]
        public IActionResult UpdateStudent(Teacher teacher, int id)
        {
            var response = _teacherService.UpdateTeacher(id, teacher);
            if (response == null) return BadRequest();
            return Ok(response);
        }
        [HttpDelete]
        public IActionResult DeleteTeacher(int id)
        {
            var response = _teacherService.DeleteTeacher(id);
            if (response == null) return BadRequest();
            return Ok(response);
        }
        [HttpPost]
        public IActionResult AddTeacher(Teacher teacher)
        {
            var response = _teacherService.AddTeacher(teacher);
            if (response == null) return BadRequest();
            return Ok(response);
        }

    }
}
