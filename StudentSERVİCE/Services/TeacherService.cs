using StudentCORE.Wrappers;
using StudentDAL;
using StudentDAL.Repository;
using StudentENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSERVİCE.Services;


namespace TeacherSERVİCE.Services
{
    public class TeacherService : ITeacherService
    {

        private readonly ITeacherRepository _teacherRepository;
        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public async Task<Response<Teacher>> GetTeacher(int id)
        {
            var response = _teacherRepository.Get(x => x.Id == id);
            if (response != null)
            {
                return new Response<Teacher>()
                {
                    Data = response,
                    Succeeded = true,
                    Message = ""
                };
            }

            return new Response<Teacher>() { Data = new Teacher(), Succeeded = false, Message = "Teacher not found " };

        }

        public async Task<Response<List<Teacher>>> GetAllTeacher()
        {
            var response = _teacherRepository.GetAllAsync();
            if (response != null)
            {
                return new Response<List<Teacher>>()
                {
                    Data = response,
                    Succeeded = true,
                    Message = ""
                };
            }
            return new Response<List<Teacher>>() { Data = new List<Teacher>(), Succeeded = false, Message = "Teacher not found " };
        }

        public Response<bool> DeleteTeacher(int id)
        {
            var teacher = _teacherRepository.Get(x => x.Id == id);
            if (teacher != null)
            {
                _teacherRepository.DeleteAsync(teacher);
                return new Response<bool>() { Succeeded = true };
            }

            return new Response<bool>() { Succeeded = false };
        }

        public Response<bool> UpdateTeacher(int id, Teacher teacher)
        {
            var response = _teacherRepository.Get(x => x.Id == id);
            if (response != null)
            {
                _teacherRepository.UpdateAsync(response);
                return new Response<bool>() { Succeeded = true };
            }

            return new Response<bool>() { Succeeded = false };
        }

        public Response<bool> AddTeacher(Teacher teacher)
        {
            _teacherRepository.CreateAsync(teacher);
            return new Response<bool>() { Succeeded = true };

        }

    }

    
}

