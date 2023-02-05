using StudentENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentCORE.Wrappers;

namespace StudentSERVİCE.Services
{
    public interface ITeacherService
    {
        Task<Response<Teacher>> GetTeacher(int id);
        Task<Response<List<Teacher>>> GetAllTeacher();
        Response<bool> DeleteTeacher(int id);
        Response<bool> UpdateTeacher(int id, Teacher teacher);
        Response<bool> AddTeacher(Teacher teacher);
    }
}
