using StudentENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentCORE.Wrappers;

namespace StudentSERVİCE.Services
{
    public interface ISchoolService
    {
        Task<Response<School>> GetSchool(int id);
        Task<Response<List<School>>> GetAllSchool();
        Response<bool> DeleteSchool(int id);
        Response<bool> UpdateSchool(int id, School school);
        Response<bool> AddSchool(School school);

    }
}
