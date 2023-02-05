using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentENTITIES
{
    public class Student : BaseEntity
    {
        
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? Age { get; set; }
        public string? StudentNumber { get; set; }
        public string? Section { get; set; }
        public int? SchoolId { get; set; }
 

    }
}
