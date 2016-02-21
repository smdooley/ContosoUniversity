using System.Collections.Generic;

namespace ContosoUniversity.Application.DTOs
{
    public class CourseDto : BaseDto
    {
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentId { get; set; }

        // TODO DTO Entity Framework navigation properties
        //public virtual ICollection<Enrollment> Enrollments { get; set; }

        public DepartmentDto Department { get; set; }
        public ICollection<EnrollmentDto> Enrollments { get; set; }
        public ICollection<InstructorDto> Instructors { get; set; }
    }
}
