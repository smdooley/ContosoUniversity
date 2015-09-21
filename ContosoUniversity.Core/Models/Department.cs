using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversity.Core.Models
{
    public class Department : BaseModel
    {
        public int Id { get; set; }

        [StringLength(maximumLength: 50, MinimumLength = 3)]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        public decimal Budget { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        public int? InstructorId { get; set; }

        public virtual Instructor Instructor { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
