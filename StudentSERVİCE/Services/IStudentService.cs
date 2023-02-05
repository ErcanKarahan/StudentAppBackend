using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentCORE.Wrappers;
using StudentENTITIES;

namespace StudentSERVİCE.Services
{
    public interface IStudentService
    {
        Task<Response<Student>> GetStudent(int id);
        Task<Response<List<Student>>> GetAllStudent();
        Response<bool> DeleteStudent(int id);
        Response<bool> UpdateStudent(int id,Student student);
        Response<bool> AddStudent(Student student);
        Response<bool> UpdateStudenById(int id , ActiveType type);
        Task<Response<List<Student>>> GetAllActiveTypeStudents(ActiveType type);


    }
}
