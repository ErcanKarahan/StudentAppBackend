using StudentDAL.Repository;
using StudentENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using StudentCORE.Wrappers;
using StudentSERVİCE.Services;

namespace StudentSERVİCE.Services
{
    public class LessonService : ILessonService
    {
        private readonly ILessonRepository _lessonRepository;

        public LessonService(ILessonRepository lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }

        public async Task<Response<Lesson>> GetLesson(int id)
        {
            var response = _lessonRepository.Get(x => x.Id == id);
            if (response != null)
            {
                return new Response<Lesson>()
                {
                    Data = response,
                    Succeeded = true,
                    Message = ""

                };
            }
            return new Response<Lesson>() { Data = new Lesson(), Succeeded = false, Message = "Lesson not found" };

        }

        public async Task<Response<List<Lesson>>> GetAllLesson()
        {
            var response = _lessonRepository.GetAllAsync();
            if (response!=null)
            {
                return new Response<List<Lesson>>()
                {
                    Data = response,
                    Succeeded = true,
                    Message = ""

                };
            }
            return new Response<List<Lesson>>() { Data = new List<Lesson>(), Succeeded=false,Message = "Lesson not found"};
        }

        public Response<bool> DeleteLesson(int id)
        {
            var lesson = _lessonRepository.Get(x => x.Id == id);
            if (lesson!=null)
            {
                _lessonRepository.DeleteAsync(lesson);
                return new Response<bool>() { Succeeded = true };
            }

            return new Response<bool>() { Succeeded = false };
        }

        public Response<bool> UpdateLesson(int id, Lesson lesson)
        {
            var response = _lessonRepository.Get(x => x.Id == id);
            if (response != null)
            {
                _lessonRepository.UpdateAsync(lesson);
                return new Response<bool>() { Succeeded = true };
            }

            return new Response<bool>() { Succeeded = false };
        }

        public Response<bool> AddLesson(Lesson lesson)
        {
            _lessonRepository.CreateAsync(lesson);
            return new Response<bool>() { Succeeded=true };

        }
    }
}
