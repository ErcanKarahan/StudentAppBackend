using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace StudentENTITIES
{
    public class School : BaseEntity
    {
        public string? Name { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }

        // Relational Properties

        public virtual List<Student> students { get; set; }
        public virtual List<Teacher> teachers { get; set; }
    }
}
