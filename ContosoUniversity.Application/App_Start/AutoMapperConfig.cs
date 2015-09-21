using AutoMapper;
using ContosoUniversity.Application.DTOs;
using ContosoUniversity.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversity.Application.App_Start
{
    public static class AutoMapperConfig
    {
        public static void ConfigureMappings()
        {
            Mapper.CreateMap<Course, CourseDto>();
            Mapper.CreateMap<Enrollment, EnrollmentDto>();
            Mapper.CreateMap<Student, StudentDto>();
        }
    }
}
