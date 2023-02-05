using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using StudentENTITIES;

namespace StudentSERVİCE.Validations
{
    public class LessonValidation:AbstractValidator<Lesson>
    {
        public LessonValidation()
        {
                RuleFor(x=> x.Name).NotEmpty(); 
        }
        
    }
}
