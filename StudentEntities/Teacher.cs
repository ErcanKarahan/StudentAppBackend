using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentENTITIES
{
    public class Teacher:BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? Age { get; set; }
        public string? Section { get; set; }
        public int SchoolId { get; set; }

        //Relational Properties

        //public virtual List<Lesson> lessons { get; set; }
        //public virtual School school { get; set; }
        
    }
}
