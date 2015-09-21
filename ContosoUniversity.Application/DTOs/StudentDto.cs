using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversity.Application.DTOs
{
    public class StudentDto : BaseDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        //TODO DTO Entity Framework navigation properties
        //public virtual ICollection<Enrollment> Enrollments { get; set; }

        public ICollection<EnrollmentDto> Enrollments { get; set; }
    }
}
