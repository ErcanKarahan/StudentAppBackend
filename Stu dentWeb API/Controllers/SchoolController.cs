using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentENTITIES;
using StudentSERVİCE.Services;

namespace Stu_dentWeb_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly ISchoolService _schoolService;

        public SchoolController(ISchoolService schoolService)
        {
            _schoolService = schoolService;
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetSchoolById(int id)
        {
            var response = await _schoolService.GetSchool(id);
            if (response == null) return BadRequest();
            return Ok(response);
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAllSchool()
        {
            var response = await _schoolService.GetAllSchool();
            if (response == null) return BadRequest();
            return Ok(response);
        }
        [HttpPut]
        public IActionResult UodateSchool(School school, int id)
        {
            var response = _schoolService.UpdateSchool(id, school);
            if (response == null) return BadRequest();
            return Ok(response);
        }
        [HttpDelete]
        public IActionResult DeleteSchool(int id)
        {
            var response = _schoolService.DeleteSchool(id);
            if (response == null) return BadRequest();
            return Ok(response);
        }
        [HttpPost]
        public IActionResult AddSchool(School school)
        {
            var response = _schoolService.AddSchool(school);
            if (response == null) return BadRequest();
            return Ok(response);
        }
    }
}
