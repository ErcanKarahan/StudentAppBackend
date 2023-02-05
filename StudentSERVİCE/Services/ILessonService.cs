using StudentENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentCORE.Wrappers;

namespace StudentSERVİCE.Services
{
    public interface ILessonService
    {
        Task<Response<Lesson>> GetLesson(int id);
        Task<Response<List<Lesson>>> GetAllLesson();
        Response<bool> DeleteLesson(int id);
        Response<bool> UpdateLesson(int id, Lesson lesson);
        Response<bool> AddLesson(Lesson lesson);

    }
}
