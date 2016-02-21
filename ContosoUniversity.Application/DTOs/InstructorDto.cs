using System;
using System.Collections.Generic;

namespace ContosoUniversity.Application.DTOs
{
    public class InstructorDto : BaseDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }

        public string FullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }

        public virtual ICollection<CourseDto> Courses { get; set; }
        public virtual OfficeAssignmentDto OfficeAssignment { get; set; }
    }
}
