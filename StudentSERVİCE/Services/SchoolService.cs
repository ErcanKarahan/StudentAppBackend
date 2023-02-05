using StudentCORE.Wrappers;
using StudentDAL.Repository;
using StudentENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSERVİCE.Services;

namespace SchoolSERVİCE.Services
{
    public class SchoolService : ISchoolService
    {
        private readonly ISchoolRepository _schoolRepository;
        public SchoolService(ISchoolRepository schoolRepository)
        {
            _schoolRepository = schoolRepository;
        }

        public async Task<Response<School>> GetSchool(int id)
        {
            var response = _schoolRepository.Get(x => x.Id == id);
            if (response != null)
            {
                return new Response<School>()
                {
                    Data = response,
                    Succeeded = true,
                    Message = ""
                };
            }

            return new Response<School>() { Data = new School(), Succeeded = false, Message = "School not found " };

        }

        public async Task<Response<List<School>>> GetAllSchool()
        {
            var response = _schoolRepository.GetAllAsync();
            if (response != null)
            {
                return new Response<List<School>>()
                {
                    Data = response,
                    Succeeded = true,
                    Message = ""
                };
            }
            return new Response<List<School>>() { Data = new List<School>(), Succeeded = false, Message = "School not found " };
        }

        public Response<bool> DeleteSchool(int id)
        {
            var school = _schoolRepository.Get(x => x.Id == id);
            if (school != null)
            {
                _schoolRepository.DeleteAsync(school);
                return new Response<bool>() { Succeeded = true };
            }

            return new Response<bool>() { Succeeded = false };
        }

        public Response<bool> UpdateSchool(int id, School school)
        {
            var response = _schoolRepository.Get(x => x.Id == id);
            if (response != null)
            {
                _schoolRepository.UpdateAsync(response);
                return new Response<bool>() { Succeeded = true };
            }

            return new Response<bool>() { Succeeded = false };
        }

        public Response<bool> AddSchool(School school)
        {
            _schoolRepository.CreateAsync(school);
            return new Response<bool>() { Succeeded = true };

        }
    }
}
