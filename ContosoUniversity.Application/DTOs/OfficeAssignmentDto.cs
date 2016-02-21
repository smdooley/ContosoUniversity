
namespace ContosoUniversity.Application.DTOs
{
    public class OfficeAssignmentDto
    {
        public int InstructorId { get; set; }
        public string Location { get; set; }

        public InstructorDto Instructor { get; set; }
    }
}
