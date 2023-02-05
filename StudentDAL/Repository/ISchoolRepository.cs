using StudentCORE.DataAccess;
using StudentENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDAL.Repository
{
    public  interface ISchoolRepository : IEntityRepository<School>
    {
    }
}
