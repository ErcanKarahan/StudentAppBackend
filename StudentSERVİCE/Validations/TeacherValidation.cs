using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using StudentENTITIES;

namespace StudentSERVİCE.Validations
{
    public class TeacherValidation:AbstractValidator<Teacher>
    {
        public TeacherValidation()
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
        }
    }
}
