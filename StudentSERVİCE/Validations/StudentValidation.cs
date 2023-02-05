using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using StudentENTITIES;

namespace StudentSERVİCE.Validations
{
    public class StudentValidation:AbstractValidator<Student>
    {
        public StudentValidation()
        {
            RuleFor(x => x.FirstName).MinimumLength(3);
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Please enter your Lastname");
        }
        //Add new comments
    }
}
