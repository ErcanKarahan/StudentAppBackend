using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentCORE.DataAccess.İConcrete;
using StudentDAL.Context;
using StudentDAL.Repository;
using StudentENTITIES;

namespace StudentDAL
{
    public class StudentRepository : EntityRepository<Student, ApplicationContext>, IStudentRepository
    {
    }

}
