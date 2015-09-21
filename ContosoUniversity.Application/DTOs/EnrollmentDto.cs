using ContosoUniversity.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversity.Application.DTOs
{
    public class EnrollmentDto : BaseDto
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public Grade? Grade { get; set; }

        // TODO DTO Entity Framework navigation properties
        //public virtual Course Course { get; set; }
        //public virtual Student Student { get; set; }

        public CourseDto Course { get; set; }
        public StudentDto Student { get; set; }
    }
}
