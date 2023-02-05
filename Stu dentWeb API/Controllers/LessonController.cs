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
        [HttpGet("getbyid")]
        public async Task<IActionResult> GetLessonById(int id)
        {
            var response = await _lessonService.GetLesson(id);
            if (response == null) return BadRequest();
            return Ok(response);
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAllSchool()
        {
            var response = await _lessonService.GetAllLesson();
            if (response == null) return BadRequest();
            return Ok(response);
        }
        [HttpPut]
        public IActionResult UodateSchool(Lesson lesson, int id)
        {
            var response = _lessonService.UpdateLesson(id, lesson);
            if (response == null) return BadRequest();
            return Ok(response);
        }
        [HttpDelete]
        public IActionResult DeleteSchool(int id)
        {
            var response = _lessonService.DeleteLesson(id);
            if (response == null) return BadRequest();
            return Ok(response);
        }
        [HttpPost]
        public IActionResult AddLesson(Lesson lesson)
        {
            var response = _lessonService.AddLesson(lesson);
            if (response == null) return BadRequest();
            return Ok(response);
        }
    }
}
