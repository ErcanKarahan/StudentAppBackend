using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentCORE.DataAccess.Abstract;
using StudentENTITIES;

namespace StudentDAL.Repository
{
    public  interface ITeacherRepository:IEntityRepository<Teacher>
    {
    }
}
