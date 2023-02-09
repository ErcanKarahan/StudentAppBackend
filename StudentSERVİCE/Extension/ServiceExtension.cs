using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using SchoolSERVİCE.Services;
using StudentDAL;
using StudentDAL.Repository;
using StudentSERVİCE.Services;
using TeacherSERVİCE.Services;

namespace StudentSERVİCE.Extension
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddRegistration(this  IServiceCollection services)
        {
            services.AddScoped<ISchoolRepository, SchoolRepository>();
            services.AddScoped<ILessonRepository, LessonRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<ILessonService, LessonService>(); 
            services.AddScoped<ISchoolService, SchoolService>();

            return services;
        }
    }
}
