using Microsoft.AspNetCore.Mvc;
using StudentENTITIES;
using StudentSERVİCE.Services;

namespace Stu_dentWeb_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        private readonly ILessonService _lessonService;

        public LessonController(ILessonService lessonService)
        {
            _lessonService=lessonService;
        }
        [HttpGet("GetById")]
        public async Task<IActionResult> GetLessonById(int id)
        {
            var response = await _lessonService.GetLesson(id);
            if (response == null) return BadRequest();
            return Ok(response);
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllLesson()
        {
            var response = await _lessonService.GetAllLesson();
            if (response == null) return BadRequest();
            return Ok(response);
        }
        [HttpPut("UpdateLesson")]
        public IActionResult UodateLesson(Lesson lesson, int id)
        {
            var response = _lessonService.UpdateLesson(id, lesson);
            if (response == null) return BadRequest();
            return Ok(response);
        }
        [HttpDelete("DeleteLesson")]
        public IActionResult DeleteLesson(int id)
        {
            var response = _lessonService.DeleteLesson(id);
            if (response == null) return BadRequest();
            return Ok(response);
        }
        [HttpPost("Lesson")]
        public IActionResult AddLesson(Lesson lesson)
        {
            var response = _lessonService.AddLesson(lesson);
            if (response == null) return BadRequest();
            return Ok(response);
        }
    }
}
