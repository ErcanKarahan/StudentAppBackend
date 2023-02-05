using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentCORE.DataAccess;
using StudentENTITIES;

namespace StudentDAL.Repository
{
    public  interface ILessonRepository:IEntityRepository<Lesson>
    {
    }
}
