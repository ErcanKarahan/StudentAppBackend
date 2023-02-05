using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using StudentCORE.Wrappers;
using StudentDAL.Repository;
using StudentENTITIES;

namespace StudentSERVİCE.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<Response<Student>> GetStudent(int id)
        {
            var response = _studentRepository.Get(x => x.Id == id && x.IsActive == ActiveType.Active);
            if (response != null)
            {
                return new Response<Student>()
                {
                    Data = response,
                    Succeeded = true,
                    Message = ""
                };
            }

            return new Response<Student>() { Data = null, Succeeded = false, Message = "Student not found " };

        }

        public async Task<Response<List<Student>>> GetAllStudent()
        {
            var response = _studentRepository.GetAllAsync();
            if (response != null)
            {
                return new Response<List<Student>>()
                {
                    Data = response,
                    Succeeded = true,
                    Message = ""
                };
            }
            return new Response<List<Student>>() { Data = new List<Student>(), Succeeded = false, Message = "Student not found " };
        }

        public Response<bool> DeleteStudent(int id)
        {
            var student = _studentRepository.Get(x => x.Id == id);
            if (student != null)
            {
                _studentRepository.DeleteAsync(student);
                return new Response<bool>() { Succeeded = true };
            }

            return new Response<bool>() { Succeeded = false };
        }

        public Response<bool> UpdateStudent(int id, Student student)
        {
            var response = _studentRepository.Get(x => x.Id == id);
            if (response != null)
            {
                _studentRepository.UpdateAsync(response);
                return new Response<bool>() { Succeeded = true };
            }

            return new Response<bool>() { Succeeded = false };
        }

        public Response<bool> AddStudent(Student student)
        {
            _studentRepository.CreateAsync(student);
            return new Response<bool>() { Succeeded = true };

        }

        public Response<bool> UpdateStudenById(int id, ActiveType type)
        {
            var response = _studentRepository.Get(x => x.Id == id);
            if (response != null)
            {
                response.IsActive = type;
                   _studentRepository.UpdateAsync(response);
                return new Response<bool>() { Succeeded = true };
            }

            return new Response<bool>() { Succeeded = false };
        }

        public async Task<Response<List<Student>>> GetAllActiveTypeStudents(ActiveType type)
        {
            var response =   _studentRepository.Where(x => x.IsActive == type);
            if (response != null)
            {
                return new Response<List<Student>>() { Data = response, Succeeded = true };
            }

            return new Response<List<Student>>() { Succeeded = false };
        }
    }
}
